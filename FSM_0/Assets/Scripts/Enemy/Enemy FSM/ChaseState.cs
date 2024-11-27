using UnityEngine;

public class ChaseState : State
{
    private float chaseTime = 0f;
    private EnemyFSM enemyFSM;

    public override void EnterState(EnemyFSM enemy)
    {
        enemyFSM = enemy;
        chaseTime = 0f; // Reset the timer when entering the chase state
        Debug.Log("Entered Chase State for " + enemyFSM.name);
    }

    public override void UpdateState(EnemyFSM enemy)
    {
        // Update the timer
        chaseTime += Time.deltaTime;

        // Perform chase and attack using the enemy's behavior
        if (enemyFSM is IEnemyBehavior enemyBehavior)
        {
            enemyBehavior.PerformChase(enemy);
        }

        // If the enemy chased for too long, switch to Idle
        if (chaseTime >= enemyFSM.enemyType.chaseDuration ||
            Vector3.Distance(enemy.transform.position, Player.Instance.transform.position) > enemyFSM.enemyType.chaseRange)
        {
            enemy.SwitchState(new IdleState());
        }
    }

    public override void ExitState(EnemyFSM enemy)
    {
        Debug.Log("Exiting Chase State for " + enemyFSM.name);
    }
}
