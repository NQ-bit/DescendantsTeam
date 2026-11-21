using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskItem : MonoBehaviour
{
    public bool isCompleted = false;

    public TextMeshProUGUI taskText;
  //  public GameObject strikeout;
    public GameObject checkmark;

    public void MarkCompleted()
    {
        isCompleted = true;

       /* if (checkmark != null)
            checkmark.SetActive(true); */

      /*  if (strikeout != null)
            strikeout.SetActive(true); */

        if (taskText != null)
            taskText.color = new Color(1f, 0.85f, 0.3f);

        // Play sound
        FindFirstObjectByType<TaskManager>().GetComponent<AudioSource>().Play();

    }
}
