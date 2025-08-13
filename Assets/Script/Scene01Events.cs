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
            "Los vecinos que tienen más energía por las mañanas en este momento roncan en sus casas," +
            "otros, jóvenes en su mayoría parece que están de fiesta cantando alguna canción popular de estos días." +
            " Las letras de romance son tan delicadas que hasta provocan sueños agradables a los que duermen.";
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
        textToSpeak = "¡Cállense!";
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
            "Allí no estaba alguien roncando, cantando, ni teniendo sueños agradables. " +
            "Estaba Juanito, el hormonal y nada bien parecido, según sus propios pensamientos, Juanito Chafa.";
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
        textToSpeak = "Nunca podré salir con ella… Miranda que es perfecta";
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
        textToSpeak = "Así lo decía con la fuerza de todas sus hormonas, no le preguntes por el apellido de Miranda. ";
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
        textToSpeak = "Ah, pero no fuera el señor mentón de alto valor, día a día lo veo cambiando de mujeres, " +
            "una vez estaba de dos brazos con unas compañeras ¡¡Lo odio!!” ";
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
        textToSpeak = "Estaba por enviar otro audio a su amigo con quien había estado charlando en " +
            "InstaCheve cuando desplazándose encontró un anuncio de lo más extraño. “Invocaciones a domicilio”, " +
            "algo sobre la solución a diversos problemas, las alergias, el cáncer, amarres y problemas de apariencia. ";
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
        textToSpeak = "Apretó tan rápido que el celular terminó rebotado en la cama";
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
        textToSpeak = "¿Qué carajos...?";
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
        textToSpeak = "¡Lenguaje!”";
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
        textToSpeak = "¡AAAAAAAAAAAAAAAAAAH!";
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
        textToSpeak = "Frente a él estaba un animal sacado de la ficción, con piel oso que podría reconocer, " +
            "pero con las demás formas escapándosele de su comprensión. Tampoco es que Juanito fuera bueno en biología.";
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
        textToSpeak = "Mhm, si ya terminaron, me gustaría no hacer horas extra." +
            " Chamaco, sí, tu, el que parece chupado por la vida. Estás desesperado por migajes, lo huelo a kilómetros. Vamos a empezar.";
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
