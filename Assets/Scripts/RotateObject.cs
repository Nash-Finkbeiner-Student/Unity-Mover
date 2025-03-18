using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject gameObject;
    public float rotateAmount = 90f;
    public void Rotate()
    {
        gameObject.transform.Rotate(0.0f, rotateAmount, 0.0f);
    }
}
