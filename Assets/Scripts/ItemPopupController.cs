using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemPopupController : MonoBehaviour
{
    public static ItemPopupController Instance;

    public GameObject popupPanel;
    public TMP_Text popupText;
    public InventorySystem inventory;

    private string currentItemName;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowPopup(string itemName)
    {
        currentItemName = itemName;
        popupText.text = "Do you want to keep the " + itemName + "?";
        popupPanel.SetActive(true);
    }

    public void YesKeepItem()
    {
        inventory.AddItem(currentItemName);
        popupPanel.SetActive(false);
    }

    public void NoKeepItem()
    {
        popupPanel.SetActive(false);
    }
}
