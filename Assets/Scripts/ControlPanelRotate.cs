using UnityEngine;

public class RotateButton : MonoBehaviour
{
    // Rotation speed in degrees per second
    public float rotationSpeed = 20f;
    public float targetAngle = 90f;

    // Audio clip to play
    public AudioClip audioClip;

    // Reference to the AudioSource component
    private AudioSource audioSource;
    void Start()
    {
        audioSource.Play(); // Play the audio clip
    }

    void Update()
    {

        
        if (transform.rotation.eulerAngles.y < targetAngle)
        {
            // Rotate the GameObject around its local y-axis at a constant speed
            transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);
        }
        // Rotate the GameObject around its local y-axis at a constant speed
        //transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);
        else
        {
            enabled = false;
        }

    }
}
