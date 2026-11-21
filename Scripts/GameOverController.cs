using UnityEngine;

public class GameOverController : MonoBehaviour
{
    public static GameOverController instance;

    public GameObject gameOverUI;
    public MonoBehaviour pipeSpawner;

    public bool isGameOver { get; private set; }

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        isGameOver = false;

        if (gameOverUI != null)
            gameOverUI.SetActive(false);
    }

    public void TriggerGameOver(Rigidbody2D birdRb)
    {
        if (isGameOver) return;
        isGameOver = true;

        if (gameOverUI != null)
            gameOverUI.SetActive(true);

        if (pipeSpawner != null)
            pipeSpawner.enabled = false;

        if (birdRb != null)
        {
            birdRb.linearVelocity = Vector2.zero;
        }
    }
}