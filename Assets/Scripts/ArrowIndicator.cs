using UnityEngine;

public class ArrowIndicator : MonoBehaviour
{
    public GameObject arrowUI;
    public GameObject clickableArea;

    public void ShowArrow()
    {
        arrowUI.SetActive(true);
        clickableArea.SetActive(true);
    }

    public void HideArrow()
    {
        arrowUI.SetActive(false);
        clickableArea.SetActive(false);
    }
}
