using UnityEngine;

public class DiaryTabs : MonoBehaviour
{
    public GameObject notesPage;
    public GameObject cluesPage;
    public GameObject tasksPage;

    public void ShowNotes()
    {
        notesPage.SetActive(true);
        cluesPage.SetActive(false);
        tasksPage.SetActive(false);
    }

    public void ShowClues()
    {
        notesPage.SetActive(false);
        cluesPage.SetActive(true);
        tasksPage.SetActive(false);
    }

    public void ShowTasks()
    {
        notesPage.SetActive(false);
        cluesPage.SetActive(false);
        tasksPage.SetActive(true);
    }
}
