using UnityEngine;

public class IdleBobbing : MonoBehaviour
{
    public float amplitude = 8f;
    public float frequency = 2.5f;

    private RectTransform rectTransform;
    private Vector2 startAnchoredPos;
    private bool isBobbing = true;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            startAnchoredPos = rectTransform.anchoredPosition;
        }
    }

    void Update()
    {
        if (!isBobbing || rectTransform == null) return;

        float offsetY = Mathf.Sin(Time.unscaledTime * frequency) * amplitude;
        rectTransform.anchoredPosition = startAnchoredPos + new Vector2(0f, offsetY);
    }

    public void StopBobbing()
    {
        isBobbing = false;
        if (rectTransform != null)
        {
            rectTransform.anchoredPosition = startAnchoredPos;
        }
    }
}