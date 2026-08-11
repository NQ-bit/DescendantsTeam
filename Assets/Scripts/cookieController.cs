using UnityEngine;
using UnityEngine.UI;

public class cookieController : MonoBehaviour
{
    public Image jarImage;
    public AudioSource audioSource;     
    public AudioClip exitSound;

    public void Show(Sprite sprite)
    {
        jarImage.sprite = sprite;
        gameObject.SetActive(true);
    }

    public void Close()
    {
        audioSource.PlayOneShot(exitSound);
        gameObject.SetActive(false);
    }
}
