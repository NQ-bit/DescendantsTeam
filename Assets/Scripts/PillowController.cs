using UnityEngine;
using System.Collections;

public class PillowController : MonoBehaviour
{
    public GameObject itemPopupPanel;
    public TMPro.TMP_Text popupText;

    public GameObject yesButton;
    public GameObject noButton;

    public AudioClip foundBatterySound;
    public AudioClip wrongPillowSound;

    public GameObject batteries; // the hidden object

    public GameObject pillowImageLeft;
    public GameObject pillowImageRight;


    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        itemPopupPanel.SetActive(false);
        batteries.SetActive(false);
    }

    public void ClickCorrectPillow()
    {
        audioSource.PlayOneShot(foundBatterySound);

        popupText.text = "You have found the batteries behind the pillow!";

        noButton.SetActive(false);

        // Hide pillow images when popup shows
        pillowImageLeft.SetActive(false);
        pillowImageRight.SetActive(false);

        itemPopupPanel.SetActive(true);

        StartCoroutine(WaitBeforeClosing(5f));
    }

    public void ClickWrongPillow()
    {
        audioSource.PlayOneShot(wrongPillowSound);
    }

    private IEnumerator WaitBeforeClosing(float delay)
    {
        yield return new WaitForSeconds(delay);

        itemPopupPanel.SetActive(false);

        batteries.SetActive(true); // reveal batteries

        noButton.SetActive(true);

        // Show pillow images again
        pillowImageLeft.SetActive(true);
        pillowImageRight.SetActive(true);
    }
}
