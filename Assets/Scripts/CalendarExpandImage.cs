using UnityEngine;
using UnityEngine.UI; 

public class CalendarExpandImage : MonoBehaviour
{
    public Sprite imageToShow;
    public CalendarFullImage viewer;
    public TaskManager taskManager;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        viewer.Show(imageToShow);

        // Mark the calendar task as completed
        taskManager.CompleteTask("CheckCalendar");
    }
}
