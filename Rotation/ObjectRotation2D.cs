using UnityEngine;

//Rotates the 2D object Clockwise or Counter Clockwise
public class ObjectRotation2D: MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private bool isRotationClockwise = true;
    void Update()
    {
        if(isRotationClockwise)
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        else
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
