using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called once per frame, after all Update calls
    void LateUpdate()
    {
        // Actualiza la posición de la cámara para que siga al jugador con un offset
        transform.position = player.transform.position + offset;
    }
}