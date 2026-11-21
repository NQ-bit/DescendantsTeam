using Unity.VisualScripting;
using UnityEngine;

public class LivingroomDiaryOpenClose : MonoBehaviour
{
    public GameObject diaryPanel;

    public InkNarrativeManager narrativeManager;
    public TextAsset diaryNarrative;

    private bool isOpen = false;

    public void ToggleDiary()
    {
        /* bool wasOpen = isOpen;

         isOpen = !isOpen;

         diaryPanel.SetActive(isOpen);

         if (wasOpen && !isOpen)
         {
             narrativeManager.PlayNarrative(diaryNarrative);
         } */

        bool wasOpen = isOpen;

        isOpen = !isOpen;

        diaryPanel.SetActive(isOpen);

        if (wasOpen && !isOpen)
        {
            Debug.Log("Setting pulse flag TRUE");

            narrativeManager.enableCalendarPulseOnClose = true;

            narrativeManager.PlayNarrative(diaryNarrative);
        }
    }

}
