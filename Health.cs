using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int numOfHearts;

    public Image[] hearts;

    public Sprite fullHeart;
    public Sprite emptyHeart;

    Game game;

    private void Start()
    {
        game = Game.Instance;
    }

    private void Update()
    {
        health = game.GetLife();

        if (health > numOfHearts)
        {
            health = numOfHearts;

        }
        
        
        
        for (int i = 0; i < hearts.Length; i++)
        {
           if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
           else
            {
                hearts[i].sprite = emptyHeart;
            }
                
            if (i<numOfHearts)
            {
                hearts[i].enabled = true;
            }
           else
            {
                hearts[i].enabled = false;
            }
        }
       
    }




}
