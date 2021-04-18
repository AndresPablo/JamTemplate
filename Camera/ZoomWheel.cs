using UnityEngine;

public class ZoomWheel : MonoBehaviour
{
    public float zoomMin = 4;
    public float zoomMax = 8;
    public float zoomSpeed = 2;


    void Update()
    {
        Camera.main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;

        if(Camera.main.orthographicSize > zoomMax)
            Camera.main.orthographicSize = zoomMax;
        else if(Camera.main.orthographicSize < zoomMin)
            Camera.main.orthographicSize = zoomMin;
    }
}
