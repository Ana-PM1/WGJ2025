using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject textBoxUI;
     

    public GameObject BGM;

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
        charName.GetComponent<TMPro.TMP_Text>().text = "";
        textToSpeak = "Es una noche tranquila.";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        // fadeScreenOut.SetActive(true);
        eventPos = 1;
    }

    

    public IEnumerator EventOne()
    {
        //Event 1
        nextButton.SetActive(false);

        //chululu.SetActive(true) ;
        charName.GetComponent<TMPro.TMP_Text>().text = "";
        textToSpeak = "Los vecinos que tienen m�s energ�a por las ma�anas en este momento roncan en sus casas.";
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
        charName.GetComponent<TMPro.TMP_Text>().text = "";
        textToSpeak = "Otros, los j�venes en su mayor�a parece que est�n de fiesta cantando alguna canci�n popular de estos d�as." +
            " Las letras de romance son tan delicadas que hasta provocan sue�os agradables a los que duermen.";
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



    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
            Debug.Log("Cambio de escena");
        }

        if (eventPos == 2)
        {
            StartCoroutine(EventTwo());
            Debug.Log("Cambio de escena");
        }

        if (eventPos == 3)
        {
            fadeScreenOut.SetActive(true);
            SceneManager.LoadSceneAsync("Scene01");
        }
    }
}
