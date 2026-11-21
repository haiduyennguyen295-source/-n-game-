using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.GetComponent<BirdCollision>() != null)
        {
            if (GameOverController.instance != null && GameOverController.instance.isGameOver)
                return;

            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.AddScore(1);
            }

            if (AudioManager.instance != null)
            {
                AudioManager.instance.PlayPoint();
            }
        }
    }
}