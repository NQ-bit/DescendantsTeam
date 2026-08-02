using UnityEngine;

public class NotebookClickArea : MonoBehaviour
{
    public NotebookBehaviour notebook;
    public ArrowIndicator arrowIndicator;

    public void OnMouseDown()
    {
        notebook.OpenNotebook();
        arrowIndicator.HideArrow();
    }
}
