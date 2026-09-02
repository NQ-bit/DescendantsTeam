using UnityEngine;

public class DiaryController : MonoBehaviour
{
    public GameObject diaryPopupPanel;     // hotspot popup
    public GameObject diaryCornerIcon;     // small icon in corner
    public GameObject Canvas;          // full diary

    void Start()
    {
        diaryPopupPanel.SetActive(false);
        diaryCornerIcon.SetActive(false);
        Canvas.SetActive(false);
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
        Canvas.SetActive(true);         // open diary
        diaryCornerIcon.SetActive(true);    // show corner icon for later use
    }

    // Called when player clicks the corner icon
    public void OpenDiary()
    {
        Canvas.SetActive(true);
    }

    public void CloseDiary()
    {
        Canvas.SetActive(false);
    }
}
