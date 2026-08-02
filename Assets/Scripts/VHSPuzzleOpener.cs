using UnityEngine;

public class VHSPuzzleOpener : MonoBehaviour
{
    [SerializeField] private GameObject puzzlePrefab;

    public void OpenPuzzle()
    {
        //Debug.Log("OpenPuzzle was called!");
        // OpenPuzzle();
        // Canvas canvas = FindFirstObjectByType<Canvas>();
        //Instantiate(puzzlePrefab);

        Debug.Log("OpenPuzzle was called!");
        Transform parent = GameObject.Find("PuzzleLayer").transform;
        Instantiate(puzzlePrefab, parent);
    }

}
