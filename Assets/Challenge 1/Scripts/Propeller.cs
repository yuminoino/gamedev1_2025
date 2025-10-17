using UnityEngine;

public class Propeller : MonoBehaviour

{
    public float propellerSpeed = 500.0f;
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * propellerSpeed * Time.deltaTime);
    }
}
