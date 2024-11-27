public interface IEnemyBehavior
{
    void PerformChase(EnemyFSM enemy);  // This method will define how the enemy chases the player
    void PerformAttack(EnemyFSM enemy); // This method will define how the enemy attacks the player
}   