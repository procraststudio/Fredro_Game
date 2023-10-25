using TMPro;
using UnityEngine;

public class AnswerChoices : MonoBehaviour
{
    Game game;
    ResourcesManager resources;
    public int d100;
    [SerializeField] TextMeshProUGUI finalText;
    [SerializeField] AudioClip click01;
    [SerializeField] AudioClip click02;
    [SerializeField][Range(0, 1)] float clickSoundVolume;


    void Start()
    {
        game = Game.Instance;
        resources = ResourcesManager.Instance;

    }

    public void ChoiceOption1()
    {

        d100 = Random.Range(1, 101) + game.levelModifier;
        Debug.Log("Number was " + d100);
        AudioSource.PlayClipAtPoint(click01, Camera.main.transform.position, clickSoundVolume);
        game.myState = Game.States.EffectState;
        switch (Events.currentHero)
        {
            case 0: //PAN GELDHAB
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Wspania�a historia. Musisz to opisa�";
                    resources.WoodChange(+3);
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "G�owa go rozbola�a od moich bajek, ale dukata da�";
                    resources.MoneyChange(-1); game.lifeTotal--;
                }

                return;
            case 1: //"MOJA �ONA ZOFIA",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Pyszne, nieprawda�? Taka �ona to skarb";
                    game.lifeTotal++;
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Oooj... Przesadzi�am z zio�ami...";
                    game.lifeTotal -= 2;
                }

                return;
            case 2: //"PAN JOWIALSKI",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Dowcip m�j ci�kawy nieco";
                    resources.WoodChange(-2); game.lifeTotal--;
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Wspania�e! Siadaj wnet do pisania";
                    resources.WoodChange(5);
                }

                return;

            case 3: // "SOBOWT�R NAPOLEONA",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Opisz to w pami�tniku TRZY PO TRZY";
                    resources.WoodChange(1);
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Pami�� Fredry ju� nie ta...";
                    resources.MoneyChange(-1); game.lifeTotal--;
                }

                return;
            case 4: //"DYREKTOR TEATRU",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Wspania�e! Mistrzu!";
                    resources.WoodChange(2);
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "No ten, tego... na mnie czas";
                    resources.WoodChange(-2);
                }

                return;
            case 5: //"NIEMOWLAK GIGANT",
                if (d100 <= 50)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Niemowl� przygniot�o hrabiego";
                    game.lifeTotal -= 3;
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Niemowl� spad�o na dworek";
                    resources.WoodChange(-1);
                }

                return;

            case 6: //DAMY I HUZARY",
                if (d100 <= 50)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Niesamowite historie, prawda?";
                    resources.WoodChange(1);
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Da� dukata i nie zabi�";
                    resources.MoneyChange(-1);
                }

                return;

            case 7: // "PAPKIN"
                if (d100 <= 50)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Wykorzystasz to w wierszu";
                    resources.WoodChange(1);
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Masz tu, Hrabio, grosiwo od Papkina";
                    resources.MoneyChange(3);
                }

                return;

        }

    }

    public void ChoiceOption2()
    {
        d100 = Random.Range(1, 101) + game.levelModifier;
        Debug.Log("Number was " + d100);
        game.myState = Game.States.EffectState;
        AudioSource.PlayClipAtPoint(click02, Camera.main.transform.position, clickSoundVolume);
        switch (Events.currentHero)
        {
            case 0: //"PAN GELDHAB"
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Jak sobie Waszmo�� �yczy.";
                    resources.MoneyChange(1);
                }

                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Do n�ek padam.";
                    resources.WoodChange(1);
                }
                return;
            case 1: //"MOJA �ONA ZOFIA",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Widzisz, jaka jestem zaradna";
                    resources.MoneyChange(3);
                }

                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Jak to si� rozesz�o, no jak?";
                    resources.MoneyChange(-2);
                }
                return;
            case 2: //"PAN JOWIALSKI",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Nerwowo dzi�. Wezm� dukata i umykam";
                    resources.MoneyChange(-1); game.lifeTotal--;
                }

                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Nie nalegam";
                    resources.WoodChange(1); game.lifeTotal--;
                }
                return;
            case 3: //SOBOWT�R NAPOLEONA",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Coraz wi�cej oszukanych metod� na Napoleona";
                    game.lifeTotal++;
                }

                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "A! Kto tu wpu�ci� ducha? Mdlej�...";
                    game.lifeTotal -= 2;
                }
                return;
            case 4: //DYREKTOR TEATRU",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Dobrze. Oto zaliczka";
                        resources.MoneyChange(2);
                }

                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Poczekamy i dukat�w nie chowamy";
                    resources.MoneyChange(4);
                }
                return;
            case 5: //NIEMOWLAK GIGANT",
                if (d100 <= 50)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Osesek poturbowa� hrabiego";
                    game.lifeTotal--;
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Niemowlak zniszczy� pracowni�";
                    resources.WoodChange(-3);
                }
                return;
            case 6: //DAMY I HUZARY",
                if (d100 <= 50)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Prosz�, oto hojna zaliczka";
                    resources.MoneyChange(3);
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Za du�o tego wina by�o...";
                    //MoneyChange(-1);
                }
                return;
            case 7: // "PAPKIN"
                if (d100 <= 50)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "I ja go wtedy CIACH! Notuj";
                    resources.WoodChange(3);
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "I mnie rzuci�a dla m�odszego, ale po�owa maj�tku moja";
                    resources.MoneyChange(1);
                }
                return;

        }

    }
}
