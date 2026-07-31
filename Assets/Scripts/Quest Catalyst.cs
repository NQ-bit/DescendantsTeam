using UnityEngine;
using System.Collections.Generic;
using System.Collections; 

public class QuestCatalyst : MonoBehaviour
{
    [SerializeField] private string quest; 
    [SerializeField] private GameObject notification;
    private bool questAdded = false;

    public void Createquest()
    {
        if (quest != null && !questAdded)
        {
            questAdded = true;
            //questAdded = !questAdded;
            MainManager.mainManager.questNames.Add(quest);
        }

        if (notification != null)
        {
            notification.SetActive(true);
        }

        //if (notification != null && !questAdded)
        // {
        //   notification.SetActive(true);
        // }

    }

    public class Quest
    {
        public string name;
        public string description;

        public Quest(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }

    public void CompleteQuest()
    {
        if (quest != null && MainManager.mainManager.questNames.Contains(quest))
        {
            MainManager.mainManager.questNames.Remove(quest);
        }


        //if (quest != null && MainManager.mainManager.questNames.Contains(quest))
        // {
        //   MainManager.mainManager.questNames.Remove(quest);
        // }

    }

}
