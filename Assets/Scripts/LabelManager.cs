using UnityEngine;
using TMPro;
using System.Collections;

public class LabelManager : MonoBehaviour
{
    public static LabelManager Instance;

    [SerializeField] private GameObject labelPanel;
    [SerializeField] private TextMeshProUGUI labelText;
    [SerializeField] private float hideDelay = 3f;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowLabel(string text)
    {
        labelPanel.SetActive(true);
        labelText.text = text;

        StopAllCoroutines();
        StartCoroutine(HideAfterDelay());
    }

    private IEnumerator HideAfterDelay()
    {
        yield return new WaitForSeconds(hideDelay);
        labelPanel.SetActive(false);
    }
}
