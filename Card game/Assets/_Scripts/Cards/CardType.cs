using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public abstract class CardType : ScriptableObject
    {
        public string typeName;

        public virtual void OnSetType(CardViz viz)
        {
            Element t = Settings.GetResourceManager().typeElement;
            CardVizProperties type = viz.GetProperty(t);
            type.text.text = typeName;
        }
    }

}
