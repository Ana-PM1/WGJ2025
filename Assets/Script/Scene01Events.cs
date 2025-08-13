using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject BGCuarto;
    public GameObject BGChululuInvocacion;
    public GameObject charMCDark;
    public GameObject charMC;
    public GameObject chululu;
    public GameObject textBoxUI;


    public GameObject BGM;
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
        StartCoroutine(EventOne());
    }

    /*public IEnumerator EventStarter()
    {
        //Event 0
        fadeScreenIn.SetActive(false);
        // charMC.SetActive(true);
        textBoxUI.SetActive(true);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "";
        textToSpeak = "Es una noche tranquila." +
            "Los vecinos que tienen m�s energ�a por las ma�anas en este momento roncan en sus casas," +
            "otros, j�venes en su mayor�a parece que est�n de fiesta cantando alguna canci�n popular de estos d�as." +
            " Las letras de romance son tan delicadas que hasta provocan sue�os agradables a los que duermen.";
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
        eventPos = 50;

    }*/

    
    public IEnumerator EventOne()
    {
        //Event 0
        
        textToSpeak = "";
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        BGCuarto.SetActive(true);
        yield return new WaitForSeconds(.02f);
      
        charMCDark.SetActive(true);
        yield return new WaitForSeconds(2);
        textBoxUI.SetActive(true);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "�C�llense!";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);yield return new WaitForSeconds(1);
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
        textToSpeak = "Se escucho gritar de la ventana de la segunda planta de la casa. " +
            "All� no estaba alguien roncando, cantando, ni teniendo sue�os agradables. " +
            "Estaba Juanito, el hormonal y nada bien parecido, seg�n sus propios pensamientos, Juanito Chafa.";
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
        charMCDark.SetActive(false);
        charMC.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "Nunca podr� salir con ella� Miranda que es perfecta";
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
       
        charName.GetComponent<TMPro.TMP_Text>().text = "";
        textToSpeak = "As� lo dec�a con la fuerza de todas sus hormonas, no le preguntes por el apellido de Miranda. ";
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
        
        
        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "Y yo que sigo utilizando los cubrebocas fuera de casa, aunque ya no se necesitan";
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


        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "Ah, pero no fuera el se�or ment�n de alto valor, d�a a d�a lo veo cambiando de mujeres, " +
            "una vez estaba de dos brazos con unas compa�eras ��Lo odio!!� ";
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
        charName.GetComponent<TMPro.TMP_Text>().text = " ";
        textToSpeak = "Estaba por enviar otro audio a su amigo con quien hab�a estado charlando en " +
            "InstaCheve cuando desplaz�ndose encontr� un anuncio de lo m�s extra�o. �Invocaciones a domicilio�, " +
            "algo sobre la soluci�n a diversos problemas, las alergias, el c�ncer, amarres y problemas de apariencia. ";
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
        charName.GetComponent<TMPro.TMP_Text>().text = " ";
        textToSpeak = "Apret� tan r�pido que el celular termin� rebotado en la cama";
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

    public IEnumerator EventNine()
    {
        //Event 1
        nextButton.SetActive(false);
        BGCuarto.SetActive(false);
        BGChululuInvocacion.SetActive(true);
        BGM.SetActive(false);
        BGMChululu.SetActive(true);
        yield return new WaitForSeconds(1);
        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "�Qu� carajos...?";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 10;
    }

    public IEnumerator EventTen()
    {
        //Event 1
        nextButton.SetActive(false);
        chululu.SetActive(true);
        yield return new WaitForSeconds(1);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chululu";
        textToSpeak = "�Lenguaje!�";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 11;
    }

    public IEnumerator EventEleven()
    {
        //Event 1
        nextButton.SetActive(false);
        chululu.SetActive(true);
        yield return new WaitForSeconds(1);
        charName.GetComponent<TMPro.TMP_Text>().text = "Juanito Chafa";
        textToSpeak = "�AAAAAAAAAAAAAAAAAAH!";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 12;
    }

    public IEnumerator EventTwelve()
    {
        //Event 1
        nextButton.SetActive(false);
        chululu.SetActive(true);
        yield return new WaitForSeconds(1);
        charName.GetComponent<TMPro.TMP_Text>().text = " ";
        textToSpeak = "Frente a �l estaba un animal sacado de la ficci�n, con piel oso que podr�a reconocer, " +
            "pero con las dem�s formas escap�ndosele de su comprensi�n. Tampoco es que Juanito fuera bueno en biolog�a.";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 13;
    }

    public IEnumerator EventThirteen()
    {
        //Event 1
        nextButton.SetActive(false);
        chululu.SetActive(true);
        yield return new WaitForSeconds(1);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chululu";
        textToSpeak = "Mhm, si ya terminaron, me gustar�a no hacer horas extra." +
            " Chamaco, s�, tu, el que parece chupado por la vida. Est�s desesperado por migajes, lo huelo a kil�metros. Vamos a empezar.";
        textBoxUI.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1); yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.02f);
        nextButton.SetActive(true);
        eventPos = 14;
    }



    public void NextButton() 
    {
        /*if (eventPos == 50)
        {
            StartCoroutine(Transicion1());
        }*/

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
            StartCoroutine(EventNine());
        }

        if (eventPos == 10)
        {
            StartCoroutine(EventTen());
        }

        if (eventPos == 11)
        {
            StartCoroutine(EventEleven());
        }

        if (eventPos == 12)
        {
            StartCoroutine(EventTwelve());
        }

        if (eventPos == 13)
        {
            StartCoroutine(EventThirteen());
        }

        if (eventPos == 14)
        {
            SceneManager.LoadSceneAsync("Scene02");
        }
    }


}
