using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject Overlay;
    public GameObject textBoxUI;
    public GameObject charMC;
    public GameObject charMCyMiranda;

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
        charMC.SetActive(true);
        textBoxUI.SetActive(true);
        mainTextObject.SetActive(true);
        charMC.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "Es, es… ¡Genial!. Siento músculos en mis músculos. ¡Ahora si la conquistaré!";
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
        charName.GetComponent<TMPro.TMP_Text>().text = " ";
        textToSpeak = "Juan volteó a los lados, Chululú no había vuelto pero lo había dejado en su casa con un cuerpo nuevo. " +
            "Motivado aún así fue a pedirle a Miranda que fuera su novia.";
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
        charMC.SetActive(false);
        //chululu.SetActive(true) ;
        charName.GetComponent<TMPro.TMP_Text>().text = " ";
        textToSpeak = "...";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 3;
    }

    public IEnumerator EventThree()
    {
        //Event 1
        nextButton.SetActive(false);

        // BGMChululu.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "No lo entiendo, soy perfecto";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 4;
    }
    public IEnumerator EventFour()
    {
        //Event 1
        nextButton.SetActive(false);
        
        charMCyMiranda.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "Miranda lo había rechazado, era la primera vez que hablaban y estaba más que justificada su incomodidad por el arrebato de Juanito. " +
            "De forma tranquila se lo había explicado, le dio la razón, sus ojos brillaban como si hubiera tenido una relevación. Por fin lo había comprendido. ";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        
        eventPos = 5;
    }

    public IEnumerator EventFive()
    {
        //Event 1
        nextButton.SetActive(false);
        charMCyMiranda.SetActive(false);
        charMC.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "¡Chululú vuelve! Necesito otro cuerpo!";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);

        eventPos = 6;

    }

    public IEnumerator EventSix()
    {
        //Event 1
        nextButton.SetActive(false);


        charName.GetComponent<TMPro.TMP_Text>().text = " ";
        textToSpeak = "... Casi.";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
      
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 7;

    }

    public IEnumerator EventSeven()
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

        if (eventPos == 3)
        {
            StartCoroutine(EventThree());
        }

        if (eventPos == 4)
        {
            StartCoroutine(EventFour());
        }

        if (eventPos == 5)
        {
            StartCoroutine(EventFive());
        }

        if (eventPos == 6)
        {
            StartCoroutine(EventSix());
        }

        if (eventPos == 7)
        {
            StartCoroutine(EventSeven());
        }
    }

    public void MainMenuButton()
    {
            SceneManager.LoadSceneAsync("MainScene");
    }
}
