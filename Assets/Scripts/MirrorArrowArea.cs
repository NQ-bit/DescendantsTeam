using UnityEngine;

public class MirrorArrowArea : MonoBehaviour
{
    public GameObject poemPuzzlePanel;

    private void OnMouseDown()
    {
        poemPuzzlePanel.SetActive(true);
    }
}
