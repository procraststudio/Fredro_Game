using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Events : MonoBehaviour
{
    public static List<string> events = new List<string>() { "PAN GELDHAB", "MOJA ¯ONA ZOFIA", "PAN JOWIALSKI", "DUCH NAPOLEONA", "DYREKTOR TEATRU", "NIEMOWLAK GIGANT", "DAMY I HUZARY", "PAPKIN" };
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
                startText.GetComponent<TextMeshProUGUI>().text = "Witam Jaœnie Pana. Nie uwierzy Hrabia, co mnie dziœ spotka³o...";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Zamieniam siê w s³uch." + "\n" + "70%  +3  <sprite=1> " + "\n" + "30%  -1  <sprite=0>, -1  <sprite=2>";//"Yes, go on.";
                option2Text.GetComponent<TextMeshProUGUI>().text = "PrzyjdŸ jutro. Dziœ pracujê." + "\n" + "70% +1  <sprite=0>" + "\n" + "30%  +1  <sprite=1> ";

                return;
            case "MOJA ¯ONA ZOFIA":
                currentHero = 1;
                startText.GetComponent<TextMeshProUGUI>().text = "Wypij tê polewkê, mój drogi. Powinna ciê wzmocniæ";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Dziwnie wygl¹da... £ykam" + "\n" + "70%  +1  <sprite=2> " + "\n" + "30%  -2  <sprite=2>";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Siêgnij tam do skarbczyka" + "\n" + "70%  +3  <sprite=0> " + "\n" + "30%  -2  <sprite=0>";
                return;
            case "PAN JOWIALSKI":
                currentHero = 2;
                startText.GetComponent<TextMeshProUGUI>().text = "Jam Jowialski, ha! A oto dowcip na sto dwa...";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Pos³ucham waœci." + "\n" + "70%  -2  <sprite=1> -1  <sprite=2>" + "\n" + "30%  +5  <sprite=1>";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Mam pilne zadania." + "\n" + "70%  -1  <sprite=0> -1  <sprite=2>" + "\n" + "30%  +1  <sprite=1>  -1 <sprite=2>";
                return;
            case "DUCH NAPOLEONA":
                currentHero = 3;
                startText.GetComponent<TextMeshProUGUI>().text = "Hu hu...hrabio. Pamiêtasz jak razem na Moskwê szliœmy?";
                option1Text.GetComponent<TextMeshProUGUI>().text = "A jak¿e, to by³y czasy" + "\n" + "70%  +1  <sprite=1>" + "\n" + "30%  -1  <sprite=0> -1  <sprite=2> ";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Zgiñ, przepadnij!" + "\n" + "70%  +1  <sprite=2>" + "\n" + "30%  -2  <sprite=2>";
                return;
            case "DYREKTOR TEATRU":
                currentHero = 4;
                startText.GetComponent<TextMeshProUGUI>().text = "Hrabio, nasz teatr gotów do premiery";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Oto nowa komedia. Co myœlicie?" + "\n" + "70%  +2  <sprite=1>" + "\n" + "30%  -2  <sprite=1> ";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Muszê jeszcze popracowaæ." + "\n" + "70%  +2  <sprite=0>" + "\n" + "30%  +4  <sprite=0> ";
                return;
            case "NIEMOWLAK GIGANT":
                currentHero = 5;
                startText.GetComponent<TextMeshProUGUI>().text = "AGUGUAGUGU. A GU-GU!";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Matko jedyna, atakuje!" + "\n" + "50%  -3  <sprite=2>" + "\n" + "50%  -1  <sprite=1> ";
                option2Text.GetComponent<TextMeshProUGUI>().text = "A gdzie jego rodzice?" + "\n" + "50%  -1  <sprite=2>" + "\n" + "50%  -3  <sprite=1> ";
                return;

            case "DAMY I HUZARY":
                currentHero = 6;
                startText.GetComponent<TextMeshProUGUI>().text = "Tañczyæ, balowaæ, wina nie ¿a³owaæ!";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Ca³a noc przed nami!" + "\n" + "50%  +1  <sprite=1>" + "\n" + "50%  -1  <sprite=0> ";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Praca nie zaj¹c..." + "\n" + "50%  +3  <sprite=0>";
                return;

            case "PAPKIN":
                currentHero = 7;
                startText.GetComponent<TextMeshProUGUI>().text = "Papkin jest we wiosce! Zachodzê w twe progi.";
                option1Text.GetComponent<TextMeshProUGUI>().text = "Opowiadaj co w œwiecie" + "\n" + "50%  +1  <sprite=1>" + "\n" + "50%  +3  <sprite=0> ";
                option2Text.GetComponent<TextMeshProUGUI>().text = "Zofia! Wina nalej." + "\n" + "50%  +3  <sprite=1>" + "\n" + "50%  +1  <sprite=0> ";
                return;
        }

    }

}
