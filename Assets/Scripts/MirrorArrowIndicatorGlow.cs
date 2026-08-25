using UnityEngine;
using UnityEngine.UI;

public class MirrorArrowIndicatorGlow : MonoBehaviour
{
    public Outline outline;
    public float speed = 2f;

    void Update()
    {
        float glow = Mathf.PingPong(Time.time * speed, 1f);
        outline.effectColor = new Color(1f, 1f, 0f, glow); // yellow glow
    }
}
