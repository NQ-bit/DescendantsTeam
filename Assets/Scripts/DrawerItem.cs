using UnityEngine;

public class DrawerItem : MonoBehaviour
{
    public string itemName;

    public void ClickItem()
    {
        ItemPopupController.Instance.ShowPopup(itemName);
    }
}
