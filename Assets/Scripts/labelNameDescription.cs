using UnityEngine;
using UnityEngine.UI;

public class labelNameDescription : MonoBehaviour
{
    [TextArea]
    public string description;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            LabelManager.Instance.ShowLabel(description);
        });
    }

}
