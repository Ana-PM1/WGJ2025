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
        textToSpeak = "Los vecinos que tienen más energía por las mañanas en este momento roncan en sus casas.";
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
        textToSpeak = "Otros, los jóvenes en su mayoría parece que están de fiesta cantando alguna canción popular de estos días." +
            " Las letras de romance son tan delicadas que hasta provocan sueños agradables a los que duermen.";
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
