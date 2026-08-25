using UnityEngine;

public class LivingRoomDiaryTabs : MonoBehaviour
{
    public GameObject inventoryPage;
    public GameObject cluesPage;
    public GameObject tasksPage;

    public void ShowInventory()
    {
        inventoryPage.SetActive(true);
        cluesPage.SetActive(false);
        tasksPage.SetActive(false);
    }

    public void ShowClues()
    {
        inventoryPage.SetActive(false);
        cluesPage.SetActive(true);
        tasksPage.SetActive(false);
    }

    public void ShowTasks()
    {
        inventoryPage.SetActive(false);
        cluesPage.SetActive(false);
        tasksPage.SetActive(true);
    }
}
