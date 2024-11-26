using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private EnemyFSM _enemyFSM;

    private void Start()
    {
        _enemyFSM = GetComponent<EnemyFSM>();
        _enemyFSM.SwitchState(new IdleState());
    }
}
