// GameManager.cs
using UnityEngine;
using UnityEngine.UI;
using TMPro; // importante para TextMeshPro
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    [Header("UI")]
    public RawImage targetImage;
    public TMP_Text timerText;      // Ahora es TMP_Text
    public TMP_Text resultText;     // Ahora es TMP_Text

    [Header("Gameplay")]
    public List<ClickableObject> objectsToFind; // Los 8 objetos
    public float timeRemaining = 60f;

    private int currentIndex = 0;
    private bool gameActive = true;

    public GraphicRaycaster raycaster;
    public EventSystem eventSystem;

    void Start()
    {
        if (objectsToFind == null || objectsToFind.Count == 0)
        {
            Debug.LogError("Lista objectsToFind vacía. Añade los 8 objetos en el inspector.");
            gameActive = false;
            return;
        }

        if (objectsToFind.Count != 8)
            Debug.LogWarning($"Se esperan 8 objetos pero hay {objectsToFind.Count}. Ajusta la lista a 8.");

        resultText.text = "";
        UpdateTargetImage();
        UpdateTimerText();
    }

    void Update()
    {
        if (!gameActive) return;

        timeRemaining -= Time.deltaTime;
        if (timeRemaining < 0f) timeRemaining = 0f;
        UpdateTimerText();

        if (timeRemaining <= 0f)
            EndGame(false);

        if (Input.GetMouseButtonDown(0))
        {
            PointerEventData pointerData = new PointerEventData(eventSystem)
            {
                position = Input.mousePosition
            };

            List<RaycastResult> results = new List<RaycastResult>();
            raycaster.Raycast(pointerData, results);

            foreach (RaycastResult result in results)
            {
                Debug.Log("Clic en el objeto: " + result.gameObject.name);

                // Buscar si tiene el script ClickableObject
                ClickableObject clickedObj = result.gameObject.GetComponent<ClickableObject>();

                if (clickedObj != null)
                {
                    ObjectFound(clickedObj);
                    break; // solo procesar el primero
                }
            }
        }
    }

    public void ObjectFound(ClickableObject obj)
    {
        if (!gameActive) return;
        if (currentIndex >= objectsToFind.Count) return;

        if (obj != objectsToFind[currentIndex]) return;

        obj.gameObject.SetActive(false);
        currentIndex++;

        if (currentIndex >= objectsToFind.Count)
        {
            EndGame(true);
            return;
        }

        UpdateTargetImage();
    }

    void UpdateTargetImage()
    {
        var nextGo = objectsToFind[currentIndex];
        var raw = nextGo.GetComponent<RawImage>();
        if (raw != null && raw.texture != null)
        {
            targetImage.texture = raw.texture;
            targetImage.enabled = true;
        }
        else
        {
            Debug.LogError("El siguiente objeto no tiene RawImage o texture: " + nextGo.name);
            targetImage.enabled = false;
        }
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void EndGame(bool win)
    {
        gameActive = false;
        targetImage.enabled = false;
        resultText.text = win ? "¡Ganaste!" : "Perdiste";
    }
}
