using UnityEngine;

public class AdvanceButton : MonoBehaviour
{

    Game game;
    [SerializeField] private AudioClip click01;
    [SerializeField] private AudioClip click02;
    [SerializeField][Range(0, 1)] float clickSoundVolume;
    GameObject eventsScript;
    Upgrades upgrades;

    private void Start()
    {
        game = Game.Instance;
        upgrades = FindObjectOfType<Upgrades>();
    }


    public void Advance()
    {
        if (game.myState == Game.States.GameStart)
        {
            eventsScript.GetComponent<Events>().GenerateEvent();
            game.myState = Game.States.Question;
            AudioSource.PlayClipAtPoint(click01, Camera.main.transform.position, clickSoundVolume);
        }

        else if (game.myState == Game.States.EffectState)
        {
            AudioSource.PlayClipAtPoint(click02, Camera.main.transform.position, clickSoundVolume);
            game.hour += Random.Range(1, 4); //random 1-3 hours
            if (game.hour < 20)
            {
                eventsScript.GetComponent<Events>().GenerateEvent();
                game.myState = Game.States.Question;

            }
            else
            {
                game.myState = Game.States.Night;
            }
        }

        else if (game.myState == Game.States.Night)
        {
            AudioSource.PlayClipAtPoint(click01, Camera.main.transform.position, clickSoundVolume);
            game.nightCanvas.SetActive(false);
            game.lifeTotal++;
            game.dayNumber++;
            game.hour = 8;
            upgrades.action01Activated = false;
            upgrades.action02Activated = false;
            upgrades.action03Activated = false;
            
            if ((game.dayNumber == 11) && (ResourcesManager.materialsTotal < 30) && (ResourcesManager.moneyTotal < 30))
            {
                game.myState = Game.States.Death;
            }
            else
            {
                game.myState = Game.States.GameStart;
            }
        }
    }
}
