using UnityEngine;

public class ColorSquare : MonoBehaviour
{
    public string correctTag; // Set this in the Inspector to the tag of the correct color zone

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the square entered a zone with the correct tag
        if (other.CompareTag(correctTag))
        {
            Debug.Log($"{name} placed in the correct zone!");

            // Destroy the square
            Destroy(gameObject);
        }
    }
}




