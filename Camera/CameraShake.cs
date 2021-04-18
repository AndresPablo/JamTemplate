using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [ContextMenuItem("Shake Camera", "Shake")]
    [Range(0.01f, 1f)]public float shakeMagnitude = 0.05f;
    [Min(0)]public float shakeTime = 0.5f;
    Camera mainCamera;
    Vector3 cameraInitialPosition;
    [Min(1)]float shakeMultiplier = 1;


    void Start()
    {
        mainCamera = Camera.main;    
        cameraInitialPosition = mainCamera.transform.position;
    }

    [ContextMenu("Shake It")]
    public void Shake()
    {
        cameraInitialPosition = mainCamera.transform.position;
        InvokeRepeating("StartCameraShaking", 0f, 0.005f);
        Invoke("StopCameraShaking", shakeTime);
    }

    public void Shake(float _time)
    {
        cameraInitialPosition = mainCamera.transform.position;
        shakeMultiplier = 1;
        InvokeRepeating("StartCameraShaking", 0f, 0.005f);
        Invoke("StopCameraShaking", _time);
    }

    public void Shake(float _time, float _intensity = 1)
    {
        cameraInitialPosition = mainCamera.transform.position;
        shakeMultiplier = _intensity;
        InvokeRepeating("StartCameraShaking", 0f, 0.005f);
        Invoke("StopCameraShaking", _time);
    }

    void SetCamPos(Vector3 newPos)
    {
        mainCamera.transform.position = newPos;
    }

    void StartCameraShaking()
    {
        float cameraShakingOffsetX = Random.value * shakeMultiplier* shakeMagnitude * 2 -shakeMagnitude;
        float cameraShakingOffsetY = Random.value * shakeMultiplier* shakeMagnitude * 2 -shakeMagnitude;
        Vector3 cameraIntermadiatePosition = mainCamera.transform.position;
        cameraIntermadiatePosition.x += cameraShakingOffsetX;
        cameraIntermadiatePosition.y += cameraShakingOffsetY;
        SetCamPos( cameraIntermadiatePosition);
    }

    void StopCameraShaking()
    {
        CancelInvoke("StartCameraShaking");
        SetCamPos( cameraInitialPosition );
    }

}
