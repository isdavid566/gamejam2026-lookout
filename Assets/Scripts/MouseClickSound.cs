using UnityEngine;
using UnityEngine.InputSystem;

public class MouseClickSound : MonoBehaviour
{
    public AudioClip clickSound;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            AudioSource.PlayClipAtPoint(
                clickSound,
                Camera.main.transform.position
            );
        }
    }
}