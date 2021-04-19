using UnityEngine;

public class DestroyTime : MonoBehaviour
{
    public float time = 10f;

    void Start()
    {
        Invoke("DestroySelf", time);
    }

    public void DestroySelf()
    {
        Destroy(this.gameObject);
    }
}
