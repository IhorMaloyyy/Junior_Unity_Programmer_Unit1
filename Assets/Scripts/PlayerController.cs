using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private float speed;
    private float rpm;

    [SerializeField] private float turnSpeed = 100.0f;
    private Rigidbody playerRb;
    [SerializeField] private GameObject centerOfMass;

    [SerializeField] private TextMeshProUGUI speedometerText;
    [SerializeField] private TextMeshProUGUI rpmText;

    [SerializeField] private float horsePower;
    private float horizontalInput;
    private float verticalInput;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        /*transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);*/
        
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        speed = Mathf.Round(playerRb.velocity.magnitude * 3.6f);
        speedometerText.SetText($"Speed: {speed} km/h");

        rpm = Mathf.Round((speed % 30) * 40);
        rpmText.SetText($"RPM: {rpm}");
    }
}
