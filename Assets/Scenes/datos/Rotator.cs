using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotar en los ejes X, Y y Z en función del tiempo y la velocidad de rotación
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
