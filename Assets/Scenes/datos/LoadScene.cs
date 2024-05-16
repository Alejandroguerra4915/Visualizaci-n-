using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneName; // Nombre de la escena a la que quieres cambiar

    public void ChangeToScene()
    {
        SceneManager.LoadScene(sceneName); // Cargar la escena especificada
    }
}
