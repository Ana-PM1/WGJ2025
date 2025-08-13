// ClickableObject.cs
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickableObject : MonoBehaviour //IPointerClickHandler
{
    public GameManager gameManager;
    bool clicked = false;

    void Start()
    {
        if (gameManager == null)
            Debug.LogWarning($"{name}: asigna GameManager en el inspector.");
    }

    /*public void OnClickEnter(PointerEventData eventData)
    {
        if (clicked) return; // evita dobles clicks
        clicked = true;
        Debug.Log("Clic en: " + gameObject.name); // <-- Esto debe aparecer en la consola
        if (gameManager != null)
            gameManager.ObjectFound(this);
    }*/

    /* void Update()
     {
         if (Input.GetMouseButtonDown(0))
         {
             Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
             RaycastHit hit;
             if (Physics.Raycast(ray, out hit))
             {
                 if( hit.collider.gameObject == gameObject && !clicked ) 
                 {
                     clicked = true;
                     Debug.Log("Clic en: " + gameObject.name);
                     if ( gameManager != null) 
                     {
                         gameManager.ObjectFound(this);
                     }
                 }
             }
         }
     }*/
    private void OnMouseDown()
    {
        if (clicked) return;
        clicked = true;

        Debug.Log("Clic en: " + gameObject.name);
        gameManager.ObjectFound(this);
    }
}

