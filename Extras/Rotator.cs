 public class Rotator : MonoBehaviour
{
    public Vector3 speed;  
    
     void Update()
     {
         transform.Rotate(
              speed.x * Time.deltaTime,
              speed.y * Time.deltaTime,
              speed.z * Time.deltaTime
         );
     }
}
