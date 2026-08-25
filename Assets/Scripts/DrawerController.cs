using UnityEngine;

public class DrawerController : MonoBehaviour
{
    //drawer object in the scene will open when the player clicks in that area

    public GameObject drawerPanel;

    public void OpenDrawer()
    {
        drawerPanel.SetActive(true);
    }

    public void CloseDrawer()
    {
        drawerPanel.SetActive(false);
    }
}
