using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject Overlay;
    public GameObject textBoxUI;
    public GameObject chululu;


    public GameObject BGM;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject volverButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;
    // Start is called before the first frame update
    void Update()
    {
        textLength = TextCreator.charCount;
    }
    void Start()
    {
        StartCoroutine(EventStarter());
    }

    public IEnumerator EventStarter()
    {
        //Event 0
        fadeScreenIn.SetActive(false);
        chululu.SetActive(true);
        textBoxUI.SetActive(true);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chululu";
        textToSpeak = "...";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        yield return new WaitForSeconds(2);
        // fadeScreenOut.SetActive(true);
        eventPos = 1;

    }


    public IEnumerator EventOne()
    {
        //Event 0
        nextButton.SetActive(false);

        // yield return new WaitForSeconds(2);
        textBoxUI.SetActive(true);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chululu";
        textToSpeak = "Mucho condimento.";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 2;

    }
    public IEnumerator EventTwo()
    {
        //Event 1
        nextButton.SetActive(false);
        Overlay.SetActive(true);
        volverButton.SetActive(true);
        /*charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "¡ESPERA!... Ay, ya se fue... a ver, pensemos...";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);*/
        yield return new WaitForSeconds(0.02f);
        //eventPos = 8;

    }




    public void NextButton()
    {


        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }

        if (eventPos == 2)
        {
            StartCoroutine(EventTwo());
        }

        
    }

    public void MainMenuButton()
    {
        SceneManager.LoadSceneAsync("MainScene");
    }
}
