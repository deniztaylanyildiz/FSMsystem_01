using UnityEngine;

public class RangeEnemy : EnemyFSM, IEnemyBehavior
{
    public float attackCooldown = 2f;
    private float attackTimer = 0f;

    public void PerformChase(EnemyFSM enemy)
    {
        Vector3 direction = (Player.Instance.transform.position - enemy.transform.position).normalized;
        enemy.transform.position += direction * 3f * Time.deltaTime;

        if (Vector3.Distance(enemy.transform.position, Player.Instance.transform.position) <= 10f)
        {
            PerformAttack(enemy);  // Perform ranged attack if close enough
        }
    }

    public void PerformAttack(EnemyFSM enemy)
    {
        if (attackTimer <= 0f)
        {
            // Ranged attack logic (e.g., shoot a projectile at the player)
            Debug.Log("RangeEnemy is shooting at the player!");

            attackTimer = attackCooldown;  // Reset the attack cooldown
        }
    }

    private void Update()
    {
        attackTimer -= Time.deltaTime;  // Countdown the attack cooldown
    }
}