using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    // Public GameObject to rotate
    public GameObject targetObject;

 
    private float rotationAmount = 45f;

    

    // Rotate around X axis
    public void RotateX()
    {
        targetObject.transform.Rotate(new Vector3(45f, 0f, 0f));
    }

    // Rotate around Y axis
    public void RotateY()
    {
        targetObject.transform.Rotate(new Vector3(0f, 45f, 0f));
    }

    // Rotate around Z axis
   public void RotateZ()
    {
        targetObject.transform.Rotate(new Vector3(0f, 0f, 45f));
    }
}
