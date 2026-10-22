using Unity.VisualScripting;
using UnityEngine;

public class ControladorDeCamera : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 desplaçament;
    private Quaternion rotacioInicial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        desplaçament = transform.position - jugador.transform.position;
        rotacioInicial = transform.rotation;

        //desplaçament = this.GameObject (transform.position - jugador.transform.position);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = jugador.transform.position + desplaçament;
        transform.rotation = rotacioInicial;
    }
}
