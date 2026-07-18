using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingSpeed;

    public void LaunchBall()
    {
        bool isRight = Random.value > 0.5f;
        float x = isRight ? 1f : -1f;
        float y = Random.Range(-1f, 1f);

        rb.linearVelocity = new Vector2(x, y).normalized * startingSpeed;
    }

    public void ResetBall()
    {
        transform.position = Vector3.zero;
        rb.linearVelocity = Vector2.zero;
        LaunchBall();
    }

    private void Start()
    {
        LaunchBall();
    }
}