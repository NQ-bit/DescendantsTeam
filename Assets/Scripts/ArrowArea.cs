using UnityEngine;
using UnityEngine.UI;

public class ArrowArea : MonoBehaviour
{
    public ArrowIndicator arrowIndicator;
    public GameObject diaryIcon;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnHotspotClicked);
    }

    void OnHotspotClicked()
    {
        arrowIndicator.HideArrow();   // hide the arrow
        diaryIcon.SetActive(true);    // show the diary icon
    }
}
