using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerInput input;

    Rigidbody rigidBody;

    public float MoveSpeed => Mathf.Abs(rigidBody.velocity.x);

    void Awake()
    {
        input = GetComponent<PlayerInput>();
        rigidBody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        input.EnableGameplayInputs();
    }

    public void Move(float speed)
    {
        if (input.Move)
        {
            transform.localScale = new Vector3(input.AxisX, 1f, 1f);
        }

        SetVelocityX(speed * input.AxisX);
    }

    public void SetVelocity(Vector3 velocity)
    {
        rigidBody.velocity = velocity;
    }

    public void SetVelocityX(float velocityX)
    {
        rigidBody.velocity = new Vector3(velocityX, rigidBody.velocity.y);
    }

    public void SetVelocityY(float velocityY)
    {
        rigidBody.velocity = new Vector3(rigidBody.velocity.x, velocityY);
    }
}