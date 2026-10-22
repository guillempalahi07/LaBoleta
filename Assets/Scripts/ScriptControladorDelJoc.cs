using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptControladorDelJoc : MonoBehaviour
{
    private int puntuacio;

    int Puntuacio
    {
        get { return puntuacio; }
    }

    public void AfegeixPuntuacio(int quantitatPunts)
    {
        puntuacio += quantitatPunts;
    }
    public void CarregaEscena(int nEscena)
    {
        SceneManager.LoadScene(nEscena);
    }

    public void Surt()
    {
        #if UNITY_STANDALONE
            Application.Quit();
        #endif
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}


// FICAR ESCENA PORTADA AMB FOTO DE UNA BOLA, TÍTOL LA BOLA QUE RODA I 4 BOTONS (Escena 1,2,3 i surt)
// DINS DE CADA BOTÓ ONCLICK AL INSPECTOR I RUNEAR CONTROLADORDELJOC (GAMEOBJECT) i després que faci contoladordeljoc.surt, sript.Carregaescena (int), que sigui 1,2 o 3 depèn del botó