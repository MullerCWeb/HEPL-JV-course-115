using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float forwardForce = 50.0f;
    [SerializeField] private float sidewaysForce = 30.0f;
    
    [SerializeField] private Rigidbody rigidbodyPlayer;
    
    void FixedUpdate()
    {
        rigidbodyPlayer.AddForce(0.0f, 0.0f, forwardForce);
        
        if (Input.GetKey(KeyCode.Q))
        {
            rigidbodyPlayer.AddForce(-sidewaysForce, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbodyPlayer.AddForce(sidewaysForce, 0.0f, 0.0f);
        }
    }
}
