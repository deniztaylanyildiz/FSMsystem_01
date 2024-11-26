using UnityEngine;

public class Player : Canplay
{
    public static Player Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }



    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _moveVector;
    private void Update()
    {
        Move(_speed, _moveVector);
    }
}
