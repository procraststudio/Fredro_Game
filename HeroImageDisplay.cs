using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroImageDisplay : MonoBehaviour
{
    Game game;
    [SerializeField] public Sprite[] heroImages;
    public GameObject heroImage;
    public GameObject finalHeroImage;
    [SerializeField] TextMeshProUGUI eventHero;
    [SerializeField] TextMeshProUGUI finalEventHero;
    
    void Start()
    {
        game = Game.Instance;
    }

    void Update()
    {
        if (game.myState == Game.States.Question)
        {
            
            heroImage.GetComponent<Image>().sprite = heroImages[Events.currentHero];
            eventHero.GetComponent<TextMeshProUGUI>().text = Events.events[Events.currentHero] + ":";
        }

        else if (game.myState == Game.States.EffectState)
        {   
            finalHeroImage.GetComponent<Image>().sprite = heroImages[Events.currentHero];
            finalEventHero.GetComponent<TextMeshProUGUI>().text = Events.events[Events.currentHero] + ":";
        }
    }
}
