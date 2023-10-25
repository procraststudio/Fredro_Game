using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static Game Instance { get; private set; }

    public int lifeTotal;
    public int nervesTotal;
    public int dayNumber;
    public int hour;
    public int playerLevel;
    [SerializeField] TextMeshProUGUI lifeTotalText;
    [SerializeField] TextMeshProUGUI dayNumberText;
    [SerializeField] TextMeshProUGUI hourNumberText;
    public GameObject nightCanvas;
    public GameObject escapeCanvas;
    public GameObject startPanel;
    public GameObject finalPanel;
    public GameObject continueButton;
    public GameObject trueButton;
    public GameObject falseButton;
    public GameObject eventsCanvas;
    public bool option1;
    public bool option2;
    public bool escapeCanvasActivated = false;
    AudioSource myAudioSource;
    public Animator transition;

    [SerializeField] public Transform pfDamagePopup;
    public enum States
    { GameStart, Question, TrueState, FalseState, EffectState, Night, Dawn, Sickness, Death, Win };
    public States myState;
    public int levelModifier;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        myState = States.GameStart;
        lifeTotal = 8;
        dayNumber = 1;
        hour = 8;
        nightCanvas.SetActive(false);
        escapeCanvas.SetActive(false);
        escapeCanvasActivated = false;
        myAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        dayNumberText.GetComponent<TextMeshProUGUI>().text = dayNumber.ToString();
        hourNumberText.GetComponent<TextMeshProUGUI>().text = hour.ToString();
        StatesManager();
        CalculatePlayerLevel();

        if (lifeTotal > 10)
        {
            lifeTotal = 10;
        }
        else if (lifeTotal <= 0)
        {
            myState = States.Death;
        }
        CheckWin();
        Escape();
    }

    public void StatesManager()

    {
        if (myState == States.Question)
        {
            finalPanel.SetActive(false);
            startPanel.SetActive(true);
            trueButton.SetActive(true);
            falseButton.SetActive(true);
            continueButton.SetActive(false);
        }
        else if (myState == States.EffectState)
        {
            startPanel.SetActive(false);
            finalPanel.SetActive(true);
            continueButton.SetActive(true);
            trueButton.SetActive(false);
            falseButton.SetActive(false);
        }
        else if (myState == States.GameStart)
        {
            finalPanel.SetActive(false);
            startPanel.SetActive(false);
            nightCanvas.SetActive(false);
            finalPanel.SetActive(false);
            startPanel.SetActive(false);
            trueButton.SetActive(false);
            falseButton.SetActive(false);
            continueButton.SetActive(true);
        }

        else if (myState == States.Night)
        {
            nightCanvas.SetActive(true);
            finalPanel.SetActive(false);
            startPanel.SetActive(false);
            trueButton.SetActive(false);
            falseButton.SetActive(false);
            continueButton.SetActive(true);

        }
        else if (myState == States.Death)
        {
            SceneManager.LoadScene(2);

        }
        else if (myState == States.Win)
        {
            transition.SetTrigger("Start");
            SceneManager.LoadScene(3);
        }
    }

    public int GetLife()
    {
        return lifeTotal;
    }

    public int GetHour()
    {
        return hour;
    }


    public void CalculatePlayerLevel()
    {
        if ((ResourcesManager.materialsTotal + ResourcesManager.moneyTotal) < 20)
        {
            playerLevel = 1;
            levelModifier = -5;
        }
        else if (((ResourcesManager.materialsTotal + ResourcesManager.moneyTotal) >= 20) && ((ResourcesManager.materialsTotal + ResourcesManager.moneyTotal) < 40))
        {
            playerLevel = 2;
            levelModifier = 0;
        }
        else if ((ResourcesManager.materialsTotal + ResourcesManager.moneyTotal) >= 40)
        {
            playerLevel = 3;
            levelModifier = 5;
        }
    }

    public void CheckWin()
    {
        if ((ResourcesManager.materialsTotal == 30) && (ResourcesManager.moneyTotal == 30))
        {
            myState = States.Win;
        }
    }

    public void Escape()
    {
        if ((!escapeCanvasActivated) && (Input.GetButtonDown("Cancel")))
        {
            escapeCanvas.SetActive(true);
            escapeCanvasActivated = true;
        }

        else if ((escapeCanvasActivated) && (Input.GetButtonDown("Cancel")))
        {
            escapeCanvas.SetActive(false);
            escapeCanvasActivated = false;
        }
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ReturnToGame()
    {
        escapeCanvas.SetActive(false);
        escapeCanvasActivated = false;
    }

}
