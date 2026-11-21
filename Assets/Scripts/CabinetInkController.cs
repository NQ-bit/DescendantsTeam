using UnityEngine;
using Ink.Runtime;
using TMPro;

public class CabinetInkController : MonoBehaviour
{
    public TextAsset inkJSONAsset;      // cabinet.json
    public TMP_Text dialogueText;       // Text inside DialoguePartyCabinetItemPanel
    public GameObject dialoguePanel;    // DialoguePartyCabinetItemPanel
    public GameObject choicesParent;    // parent object holding CD/Manga/Plushie buttons
    public TMP_Text[] choiceTexts;      // TMP text on each button

    private Story story;

    public void StartCabinetDialogue()
    {
        story = new Story(inkJSONAsset.text);
        story.ChoosePathString("cabinet");

        dialoguePanel.SetActive(true);
        RefreshView();
    }

    void RefreshView()
    {
        if (story.canContinue)
        {
            dialogueText.text = story.Continue().Trim();
        }

        var choices = story.currentChoices;

        for (int i = 0; i < choiceTexts.Length; i++)
        {
            if (i < choices.Count)
            {
                choiceTexts[i].transform.parent.gameObject.SetActive(true);
                choiceTexts[i].text = choices[i].text;
            }
            else
            {
                choiceTexts[i].transform.parent.gameObject.SetActive(false);
            }
        }
    }

    public void OnChoiceButton(int index)
    {
        story.ChooseChoiceIndex(index);
        RefreshView();
    }
}
