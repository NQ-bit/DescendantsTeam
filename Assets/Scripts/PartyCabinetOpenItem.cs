using UnityEngine;



public class PartyCabinetOpenItem : MonoBehaviour
{
    public GameObject partyItemPanel; // UI party cabinet panel that will open
    public CabinetInkController inkController;
    public DialogueManager mainDialogueManager;



    public void OpenCabinet()
    {
        partyItemPanel.SetActive(true);
        mainDialogueManager.enabled = false; 
        
        inkController.StartCabinetDialogue();
    }

    public void CloseCabinet()
    {
        partyItemPanel.SetActive(false);
        mainDialogueManager.enabled = true;
    }

   /* void OnMouseDown()
    {
        partyItemPanel.SetActive(true);
    } */
}
