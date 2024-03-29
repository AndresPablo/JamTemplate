using UnityEngine;

public class LookAtCursor : MonoBehaviour
{
    
    void Update()
    {
        var dir = Input.mousePosition- Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
