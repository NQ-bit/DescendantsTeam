using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class cabinetPartyItemChoice : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TMP_Text dialogueText;
    public DialogueManager mainDialogueManager; // reference to the other dialogue I want to disable


    public void ChooseCD()
    {
        StartCoroutine(CDDialogue());
    }

    public void ChooseManga()
    {
        StartCoroutine(MangaDialogue());
    }

    public void ChoosePlushie()
    {
        StartCoroutine(PlushieDialogue());
    }

    IEnumerator CDDialogue()
    {
        mainDialogueManager.enabled = false;   // STOP overwriting

        gameObject.SetActive(false);
        dialoguePanel.SetActive(true);

        dialogueText.text = "I guess I’ll choose this one.";
        yield return new WaitForSeconds(2f);

        dialogueText.text = "Who even listens to that kind of music? Pop music is popular.";
        yield return new WaitForSeconds(3f);

        dialogueText.text = "Well, what matters is that I like the music.";
        yield return new WaitForSeconds(2f);

        EndDialogue();

        mainDialogueManager.enabled = true;    // TURN IT BACK ON
    }

    IEnumerator MangaDialogue()
    {
        gameObject.SetActive(false);
        dialoguePanel.SetActive(true);

        dialogueText.text = "I guess I’ll choose this one.";
        yield return new WaitForSeconds(2f);

        dialogueText.text = "Why would you bring that? It’s so nerdy...";
        yield return new WaitForSeconds(3f);

        dialogueText.text = "I guess I’ll choose this one.";
        yield return new WaitForSeconds(2f);

        EndDialogue();
    }

    IEnumerator PlushieDialogue()
    {
        gameObject.SetActive(false);
        dialoguePanel.SetActive(true);

        dialogueText.text = "I guess I’ll choose this one.";
        yield return new WaitForSeconds(2f);

        dialogueText.text = "They're going to laugh. You’re too old to like plushies.";
        yield return new WaitForSeconds(3f);

        dialogueText.text = "I think it’s a cool item to show and comforting.";
        yield return new WaitForSeconds(2f);

        EndDialogue();
    }

    void EndDialogue()
    {
        dialogueText.text = "This is the one I’ll choose. It’s time to leave.";
    }
}
