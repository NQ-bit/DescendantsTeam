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

    //Monster first appearance in Bedroom
    public GameObject monsterPanel;

    public GameObject monsterImage1;
    public GameObject monsterImage2;
    public GameObject monsterImage3;

    //Sounds for Monster Exit from Bedroom
    public AudioSource audioSource;

    public AudioClip monsterSound1;
    public AudioClip monsterSound2;
    public AudioClip monsterSound3;

    //Monster Dialogue for first appearance in Bedroom
    public TMP_Text monsterDialogueText;

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

    /*IEnumerator ShowMonsterSequence()
    {
        monsterPanel.SetActive(true);

        monsterImage1.SetActive(true);
        yield return new WaitForSeconds(1.5f);

        monsterImage1.SetActive(false);
        monsterImage2.SetActive(true);
        yield return new WaitForSeconds(1.5f);

        monsterImage2.SetActive(false);
        monsterImage3.SetActive(true);
        yield return new WaitForSeconds(2.5f);

        SceneManager.LoadScene(nextSceneName);
    } */


    IEnumerator ShowMonsterSequence()
    {
        Debug.Log("Monster Sequence Started");

        Debug.Log("Monster Sequence Started");
        Debug.Log("This object = " + gameObject.name);
        Debug.Log("Active = " + gameObject.activeInHierarchy);

        //gameObject.SetActive(false);

        monsterPanel.SetActive(true);

        Debug.Log("Showing Monster Image 1");
        monsterImage1.SetActive(true);
        audioSource.PlayOneShot(monsterSound1);
        monsterDialogueText.text = "You're really going to leave?";
        monsterImage2.SetActive(false);
        monsterImage3.SetActive(false);

        yield return new WaitForSeconds(5f);

        Debug.Log("Passed Wait 1");

        monsterImage1.SetActive(false);
        monsterImage2.SetActive(true);
        audioSource.PlayOneShot(monsterSound2);
        monsterDialogueText.text = "You know how this always ends.";

        Debug.Log("Showing Monster Image 2");

        yield return new WaitForSeconds(5f);

        Debug.Log("Passed Wait 2");

        monsterImage2.SetActive(false);
        monsterImage3.SetActive(true);
        audioSource.PlayOneShot(monsterSound3);
        monsterDialogueText.text = "Stay where it's safe.";

        Debug.Log("Showing Monster Image 3");

        yield return new WaitForSeconds(5f);

        Debug.Log("Loading Scene");

        SceneManager.LoadScene(nextSceneName);
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
           // SceneManager.LoadScene(nextSceneName);

            StartCoroutine(ShowMonsterSequence());
        }
    }
}
