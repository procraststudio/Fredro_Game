using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Events : MonoBehaviour
{
    public static List<string> events = new List<string>() { "PAN GELDHAB", "MOJA �ONA ZOFIA", "PAN JOWIALSKI", "DUCH NAPOLEONA", "DYREKTOR TEATRU", "NIEMOWLAK GIGANT", "DAMY I HUZARY", "PAPKIN" };
    public static List<string> randomEvents = new List<string>() { "NIEMOWLAK GIGANT", "DAMY I HUZARY", "PAPKIN" };
    public static int currentHero;
    [SerializeField][Range(0, 1)] float clickSoundVolume;
    private bool option1;
    private bool option2;
    [SerializeField] TextMeshProUGUI startText;
    [SerializeField] TextMeshProUGUI option1Text;
    [SerializeField] TextMeshProUGUI option2Text;


    public void GenerateEvent()
    {
        string eventText;
        int index = Random.Range(0, events.Count);
        eventText = events[index];
        Debug.Log("Event is " + eventText);

        switch (eventText)
        {
            case "PAN GELDHAB":
                currentHero = 0;
                startText.GetComponent<TextMeshProUGUI>().text = "Witam Ja�nie Pana. Nie uwierzy Hrabia, co mnie dzi� spotka�o...";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Zamieniam si� w s�uch." + "\n" + "70%  +3  <sprite=1> " + "\n" + "30%  -1  <sprite=0>, -1  <sprite=2>";//"Yes, go on.";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Przyjd� jutro. Dzi� pracuj�." + "\n" + "70% +1  <sprite=0>" + "\n" + "30%  +1  <sprite=1> ";

                return;
            case "MOJA �ONA ZOFIA":
                currentHero = 1;
                startText.GetComponent<TextMeshProUGUI>().text = "Wypij t� polewk�, m�j drogi. Powinna ci� wzmocni�";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Dziwnie wygl�da... �ykam" + "\n" + "70%  +1  <sprite=2> " + "\n" + "30%  -2  <sprite=2>";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Si�gnij tam do skarbczyka" + "\n" + "70%  +3  <sprite=0> " + "\n" + "30%  -2  <sprite=0>";
                return;
            case "PAN JOWIALSKI":
                currentHero = 2;
                startText.GetComponent<TextMeshProUGUI>().text = "Jam Jowialski, ha! A oto dowcip na sto dwa...";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Pos�ucham wa�ci." + "\n" + "70%  -2  <sprite=1> -1  <sprite=2>" + "\n" + "30%  +5  <sprite=1>";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Mam pilne zadania." + "\n" + "70%  -1  <sprite=0> -1  <sprite=2>" + "\n" + "30%  +1  <sprite=1>  -1 <sprite=2>";
                return;
            case "DUCH NAPOLEONA":
                currentHero = 3;
                startText.GetComponent<TextMeshProUGUI>().text = "Hu hu...hrabio. Pami�tasz jak razem na Moskw� szli�my?";
                option1Text.GetComponent<TextMeshProUGUI>().text = "A jak�e, to by�y czasy" + "\n" + "70%  +1  <sprite=1>" + "\n" + "30%  -1  <sprite=0> -1  <sprite=2> ";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Zgi�, przepadnij!" + "\n" + "70%  +1  <sprite=2>" + "\n" + "30%  -2  <sprite=2>";
                return;
            case "DYREKTOR TEATRU":
                currentHero = 4;
                startText.GetComponent<TextMeshProUGUI>().text = "Hrabio, nasz teatr got�w do premiery";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Oto nowa komedia. Co my�licie?" + "\n" + "70%  +2  <sprite=1>" + "\n" + "30%  -2  <sprite=1> ";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Musz� jeszcze popracowa�." + "\n" + "70%  +2  <sprite=0>" + "\n" + "30%  +4  <sprite=0> ";
                return;
            case "NIEMOWLAK GIGANT":
                currentHero = 5;
                startText.GetComponent<TextMeshProUGUI>().text = "AGUGUAGUGU. A GU-GU!";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Matko jedyna, atakuje!" + "\n" + "50%  -3  <sprite=2>" + "\n" + "50%  -1  <sprite=1> ";
                option2Text.GetComponent<TextMeshProUGUI>().text = "A gdzie jego rodzice?" + "\n" + "50%  -1  <sprite=2>" + "\n" + "50%  -3  <sprite=1> ";
                return;

            case "DAMY I HUZARY":
                currentHero = 6;
                startText.GetComponent<TextMeshProUGUI>().text = "Ta�czy�, balowa�, wina nie �a�owa�!";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Ca�a noc przed nami!" + "\n" + "50%  +1  <sprite=1>" + "\n" + "50%  -1  <sprite=0> ";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Praca nie zaj�c..." + "\n" + "50%  +3  <sprite=0>";
                return;

            case "PAPKIN":
                currentHero = 7;
                startText.GetComponent<TextMeshProUGUI>().text = "Papkin jest we wiosce! Zachodz� w twe progi.";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Opowiadaj co w �wiecie" + "\n" + "50%  +1  <sprite=1>" + "\n" + "50%  +3  <sprite=0> ";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Zofia! Wina nalej." + "\n" + "50%  +3  <sprite=1>" + "\n" + "50%  +1  <sprite=0> ";
                return;
        }

    }

}
