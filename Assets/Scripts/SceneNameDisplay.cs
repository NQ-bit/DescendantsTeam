using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SceneNameDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI locationText;
    [SerializeField] private float displayTime = 3f;

    [SerializeField] private DialogueManager dialogueManager;

    private void OnEnable()
    {
        // Script displays the words on the scene that says "living room"

        StopAllCoroutines();
        StartCoroutine(HideAfterDelay());
    }

    private IEnumerator HideAfterDelay()
    {
        yield return new WaitForSeconds(displayTime);
        gameObject.SetActive(false);
        gameObject.SetActive(false);
        dialogueManager.StartDialogue();
    }

}
