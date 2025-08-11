using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject charMC;
    public GameObject textBoxUI;


    public GameObject BGM;
    public GameObject BGMChululu;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;

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
        //Event0
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        charMC.SetActive(true);
        yield return new WaitForSeconds(2);
        textBoxUI.SetActive(true);
        mainTextObject.SetActive(true);
        textToSpeak = "Lorem ipsum";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 1;
           
    }



    public IEnumerator EventOne()
    {
        nextButton.SetActive(false);
        yield return new WaitForSeconds(2);
        BGM.SetActive(false);

        BGMChululu.SetActive(true);
    }

    public void NextButton() 
    {
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }
    }
}
