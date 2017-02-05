using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum State
    {
        Start,
        PlayerTurn,
        EnemyTurn,
        Waiting,
        Victory,
        Defeat
    };

    private State _currentState;
	
    void Start()
    {
        _currentState = State.Start;
    }

    void Update()
    {
        switch(_currentState)
        {
            case State.Start:
                break;
            case State.PlayerTurn:
                break;
            case State.EnemyTurn:
                break;
            case State.Waiting:
                break;
            case State.Victory:
                break;
            case State.Defeat:
                break;
        }
    }
}
