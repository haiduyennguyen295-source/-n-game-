using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2.5f;
    private float timer = 0f;

    public float minY = -2f;
    public float maxY = 2f;

    void Update()
    {
        // Nếu chưa bấm nút bắt đầu game thì chưa sinh ống
        if (StartGameController.instance != null && !StartGameController.instance.hasStarted)
        {
            return;
        }

        // Nếu đã thua game thì ngừng sinh ống
        if (GameOverController.instance != null && GameOverController.instance.isGameOver)
        {
            return;
        }

        // Khi game đang chơi thì đếm thời gian sinh ống
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        if (pipePrefab == null) return;

        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0f);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}