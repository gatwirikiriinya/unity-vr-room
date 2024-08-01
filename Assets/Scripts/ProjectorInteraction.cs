using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ProjectorInteraction : MonoBehaviour
{
    public ParticleSystem projectorParticles;  // Reference to the projector's particle system
    public Light projectorLight;              // Reference to a light or other visual indicator

    private bool isProjectorOn = false;       // To track the projector's state

    private void Start()
    {
        // Ensure the projector particles and light are inactive at the start
        projectorParticles.gameObject.SetActive(false);
        projectorLight.enabled = false;
    }

    public void ToggleProjector()
    {
        if (isProjectorOn)
        {
            // Turn off the projector
            projectorParticles.gameObject.SetActive(false);
            projectorLight.enabled = false;
        }
        else
        {
            // Turn on the projector
            projectorParticles.gameObject.SetActive(true);
            projectorParticles.Play();
            projectorLight.enabled = true;
        }

        isProjectorOn = !isProjectorOn; // Toggle the projector's state
    }
}
