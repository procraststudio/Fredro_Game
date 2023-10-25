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
                    finalText.GetComponent<TextMeshProUGUI>().text = "Wspania³a historia. Musisz to opisaæ";
                    resources.WoodChange(+3);
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "G³owa go rozbola³a od moich bajek, ale dukata da³";
                    resources.MoneyChange(-1); game.lifeTotal--;
                }

                return;
            case 1: //"MOJA ¯ONA ZOFIA",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Pyszne, nieprawda¿? Taka ¿ona to skarb";
                    game.lifeTotal++;
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Oooj... Przesadzi³am z zio³ami...";
                    game.lifeTotal -= 2;
                }

                return;
            case 2: //"PAN JOWIALSKI",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Dowcip mój ciê¿kawy nieco";
                    resources.WoodChange(-2); game.lifeTotal--;
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Wspania³e! Siadaj wnet do pisania";
                    resources.WoodChange(5);
                }

                return;

            case 3: // "SOBOWTÓR NAPOLEONA",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Opisz to w pamiêtniku TRZY PO TRZY";
                    resources.WoodChange(1);
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Pamiêæ Fredry ju¿ nie ta...";
                    resources.MoneyChange(-1); game.lifeTotal--;
                }

                return;
            case 4: //"DYREKTOR TEATRU",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Wspania³e! Mistrzu!";
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
                    finalText.GetComponent<TextMeshProUGUI>().text = "Niemowlê przygniot³o hrabiego";
                    game.lifeTotal -= 3;
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Niemowlê spad³o na dworek";
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
                    finalText.GetComponent<TextMeshProUGUI>().text = "Da³ dukata i nie zabi³";
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
                    finalText.GetComponent<TextMeshProUGUI>().text = "Jak sobie Waszmoœæ ¿yczy.";
                    resources.MoneyChange(1);
                }

                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Do nó¿ek padam.";
                    resources.WoodChange(1);
                }
                return;
            case 1: //"MOJA ¯ONA ZOFIA",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Widzisz, jaka jestem zaradna";
                    resources.MoneyChange(3);
                }

                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Jak to siê rozesz³o, no jak?";
                    resources.MoneyChange(-2);
                }
                return;
            case 2: //"PAN JOWIALSKI",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Nerwowo dziœ. Wezmê dukata i umykam";
                    resources.MoneyChange(-1); game.lifeTotal--;
                }

                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Nie nalegam";
                    resources.WoodChange(1); game.lifeTotal--;
                }
                return;
            case 3: //SOBOWTÓR NAPOLEONA",
                if (d100 <= 70)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Coraz wiêcej oszukanych metod¹ na Napoleona";
                    game.lifeTotal++;
                }

                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "A! Kto tu wpuœci³ ducha? Mdlejê...";
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
                    finalText.GetComponent<TextMeshProUGUI>().text = "Poczekamy i dukatów nie chowamy";
                    resources.MoneyChange(4);
                }
                return;
            case 5: //NIEMOWLAK GIGANT",
                if (d100 <= 50)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Osesek poturbowa³ hrabiego";
                    game.lifeTotal--;
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Niemowlak zniszczy³ pracowniê";
                    resources.WoodChange(-3);
                }
                return;
            case 6: //DAMY I HUZARY",
                if (d100 <= 50)
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Proszê, oto hojna zaliczka";
                    resources.MoneyChange(3);
                }
                else
                {
                    finalText.GetComponent<TextMeshProUGUI>().text = "Za du¿o tego wina by³o...";
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
                    finalText.GetComponent<TextMeshProUGUI>().text = "I mnie rzuci³a dla m³odszego, ale po³owa maj¹tku moja";
                    resources.MoneyChange(1);
                }
                return;

        }

    }
}
