using UnityEngine;

public class FreeCam2D : MonoBehaviour
{
    public float speed = .08f;
    Vector2 dir;


    void Start()
    {
        
    }

    
    void Update()
    {
        dir.x = 0;
        dir.y = 0;

        if(Input.GetKey(KeyCode.W))
        {
            dir.y = 1;
        }
        if(Input.GetKey(KeyCode.S))
        {
            dir.y = -1;
        }
        if(Input.GetKey(KeyCode.A))
        {
            dir.x = -1;
        }
        if(Input.GetKey(KeyCode.D))
        {
            dir.x = 1;
        }

        transform.position += (Vector3)dir * speed;
    }
}
