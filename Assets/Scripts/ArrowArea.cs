using UnityEngine;
using UnityEngine.UI;

public class ArrowArea : MonoBehaviour
{
    public ArrowIndicator arrowIndicator;
    public DiaryController diaryPanel;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnHotspotClicked);
    }

    void OnHotspotClicked()
    {
        arrowIndicator.HideArrow();   // hide the arrow
        Debug.Log("Open Diary");
        diaryPanel.OpenDiaryFromPopup();    // show the diary icon
        Debug.Log("Diary is Open");
        
       
    }
}
