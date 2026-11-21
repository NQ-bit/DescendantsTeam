using Ink.Runtime;
using TMPro;
using UnityEngine;

public class InkNarrativeManager : MonoBehaviour
{
    public TextAsset inkJSON;
    public GameObject narrativePanel;
    public TMP_Text narrativeText;

    private Story story;

    public calendarGlow calendarPulse;

    public bool enableCalendarPulseOnClose = false;

    public void PlayNarrative(TextAsset inkFile)
    {
        story = new Story(inkFile.text);

        narrativePanel.SetActive(true);

        ContinueStory();
    }

    void Update()
    {
        if (!narrativePanel.activeSelf) return;

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            ContinueStory();
        }
    }

    void ContinueStory()
    {
        if (story.canContinue)
        {
            string line = story.Continue().Trim();
            narrativeText.text = line;
        }
        else
        {
            CloseNarrative();
        }
    }

    public void CloseNarrative()
    {
        /*narrativePanel.SetActive(false);

        if (enableCalendarPulseOnClose && calendarPulse != null)
        {
            calendarPulse.enabled = true;
        } */

        //enableCalendarPulseOnClose = false;
        // calendarPulse.enabled = true;

        Debug.Log("Narrative Finished");
        Debug.Log("enableCalendarPulseOnClose = " + enableCalendarPulseOnClose);
        Debug.Log("calendarPulse = " + calendarPulse);

        narrativePanel.SetActive(false);

        if (enableCalendarPulseOnClose && calendarPulse != null)
        {
            Debug.Log("TURNING CALENDAR PULSE ON");

            calendarPulse.enabled = true;
        }

        enableCalendarPulseOnClose = false;
    }
}
