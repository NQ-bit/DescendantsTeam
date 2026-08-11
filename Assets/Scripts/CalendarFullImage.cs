using UnityEngine;
using UnityEngine.UI; 

public class CalendarFullImage : MonoBehaviour
{
    public Image fullImage;

    public void Show(Sprite sprite)
    {
        fullImage.sprite = sprite;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
