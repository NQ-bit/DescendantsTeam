using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public TaskItem checkCalendarTask;
    public TaskItem dailyAffirmationTask;
    public TaskItem findCarKeysTask;
    public TaskItem checkShelfTask;

    public void CompleteTask(string taskName)
    {
        switch (taskName)
        {
            case "CheckCalendar":
                checkCalendarTask.MarkCompleted();
                break;

            case "DailyAffirmation":
                dailyAffirmationTask.MarkCompleted();
                break;

            case "FindCarKeys":
                findCarKeysTask.MarkCompleted();
                break;

            case "CheckShelf":
                checkShelfTask.MarkCompleted();
                break;
        }
    }
}
