using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FirstPersonCamera : MonoBehaviour
{
    private float xAxis;
    private float yAxis;

   float xAxisTurnRate = 360f;
   float yAxisTurnRate = 360f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {

        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0f);

        Camera.main.transform.rotation = newRotation;
    }

    public void AddXAxisInput(float input)
    {
        xAxis -= input * xAxisTurnRate;
        xAxis = Mathf.Clamp(xAxis, -90f, 90f);
    }

    public void AddYAxisInput(float input)
    {
        yAxis += input * yAxisTurnRate;
    }
}
