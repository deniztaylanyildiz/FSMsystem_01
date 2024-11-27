using UnityEngine;

public class MeleeEnemy : EnemyFSM, IEnemyBehavior
{
    public float attackRange = 2f;

    public void PerformChase(EnemyFSM enemy)
    {
        Vector3 direction = (Player.Instance.transform.position - enemy.transform.position).normalized;
        enemy.transform.position += direction * 2f * Time.deltaTime;

        if (Vector3.Distance(enemy.transform.position, Player.Instance.transform.position) <= attackRange)
        {
            PerformAttack(enemy);  // Attack if within melee range
        }
    }

    public void PerformAttack(EnemyFSM enemy)
    {
        Debug.Log("MeleeEnemy is attacking the player!");
        // Melee attack logic here
    }
}
