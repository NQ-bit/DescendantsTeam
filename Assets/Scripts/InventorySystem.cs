using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public static InventorySystem Instance;

    public string savedCode;

    public Transform inventoryListParent;
    public GameObject inventoryItemPrefab;

    private void Awake()
    {
        Instance = this;
    }

    public void AddCode(string code)
    {
        savedCode = code;
        Debug.Log("Code saved to inventory: " + savedCode);
    }

    public void AddItem(string itemName)
    {
        GameObject newItem = Instantiate(inventoryItemPrefab, inventoryListParent);
        newItem.GetComponent<TMP_Text>().text = itemName;

        Debug.Log("Item added to inventory: " + itemName);
    }

}
