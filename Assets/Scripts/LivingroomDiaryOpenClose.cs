using Unity.VisualScripting;
using UnityEngine;

public class LivingroomDiaryOpenClose : MonoBehaviour
{
    //Opens and Closes the diary in livingroom
    public GameObject diaryPanel;   // QuestBook

    private bool isOpen = false;

    public void ToggleDiary()
    {
        isOpen = !isOpen;
        diaryPanel.SetActive(isOpen);
    }
}
