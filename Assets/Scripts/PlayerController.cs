using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*[SerializeField] private float speed = 15.0f;*/
    [SerializeField] private float turnSpeed = 100.0f;
    private Rigidbody playerRb;

    [SerializeField] private float horsePower;
    private float horizontalInput;
    private float verticalInput;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        /*transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);*/
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
