using UnityEngine;
using UnityEngine.InputSystem;

public class diaryInputXboxController : MonoBehaviour
{
    private DiaryController diaryController;

    void Start()
    {
        // Automatically find the DiaryController in the current scene
        diaryController = FindObjectOfType<DiaryController>();
    }

    public void OnOpenDiaryPopup(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && diaryController != null)
            diaryController.ShowPopup();
    }

    public void OnCloseDiaryPopup(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && diaryController != null)
            diaryController.ClosePopup();
    }

    public void OnOpenDiary(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && diaryController != null)
            diaryController.OpenDiary();
    }

    public void OnCloseDiary(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && diaryController != null)
            diaryController.CloseDiary();
    }
}
