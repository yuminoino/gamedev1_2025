using UnityEngine;

public class PlayerController : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 20.0f;
    public float turnSpeed = 50.0f;
    public float horizontalInput;
    public float forwardlInput;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardlInput = Input.GetAxis("Vertical");
        // Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardlInput);
        // Rotate the vehicle based on horizontal input
        transform. Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime); 
    }
}
