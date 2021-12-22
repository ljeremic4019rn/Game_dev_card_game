using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SA
{
    public class CardViz : MonoBehaviour
    {

        public Card card;
        public CardVizProperties[] properties;
        public GameObject statsHolder;


        private void Start()
        {
            

            LoadCard(card);
        }

        public void LoadCard(Card c)
        {
            if (c == null)
                return;            

            card = c;
            c.cardType.OnSetType(this);

            
            for (int i = 0; i < properties.Length; i++)
            {
                Debug.Log(i);
                CardProperties cp = c.properties[i];
                CardVizProperties p = GetProperty(cp.element);
                if (p == null)
                    continue;

                
                

                if (cp.element is ElementInt)
                {
                   // p.text.text = cp.intValue.ToString(); //todo ovo ne radi pogledaj zasto ne
                    p.text.text = cp.stringValue;
                    
                }
                else if (cp.element is ElementText)
                {
                    p.text.text = cp.stringValue;
                }
                else if (cp.element is ElementImage)
                {
                    p.img.sprite = cp.sprite;
                }
            }


        }

        public CardVizProperties GetProperty(Element e)
        {
            CardVizProperties result = null;

            for(int i = 0; i < properties.Length; i++)
            {
                if (properties[i].element == e)
                {
                    result = properties[i];
                    break;
                }
            }
            return result;
        }
    }
}

