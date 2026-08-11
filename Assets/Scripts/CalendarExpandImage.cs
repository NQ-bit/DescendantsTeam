using UnityEngine;
using UnityEngine.UI; 

public class CalendarExpandImage : MonoBehaviour
{
    public Sprite imageToShow;
    public CalendarFullImage viewer;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        viewer.Show(imageToShow);
    }
}
