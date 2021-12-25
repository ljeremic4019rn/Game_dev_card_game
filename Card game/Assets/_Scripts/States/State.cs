using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA.GameStates
{
    [CreateAssetMenu(menuName = "State ")]
    public class State : ScriptableObject
    {
        public Action[] actions;

        public void Tick(float d)//using delta time
        {
            for(int i = 0; i< actions.Length; i++)
            {
                actions[i].Execute(d);
            }
        }
    }
}

