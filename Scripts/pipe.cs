using UnityEngine;

public class pipe : MonoBehaviour
{
    public float moveSpeed = 5f; // Tốc độ di chuyển của ống cống
    public float destroyX = -15f; // Tọa độ X để tự xóa ống khi đi hết màn hình

    void Update()
    {
        // Cho ống cống di chuyển sang bên trái theo thời gian
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Tự động xóa ống cống khi nó trôi ra khỏi màn hình bên trái (tránh nặng game)
        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}