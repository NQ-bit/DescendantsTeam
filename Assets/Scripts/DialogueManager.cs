using UnityEngine;
using TMPro;
using System.Collections;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text dialogueText;
    public string[] dialogues;
    private int currentIndex = 0;

    public float typingSpeed = 0.05f;

    public GameObject dialogueBox;          // optional: if you want to hide it
    public ArrowIndicator arrowIndicator;   // same as DialogueManager

    public AudioClip afterLine1Sound;   // sound to play after element 1
    private AudioSource audioSource;


    void Start()
    {
        dialogueBox.SetActive(true);
        StartCoroutine(TypeDialogue());

        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dialogueText.text == dialogues[currentIndex])
            {
                NextDialogue();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = dialogues[currentIndex];
            }
        }
    }

    IEnumerator TypeDialogue()
    {
        dialogueText.text = "";
        foreach (char letter in dialogues[currentIndex])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        // After typing finishes
        if (currentIndex == 1)  // Element 1
        {
            audioSource.PlayOneShot(afterLine1Sound);
            // Wait for the full audio clip to finish
            yield return new WaitForSeconds(afterLine1Sound.length);

            // Continue to the next dialogue line
            NextDialogue();
            yield break; // stop this coroutine
        }

    }

    void NextDialogue()
    {
        currentIndex++;

        if (currentIndex < dialogues.Length)
        {
            StartCoroutine(TypeDialogue());
        }
        else
        {
            // END OF DIALOGUE
            dialogueBox.SetActive(false);

            // Show arrow indicator like DialogueManager
            arrowIndicator.ShowArrow();
        }
    }
}
