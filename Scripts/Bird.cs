using UnityEngine;
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    public float jumpForce = 6f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (StartGameController.instance != null && !StartGameController.instance.hasStarted)
            return;

        if (GameOverController.instance != null && GameOverController.instance.isGameOver)
            return;

        bool spacePressed = Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame;
        bool mousePressed = Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame;

        if (spacePressed || mousePressed)
        {
            if (rb != null)
            {
                rb.linearVelocity = Vector2.up * jumpForce;
            }

            if (AudioManager.instance != null)
            {
                AudioManager.instance.PlayWing();
            }
        }
    }
}