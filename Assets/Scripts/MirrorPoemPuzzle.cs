using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MirrorPoemPuzzle : MonoBehaviour
{
    //Bedroom Poem Puzzle

    public TMP_Text blank1;
    public TMP_Text blank2;
    public TMP_Text blank3;
    public TMP_Text blank4;
    public TMP_Text blank5;
    public TMP_Text blank6;

    private TMP_Text selectedBlank;

    public GameObject completedPoemPanel;
    public Button submitButton;
    public GameObject dialogueAfterPuzzlePanel; //Dialogue after the puzzle


    public AudioSource audioSource;
    public AudioClip correctSound;
    public AudioClip wrongSound;


    // Correct answers in order
    private string[] correctWords = {
        "Absence",
        "Always",
        "I am",
        "I part",
        "I move",
        "Keep Things Whole"
    };

    public void SelectBlank(TMP_Text blank)
    {
        selectedBlank = blank;
    }

    public void ChooseWord(string word)
    {
        if (selectedBlank != null)
        {
            selectedBlank.text = word;
            CheckBlankCorrect(selectedBlank);
            CheckIfAllFilled();
        }
    }

    void CheckBlankCorrect(TMP_Text blank)
    {
        int index = GetBlankIndex(blank);

        if (index == -1)
            return;

        if (blank.text == correctWords[index])
        {
            blank.color = Color.green;   // correct
            audioSource.PlayOneShot(correctSound);
        }
        else
        {
            blank.color = Color.red;     // incorrect
            audioSource.PlayOneShot(wrongSound);
        }
    }

    int GetBlankIndex(TMP_Text blank)
    {
        if (blank == blank1) return 0;
        if (blank == blank2) return 1;
        if (blank == blank3) return 2;
        if (blank == blank4) return 3;
        if (blank == blank5) return 4;
        if (blank == blank6) return 5;
        return -1;
    }

    void CheckIfAllFilled()
    {
        bool allFilled =
            blank1.text != "" &&
            blank2.text != "" &&
            blank3.text != "" &&
            blank4.text != "" &&
            blank5.text != "" &&
            blank6.text != "";

        submitButton.gameObject.SetActive(allFilled);
    }

    public void SubmitPoem()
    {
        bool allCorrect =
        string.Equals(blank1.text, correctWords[0], System.StringComparison.OrdinalIgnoreCase) &&
        string.Equals(blank2.text, correctWords[1], System.StringComparison.OrdinalIgnoreCase) &&
        string.Equals(blank3.text, correctWords[2], System.StringComparison.OrdinalIgnoreCase) &&
        string.Equals(blank4.text, correctWords[3], System.StringComparison.OrdinalIgnoreCase) &&
        string.Equals(blank5.text, correctWords[4], System.StringComparison.OrdinalIgnoreCase) &&
        string.Equals(blank6.text, correctWords[5], System.StringComparison.OrdinalIgnoreCase);

        if (allCorrect)
        {
            completedPoemPanel.SetActive(true);

            // Show dialogue panel
            dialogueAfterPuzzlePanel.SetActive(true);
        }
        else
        {
            Debug.Log("Incorrect poem.");
        }
    }

    public void ExitPuzzle(GameObject puzzlePanel)
    {
        completedPoemPanel.SetActive(false);
        this.gameObject.SetActive(false);
    }

    public void ClosePuzzleOnly()
    {
        this.gameObject.SetActive(false);
        dialogueAfterPuzzlePanel.SetActive(true); //dialogue after puzzle
    }


}
