using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Cards/Minion")]
    public class MinionType : CardType
    {
        public override void OnSetType(CardViz viz)
        { 
            base.OnSetType(viz);

            viz.statsHolder.SetActive(true);
        }
    }
}
