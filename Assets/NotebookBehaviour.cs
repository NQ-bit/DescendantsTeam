using UnityEngine;
using TMPro;

public class NotebookBehaviour : MonoBehaviour
{
    public TextMeshProUGUI notebookText;
    public GameObject calendarPanel;
    public TextMeshProUGUI calendarText;

    public void OpenNotebook()
    {
        gameObject.SetActive(true);
        notebookText.text = "You found a notebook. It says: Find the calendar.";
    }

    public void OpenCalendar(string eventDate)
    {
        calendarPanel.SetActive(true);
        calendarText.text = "Event Date: " + eventDate;
    }
}
