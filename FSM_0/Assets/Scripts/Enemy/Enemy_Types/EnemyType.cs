[System.Serializable]
public class EnemyType
{
    public string typeName;
    public float chaseDuration; // Time (in seconds) to chase before going idle
    public float chaseRange;    // Distance at which the enemy will start chasing
    public float attackRange;   // Distance at which the enemy will attack the player
}