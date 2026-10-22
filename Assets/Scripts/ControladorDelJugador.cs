using System;
using TMPro;
using UnityEngine;

public class ControladorDelJugador : MonoBehaviour
{
    public TextMeshProUGUI marcador;
    public GameObject controladorDelJoc;
    ScriptControladorDelJoc scriptControladorDelJoc;
    int nCaptures = 0;
    public float velocitat = 5;
    public float forcaSalt = 5;
    bool enTerra;
    Rigidbody Rigidbody;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        controladorDelJoc = GameObject.FindGameObjectWithTag("GameController");
        scriptControladorDelJoc = controladorDelJoc.GetComponent<ScriptControladorDelJoc>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && enTerra)
        {
            Rigidbody.AddForce(Vector3.up * forcaSalt, ForceMode.Impulse);
            enTerra = false;
        }
    }

    private void FixedUpdate()
    {
        float movVertical = Input.GetAxis("Vertical");
        float movHoritzontal = Input.GetAxis("Horizontal");

        Vector3 direccio = new Vector3(movHoritzontal, 0f, movVertical);
        Rigidbody.AddForce(direccio * velocitat);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terra"))
        {
            enTerra = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Andromina"))
        {
            other.tag = "Untagged";
            Destroy(other.gameObject);
            nCaptures++;
            marcador.text = "Puntuació: " + nCaptures;
        }
    }
}