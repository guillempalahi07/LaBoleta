using UnityEngine;

public class Respawn : MonoBehaviour
{
    Vector3 posicioInicial;
    bool guardada = false;

    void Start()
    {
        GameObject jugador = GameObject.FindGameObjectWithTag("Player");
        if (jugador != null)
        {
            posicioInicial = jugador.transform.position; // coordenades originals
            guardada = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Reaparèixer(other.attachedRigidbody);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            Reaparèixer(collision.rigidbody);
    }

    void Reaparèixer(Rigidbody rb)
    {
        if (rb == null || !guardada) return;

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.position = posicioInicial;
        rb.transform.position = posicioInicial;
    }
}