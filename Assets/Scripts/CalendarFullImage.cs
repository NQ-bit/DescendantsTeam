using UnityEngine;
using UnityEngine.UI; 

public class CalendarFullImage : MonoBehaviour
{
    public Image fullImage;

    public GameObject mirrorStillImage;

    public InkNarrativeManager narrativeManager;
    public TextAsset mirrorNarrative;

    public void Show(Sprite sprite)
    {
        fullImage.sprite = sprite;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);

        if (mirrorStillImage != null)
        {
            mirrorStillImage.SetActive(true);
        }

        narrativeManager.showMirrorIndicatorOnClose = true;

        narrativeManager.PlayNarrative(mirrorNarrative);
    }
}
