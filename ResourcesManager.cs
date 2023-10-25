using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourcesManager : MonoBehaviour
{
    public static ResourcesManager Instance { get; private set; }
    public static int materialsTotal;
    public static int moneyTotal;
    [SerializeField] private TextMeshProUGUI woodTotalText;
    [SerializeField] private TextMeshProUGUI stoneTotalText;
    [SerializeField] private TextMeshProUGUI moneyTotalText;
    [SerializeField] private TextMeshProUGUI materialsChange;
    [SerializeField] private TextMeshProUGUI moneyChange_text;

    Game game;
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
        game = Game.Instance;
        materialsTotal = 1;
        moneyTotal = 1;
    }

    // Update is called once per frame
    void Update()
    {
        woodTotalText.GetComponent<TextMeshProUGUI>().text = materialsTotal.ToString();
        moneyTotalText.GetComponent<TextMeshProUGUI>().text = moneyTotal.ToString();
        if (game.myState == Game.States.Question)
        {
            materialsChange.CrossFadeAlpha(1f, 0.1f, true);
            materialsChange.GetComponent<TextMeshProUGUI>().text = null;
            moneyChange_text.CrossFadeAlpha(1f, 0.1f, true);
            moneyChange_text.GetComponent<TextMeshProUGUI>().text = null;
        }

    }
    public void WoodChange(int woodChange)
    {
        materialsTotal += woodChange;
        if (woodChange > 0)
        {
            materialsChange.GetComponent<TextMeshProUGUI>().text = "+" + woodChange.ToString();
        }
        else
        {
            materialsChange.GetComponent<TextMeshProUGUI>().text = woodChange.ToString();
        }
        materialsChange.CrossFadeAlpha(0.0f, 2f, false);

        if (materialsTotal < 0)
        {
            materialsTotal = 0;
        }
        else if (materialsTotal > 30)
        {
            materialsTotal = 30;
        }

    }

    public void MoneyChange(int moneyChange)
    {
        moneyTotal += moneyChange;
        if (moneyChange > 0)
        {
            moneyChange_text.GetComponent<TextMeshProUGUI>().text = "+" + moneyChange.ToString();
        }
        else
        {
            moneyChange_text.GetComponent<TextMeshProUGUI>().text = moneyChange.ToString();
        }
        moneyChange_text.CrossFadeAlpha(0.0f, 2f, false);


        if (moneyTotal < 0)
        {
            moneyTotal = 0;
        }
        else if (moneyTotal > 30)
        {
            moneyTotal = 30;
        }

    }
    public int GetMaterials()
    {
        return materialsTotal;
    }

    public int GetMoney()
    {
        return moneyTotal;
    }
}

