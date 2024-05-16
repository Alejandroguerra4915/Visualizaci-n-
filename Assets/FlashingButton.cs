using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class FlashingButton : MonoBehaviour
{
    public Button button;
    public Color flashColor = Color.red; // Color al que parpadeará
    public float flashDuration = 0.5f; // Duración de cada parpadeo

    private Image buttonImage;
    private bool isFlashing = false;

    void Start()
    {
        buttonImage = button.GetComponent<Image>(); // Obtener el componente Image del botón
    }

    public void StartFlashing()
    {
        if (!isFlashing)
        {
            isFlashing = true;
            InvokeRepeating("ToggleFlash", 0f, flashDuration);
        }
    }

    public void StopFlashing()
    {
        if (isFlashing)
        {
            isFlashing = false;
            CancelInvoke("ToggleFlash");
            buttonImage.enabled = true; // Asegurar que la imagen del botón esté habilitada cuando se detiene el parpadeo
        }
    }

    void ToggleFlash()
    {
        buttonImage.enabled = !buttonImage.enabled; // Alternar la visibilidad de la imagen del botón para crear el efecto de parpadeo
    }
}
