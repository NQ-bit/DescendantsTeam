using TMPro;
using UnityEngine;

public class QuestLog : MonoBehaviour
{
    public Transform taskListParent;
    public GameObject taskPrefab;

    public void AddTask(string taskText)
    {
        GameObject newTask = Instantiate(taskPrefab, taskListParent);
        newTask.GetComponent<TMP_Text>().text = taskText;
    }
}
