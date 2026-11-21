using UnityEngine;

public class StartGameController : MonoBehaviour
{
    public static StartGameController instance;

    public GameObject startMessageGroup;
    public Rigidbody2D birdRb;
    public float defaultGravity = 2f;
    public float initialJumpForce = 0f;
    public MonoBehaviour pipeSpawner;

    public bool hasStarted { get; private set; }

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        hasStarted = false;

        if (startMessageGroup != null)
            startMessageGroup.SetActive(true);

        if (birdRb != null)
        {
            birdRb.gravityScale = 0f;
            birdRb.linearVelocity = Vector2.zero;
        }

        if (pipeSpawner != null)
            pipeSpawner.enabled = false;
    }

    public void StartGameByHandButton()
    {
        if (hasStarted) return;
        hasStarted = true;

        if (startMessageGroup != null)
            startMessageGroup.SetActive(false);

        if (birdRb != null)
        {
            birdRb.gravityScale = defaultGravity;
            birdRb.linearVelocity = initialJumpForce > 0f ? Vector2.up * initialJumpForce : Vector2.zero;
        }

        if (pipeSpawner != null)
            pipeSpawner.enabled = true;
    }
}