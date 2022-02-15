using UnityEngine;

public class CarMover : MonoBehaviour
{
    [SerializeField] private float speed = 15.0f;
  
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        
    }

}
