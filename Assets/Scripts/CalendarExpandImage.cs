using UnityEngine;
using UnityEngine.UI; 

public class CalendarExpandImage : MonoBehaviour
{
    public Sprite imageToShow;
    public CalendarFullImage viewer;
    public TaskManager taskManager;

    public calendarGlow pulseEffect;

    public InkNarrativeManager narrativeManager;
    public TextAsset calendarNarrative;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        //viewer.Show(imageToShow);

        Debug.Log("Calendar clicked");

        Debug.Log("viewer = " + viewer);
        Debug.Log("narrativeManager = " + narrativeManager);
        Debug.Log("calendarNarrative = " + calendarNarrative);
        Debug.Log("taskManager = " + taskManager);

        if (pulseEffect != null)
            pulseEffect.enabled = false;

        viewer.Show(imageToShow);

        narrativeManager.PlayNarrative(calendarNarrative);

        // Mark the calendar task as completed
        taskManager.CompleteTask("CheckCalendar");
    }
}
