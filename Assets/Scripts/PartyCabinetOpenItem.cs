using UnityEngine;



public class PartyCabinetOpenItem : MonoBehaviour
{
    public GameObject partyItemPanel; // UI party cabinet panel that will open


    public void OpenCabinet()
    {
        partyItemPanel.SetActive(true);
    }

    public void CloseCabinet()
    {
        partyItemPanel.SetActive(false);
    }

   /* void OnMouseDown()
    {
        partyItemPanel.SetActive(true);
    } */
}
