using UnityEngine;

public class ButtonSoundEffect : MonoBehaviour
{
    // Assign an AudioSource in the Inspector
    public AudioSource audioSource;

    // Method to play audio, call this when button is clicked
    public void PlayButtonSound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource not assigned!");
        }
    }
}
