using UnityEngine;

public class PlayerController : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float verticalSpeed = 20.0f;
    public float turnSpeed = 50.0f;
    public float horizontalInput;
    public float forwardlInput;
    public float jumpInput;
    private Rigidbody playerRb;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardlInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");
        playerRb = GetComponent<Rigidbody>();

        // Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * forwardlInput);

        // Rotate the vehicle based on horizontal input
        transform. Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        // Move the vehicle upward based on jump input
        transform.Translate(Vector3.up * Time.deltaTime * verticalSpeed * jumpInput);  
        Input.GetKeyDown(KeyCode.Space);

        if (Mathf.Approximately(playerRb.linearVelocity.y, 0))
        {
            playerRb.AddForce(Vector3.up * jumpInput, ForceMode.Impulse);
        }
    }
}
