using UnityEngine;

public abstract class Canplay : MonoBehaviour, ICanPlayable
{


    public void Move(float speed, Vector2 move)
    {

        Vector2 Movevectorx = new Vector2(Input.GetAxis("Horizontal"), 0);
        Vector2 Movevectory = new Vector2(0, Input.GetAxis("Vertical"));
        move = new Vector2(Movevectorx.x, Movevectory.y);
        move = move.normalized;
        transform.Translate(move * speed * Time.deltaTime);





    }
}
