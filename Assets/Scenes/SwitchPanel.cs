using UnityEngine;

public class SwitchPanels : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    public void OnButtonClick()
    {
        // Desactivar el panel 1
        panel1.SetActive(false);
        
        // Activar el panel 2
        panel2.SetActive(true);
    }
}
