using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SA
{
    [CreateAssetMenu(menuName = "Card")]
    public class Card : ScriptableObject
    {
        /*
        public string cardName;
        public Sprite art;
        public Sprite cardBack;
        public Sprite cardFront;
        public string cardDescription;
        public string cardType;
        public string mana;
        public string attack;
        public string health;
        public string cardFlavor;
        public string artist;
        */
        public CardProperties[] properties;
    }
}

