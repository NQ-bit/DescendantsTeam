using UnityEngine;
using UnityEngine.UI;

public class cabinetArea : MonoBehaviour
{
    public cookieController objectViewer;
    public Sprite jarSprite;
    public AudioSource audioSource;    
    public AudioClip cabinetSound;

    void Start()
    {
        // Get the Button component and add a listener
        GetComponent<Button>().onClick.AddListener(OnCabinetClicked);
    }

    void OnCabinetClicked()
    {
        audioSource.PlayOneShot(cabinetSound);
        objectViewer.Show(jarSprite);
    }
}
