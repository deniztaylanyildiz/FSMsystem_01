using UnityEngine;

public class EnemyFSM : MonoBehaviour
{
    public State CurrentState { get; private set; }
    public EnemyType enemyType; // Assign this in the Inspector

    private void Start()
    {
        // Set the initial state based on the type of enemy
        SwitchState(new IdleState());
    }

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