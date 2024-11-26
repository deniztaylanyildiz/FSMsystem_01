using UnityEngine;

public class ChaseState : State
{
  [SerializeField]  private float chaseTime = 0f; // Timer to track how long the enemy has been chasing
    private float maxChaseDuration = 5f; // Max time allowed to chase the player

    public override void EnterState(EnemyFSM enemy)
    {
        Debug.Log("Entered Chase State");
        chaseTime = 0f; // Reset the timer when entering the chase state
    }

    public override void UpdateState(EnemyFSM enemy)
    {
        // Update the timer
        chaseTime += Time.deltaTime;

        // Move toward the player
        Vector3 direction = (Player.Instance.transform.position - enemy.transform.position).normalized;
        enemy.transform.position += direction * 3f * Time.deltaTime;

        // Check if the enemy is close enough to attack
        if (Vector3.Distance(enemy.transform.position, Player.Instance.transform.position) < 2f)
        {
            enemy.SwitchState(new AttackState());
        }
        else if (chaseTime >= maxChaseDuration) // If the enemy chased for too long
        {
            enemy.SwitchState(new IdleState()); // Switch back to IdleState
        }
    }

    public override void ExitState(EnemyFSM enemy)
    {
        Debug.Log("Exiting Chase State");
    }
}