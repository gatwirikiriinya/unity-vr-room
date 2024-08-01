using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro; // Add TextMeshPro namespace

public class DoorOpen : MonoBehaviour
{
    public Animator animator;
    public Button openButton; // Reference to the regular Unity UI Button

    void Start()
    {
        // Add listener for the button click event
        openButton.onClick.AddListener(OpenDoor);
    }

    void OpenDoor()
    {
        animator.SetBool("character_nearby", true); // Trigger the door animation
    }
}
