using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public static InventorySystem Instance;

    public string savedCode;

    private void Awake()
    {
        Instance = this;
    }

    public void AddCode(string code)
    {
        savedCode = code;
        Debug.Log("Code saved to inventory: " + savedCode);
    }
}
