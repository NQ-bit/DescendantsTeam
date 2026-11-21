using UnityEngine;

public class playerLookingInMirror : MonoBehaviour
{
    public float displayTime = 3f;

    private void OnEnable()
    {
        Invoke(nameof(HideImage), displayTime);
    }

    void HideImage()
    {
        gameObject.SetActive(false);
    }
}
