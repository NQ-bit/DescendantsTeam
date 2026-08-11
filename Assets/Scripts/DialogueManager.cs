using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public TextMeshProUGUI dialogueText;

    [TextArea]
    public string[] lines;

    private int index = 0;

    // ADD THIS
    public ArrowIndicator arrowIndicator;

    public QuestBookButtonBehaviour questBook;


    public void StartDialogue()
    {
        index = 0;
        dialogueBox.SetActive(true);
        dialogueText.text = lines[index];
    }

    void Update()
    {
        if (dialogueBox.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            NextLine();
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = lines[index];
        }
        else
        {
            dialogueBox.SetActive(false);

            // SHOW ARROW AFTER LAST DIALOGUE LINE
            arrowIndicator.ShowArrow();
        }

       // if (!PlayerPrefs.HasKey("DiaryOpened"))
        //{
        //   questBook.OpenDiaryFirstTime();
       // }
    }
}
