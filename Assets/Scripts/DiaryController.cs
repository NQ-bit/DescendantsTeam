using UnityEngine;

public class DiaryController : MonoBehaviour
{
    public GameObject diaryPopupPanel;     // hotspot popup
    public GameObject diaryCornerIcon;     // small icon in corner
    public GameObject diaryPanel;          // full diary

    void Start()
    {
        diaryPopupPanel.SetActive(false);
        diaryCornerIcon.SetActive(false);
        diaryPanel.SetActive(false);
    }

    // Called when player clicks the hotspot (diary on table)
    public void ShowPopup()
    {
        diaryPopupPanel.SetActive(true);
    }

    // Called when player closes the popup
    public void ClosePopup()
    {
        diaryPopupPanel.SetActive(false);
        diaryCornerIcon.SetActive(true);
    }

    public void OpenDiaryFromPopup()
    {
        diaryPopupPanel.SetActive(false);   // hide popup
        diaryPanel.SetActive(true);         // open diary
        diaryCornerIcon.SetActive(true);    // show corner icon for later use
    }

    // Called when player clicks the corner icon
    public void OpenDiary()
    {
        diaryPanel.SetActive(true);
    }

    public void CloseDiary()
    {
        diaryPanel.SetActive(false);
    }
}
