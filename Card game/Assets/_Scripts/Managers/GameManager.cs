using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using SA.GameStates;

public class GameManager : MonoBehaviour
{
    public State currentState;
    

    private void FixedUpdate()
    {
        currentState.Tick(Time.deltaTime);
    }
}
