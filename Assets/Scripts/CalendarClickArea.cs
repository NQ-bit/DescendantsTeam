using UnityEngine;

public class CalendarClickArea : MonoBehaviour
{
    public NotebookBehaviour notebook;

    public string eventDate = "Date";

    public void OnMouseDown()
    {
        notebook.OpenCalendar(eventDate);
    }
}
