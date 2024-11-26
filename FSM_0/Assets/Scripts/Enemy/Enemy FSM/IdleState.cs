using UnityEngine;

public class IdleState : State
{
    public override void EnterState(EnemyFSM enemy)
    {
        Debug.Log("Entered Idle State");
    }

    public override void UpdateState(EnemyFSM enemy)
    {
        // Check if the player is nearby to switch to ChaseState
        if (Vector3.Distance(enemy.transform.position, Player.Instance.transform.position) < 10f)
        {
            enemy.SwitchState(new ChaseState());
        }
    }

    public override void ExitState(EnemyFSM enemy)
    {
        Debug.Log("Exiting Idle State");
    }
}
