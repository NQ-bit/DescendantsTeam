using TMPro;
using UnityEngine;

public class VHSTapesPuzzleManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI codeText;
    [SerializeField] private GameObject wrongImage;

    [Header("Correct Code")]
    [SerializeField] private string correctCode = "William@Here";

    public void ClickCorrectObject()
    {
        wrongImage.SetActive(false);
        codeText.text = "Code Found: " + correctCode;

        InventorySystem.Instance.AddCode(correctCode);
    }

    public void ClickWrongObject()
    {
        codeText.text = "";
        wrongImage.SetActive(true);
    }

    public void ClosePuzzle()
    {
        gameObject.SetActive(false);
    }
}
