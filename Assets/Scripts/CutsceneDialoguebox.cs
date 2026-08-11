using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class CutsceneDialoguebox : MonoBehaviour
{
    public TMP_Text dialogueText; // Reference to the UI Text
    public string[] dialogues; // Array of dialogue strings
    public string nextSceneName; // Scene to load after dialogue
    private int currentIndex = 0;
    public float typingSpeed = 0.05f; // Speed for typewriter effect

    void Start()
    {
        StartCoroutine(TypeDialogue());
    }

    void Update()
    {
        // Move to next dialogue when player presses space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dialogueText.text == dialogues[currentIndex])
            {
                NextDialogue();
            }
            else
            {
                // Skip typewriter effect
                StopAllCoroutines();
                dialogueText.text = dialogues[currentIndex];
            }
        }
    }

    IEnumerator TypeDialogue()
    {
        dialogueText.text = "";
        foreach (char letter in dialogues[currentIndex].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
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
            // All dialogues finished -> load next scene
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
