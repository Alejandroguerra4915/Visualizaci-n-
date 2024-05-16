using UnityEngine;

public class Rotator2 : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotar en los ejes X, Y y Z en función del tiempo y la velocidad de rotación
      
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
