using UnityEngine;

[RequireComponent(typeof(Text))]
public class FloatingText : MonoBehaviour
{
    public Vector3 offset = new Vector3(0,2,0);

    void Start()
    {
        transform.localPosition += offset;
    }

}
