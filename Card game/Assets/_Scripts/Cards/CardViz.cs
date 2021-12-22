using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SA
{
    public class CardViz : MonoBehaviour
    {
        public Text name;
        public Text description;
        public Text type;
        public Text mana;
        public Text attack;
        public Text health;
        public Text flavor;
        public Text artist;
        public Image art;
        public Image backArt;
        public Image frontArt;

        public Card card;
        
                private void Start()
                {
                    LoadCard(card);
                }
            
        
            public void LoadCard(Card c)
            {
                if (c == null)
            {
                return;
            }

                card = c;

                name.text = c.cardName;
                description.text = c.cardDescription;
                type.text = c.cardType;
                mana.text = c.mana;
                attack.text = c.attack;
                health.text = c.health;
                flavor.text = c.cardFlavor;
                artist.text = c.artist;
                art.sprite = c.art;
                backArt.sprite = c.cardBack;
                frontArt.sprite = c.cardFront;


        }
    }
}

