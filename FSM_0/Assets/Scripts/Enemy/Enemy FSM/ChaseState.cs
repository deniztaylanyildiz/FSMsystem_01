using UnityEngine;

public class ChaseState : State
{
    public override void EnterState(EnemyFSM enemy)
    {
        Debug.Log("Entered Chase State");
    }

    public override void UpdateState(EnemyFSM enemy)
    {
        // Move toward the player
        Vector3 direction = (Player.Instance.transform.position - enemy.transform.position).normalized;
        enemy.transform.position += direction * 3f * Time.deltaTime;

        // Switch to AttackState if close to the player
        if (Vector3.Distance(enemy.transform.position, Player.Instance.transform.position) < 2f)
        {
            enemy.SwitchState(new AttackState());
        }
    }

    public override void ExitState(EnemyFSM enemy)
    {
        Debug.Log("Exiting Chase State");
    }
}
