using UnityEngine;
using System.Collections;

public class DrawerSystemManager : MonoBehaviour
{
    public GameObject drawerPanel;
    public GameObject itemPopupPanel;

    public AudioClip foundItemSound;
    public AudioClip declineItemSound;
    public TMPro.TMP_Text PopupText;

    public GameObject yesButton;
    public GameObject noButton;

    public AudioClip drawerOpenSound;
    public AudioClip drawerCloseSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        drawerPanel.SetActive(false);
        itemPopupPanel.SetActive(false);
    }

    public void OpenDrawer()
    {
        audioSource.PlayOneShot(drawerOpenSound, 3.0f);
        drawerPanel.SetActive(true);
    }

    public void ShowItemPopup()
    {
        itemPopupPanel.SetActive(true);
    }

    public void KeepItem()
    {
        audioSource.PlayOneShot(foundItemSound);

        // Show the message
        PopupText.text = "Good job, you have found the remote, but now you need to find the batteries.";

        // Wait for the sound to finish, then close everything
        StartCoroutine(CloseAfterSound(foundItemSound.length));

        // inventory system here
        // InventorySystem.Instance.AddItem("ItemName");

        // Hide the NO button so the player cannot decline
        noButton.SetActive(false);

        // Time period the text will showup for 
        StartCoroutine(WaitBeforeClosing(100f));

        // CloseAll();
    }

    public void DeclineItem()
    {
        audioSource.PlayOneShot(declineItemSound);
        StartCoroutine(CloseAfterSound(declineItemSound.length));
        //CloseAll();
    }

    private IEnumerator CloseAfterSound(float delay)
    {
        yield return new WaitForSeconds(delay);

        audioSource.PlayOneShot(drawerCloseSound);

        itemPopupPanel.SetActive(false);
        drawerPanel.SetActive(false);

        noButton.SetActive(true);
    }

    private IEnumerator WaitBeforeClosing(float delay)
    {
        yield return new WaitForSeconds(delay);

        audioSource.PlayOneShot(drawerCloseSound);

        // After waiting, close everything
        itemPopupPanel.SetActive(false);
        drawerPanel.SetActive(false);

        // Re-enable NO button for next time
        noButton.SetActive(true);
    }

   /* private void CloseAll()
    {
        audioSource.PlayOneShot(drawerCloseSound);
        itemPopupPanel.SetActive(false);
        drawerPanel.SetActive(false);
    } */


    /* private void CloseAll()
     {
         itemPopupPanel.SetActive(false);
         drawerPanel.SetActive(false);
     } */
}
