using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    public GameObject[] imagenes; // Arreglo para almacenar las imágenes que se mostrarán

    // Método para ocultar todas las imágenes
    void OcultarTodasLasImagenes()
    {
        foreach (GameObject imagen in imagenes)
        {
            imagen.SetActive(false);
        }
    }

    // Método para mostrar una imagen específica
    public void MostrarImagen(int indice)
    {
        OcultarTodasLasImagenes(); // Ocultar todas las imágenes primero
        imagenes[indice].SetActive(true); // Mostrar la imagen en el índice proporcionado
    }
}
