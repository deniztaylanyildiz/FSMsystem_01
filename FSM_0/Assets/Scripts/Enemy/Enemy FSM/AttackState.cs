using UnityEngine;

public class AttackState : State
{
    public override void EnterState(EnemyFSM enemy)
    {
        Debug.Log("Entered Attack State");
    }

    public override void UpdateState(EnemyFSM enemy)
    {
        // Attack logic
        Debug.Log("Attacking Player");

        // Switch back to ChaseState if the player moves away
        if (Vector3.Distance(enemy.transform.position, Player.Instance.transform.position) > 2f)
        {
            enemy.SwitchState(new ChaseState());
        }
    }

    public override void ExitState(EnemyFSM enemy)
    {
        Debug.Log("Exiting Attack State");
    }
}
