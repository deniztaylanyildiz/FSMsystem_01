using UnityEngine;

public abstract class State
{
    public abstract void EnterState(EnemyFSM enemy);
    public abstract void UpdateState(EnemyFSM enemy);
    public abstract void ExitState(EnemyFSM enemy);
}