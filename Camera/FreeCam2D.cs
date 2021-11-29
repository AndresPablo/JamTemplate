using UnityEngine;

public class FreeCam2D : MonoBehaviour
{
    public float speed = 1f;
    public Vector2 boundaryBox = new Vector2(32,18);
    Vector2 dir;


    void Start()
    {
        
    }

    
    void Update()
    {
        Mover();
    }

    void Mover()
    {
        dir.x = 0;
        dir.y = 0;

        if(Input.GetKey(KeyCode.W) && transform.position.y < boundaryBox.y)
        {
            dir.y = 1;
        }
        if(Input.GetKey(KeyCode.S) && transform.position.y > -boundaryBox.y)
        {
            dir.y = -1;
        }
        if(Input.GetKey(KeyCode.A) && transform.position.x > -boundaryBox.x)
        {
            dir.x = -1;
        }
        if(Input.GetKey(KeyCode.D) && transform.position.x < boundaryBox.x)
        {
            dir.x = 1;
        }

        transform.position += (Vector3)dir * speed;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(Vector3.zero, 
            new Vector3(boundaryBox.x, boundaryBox.y, 0));
    }

}
