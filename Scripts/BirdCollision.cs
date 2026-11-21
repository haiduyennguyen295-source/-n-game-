using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (AudioManager.instance != null)
            {
                AudioManager.instance.PlayHit();
                AudioManager.instance.PlayDie();
            }

            if (GameOverController.instance != null)
            {
                GameOverController.instance.TriggerGameOver(rb);
            }
        }
    }
}