using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            SeguentEscena();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            SeguentEscena();
    }

    void SeguentEscena()
    {
        int seguent = SceneManager.GetActiveScene().buildIndex + 1;
        // Si és l'últim nivell, torna a la portada (escena 0)
        if (seguent >= SceneManager.sceneCountInBuildSettings)
            seguent = 0;
        SceneManager.LoadScene(seguent);
    }
}
