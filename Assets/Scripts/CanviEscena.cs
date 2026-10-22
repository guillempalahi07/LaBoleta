using UnityEngine;
using UnityEngine.SceneManagement;

public class CanviEscena : MonoBehaviour
{
    public void Carregar(string nom) { SceneManager.LoadScene(nom); }
    public void Sortir() { Application.Quit(); }
}