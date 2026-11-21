using UnityEngine;

public class calendarGlow : MonoBehaviour
{
    //Make calendar attract attention

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        float scale = 1f + Mathf.Sin(Time.time * 4f) * 0.1f;
        transform.localScale = originalScale * scale;
    }

    void OnDisable()
    {
        transform.localScale = originalScale;
    }
}
