using UnityEngine;

public class PlayerControllerSingleton : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
