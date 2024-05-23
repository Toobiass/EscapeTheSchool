using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        // Bewegung basierend auf den Eingaben
        float moveX = Input.GetAxis("Horizontal"); // A, D
        float moveZ = Input.GetAxis("Vertical");   // W, S

        // Berechne die Bewegungsrichtung
        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        // Bewege den Spieler
        transform.Translate(move * speed * Time.deltaTime, Space.World);
    }
}
