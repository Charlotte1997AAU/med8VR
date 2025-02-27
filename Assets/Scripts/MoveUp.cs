using UnityEngine;

public class MoveUpWithSound : MonoBehaviour
{
    public float endPointY = 10f; // Adjust this value in the inspector
    public float moveSpeed = 1f; // Adjust this value in the inspector
    public AudioClip moveSound; // Sound to play while moving

    private bool isMoving = true;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null && moveSound != null)
        {
            audioSource.clip = moveSound;
            audioSource.loop = true; // Loop the sound while moving
            audioSource.Play();
        }
    }

    void Update()
    {
        if (isMoving)
        {
            // Move the object upwards
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

            // Check if the object reached the endpoint
            if (transform.position.y >= endPointY)
            {
                isMoving = false;
                if (audioSource != null)
                {
                    audioSource.Stop();
                }
            }
        }
    }
}
