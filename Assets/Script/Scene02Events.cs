using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene02Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject BGCuartoDelGuapo;
    public GameObject charMC;
    public GameObject chululu;
    public GameObject textBoxUI;

    public GameObject BGMChululu;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;

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
        // charMC.SetActive(true);
        textBoxUI.SetActive(true);
        mainTextObject.SetActive(true);
        charMC.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "¡Dios! ¿Dónde estamos?";
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
        chululu.SetActive(true);
       // yield return new WaitForSeconds(2);
        textBoxUI.SetActive(true);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chululu";
        textToSpeak = "Ah no, eso si que no, yo con él no laboro... pero bueno, aquí es la habitación de tu jurado némesis, Christian.";
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

        //chululu.SetActive(true) ;
        charName.GetComponent<TMPro.TMP_Text>().text = "Chululu";
        textToSpeak = "Presta atención, debes encontrar los objeto más valiosos de quien te quieres convertir, " +
            "esa es la esencia misma del conjuro que realizaré.";
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
        textToSpeak = "Quieres que le robe ¡¿Estás loco?";
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

        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "No puedo hacerlo, soy muy joven para ir a la cárcel o peor, que lo descubra y me golpeé o que- ";
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


        charName.GetComponent<TMPro.TMP_Text>().text = "Chululu";
        textToSpeak = "El tiempo se agota, sólo queda un minuto o serás mi cena.";
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
        textToSpeak = "Con esa última advertencia, desapareció.";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        chululu.SetActive(false);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 7;

    }

    public IEnumerator EventSeven()
    {
        //Event 1
        nextButton.SetActive(false);
        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "¡ESPERA!... Ay, ya se fue... a ver, pensemos...";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 8;

    }

    public IEnumerator EventEight()
    {
        //Event 1
        nextButton.SetActive(false);
        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "Christian, él creo que esta en el equipo deportivo...¿Estuvo en atletismo o futbol? No sé, creo que le gusta el café... ¿tal vez?." +
            " Si, definitivamente voy a morir";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 9;
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

        if (eventPos == 8)
        {
            StartCoroutine(EventEight());
        }

        if (eventPos == 9)
        {
            SceneManager.LoadSceneAsync("juego");
        }

      
    }
}
