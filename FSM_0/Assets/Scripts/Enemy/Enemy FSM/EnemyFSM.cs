using UnityEngine;

public class EnemyFSM : MonoBehaviour
{
    public State CurrentState { get; private set; }

    public void SwitchState(State newState)
    {
        if (CurrentState != null)
        {
            CurrentState.ExitState(this);
        }

        CurrentState = newState;

        if (CurrentState != null)
        {
            CurrentState.EnterState(this);
        }
    }

    private void Update()
    {
        if (CurrentState != null)
        {
            CurrentState.UpdateState(this);
        }
    }
}
