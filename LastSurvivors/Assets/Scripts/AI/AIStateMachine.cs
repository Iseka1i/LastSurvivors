using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public class AIStateMachine : MonoBehaviour
    {
        public enum State
        {
            idleState,
            roamingState,
            walkingState,
            attackingState,
            deathState,
        }

        public State currentState;

        public void SwitchState(State currentState, State newState)
        {
            currentState = newState;
        }
    }
}



