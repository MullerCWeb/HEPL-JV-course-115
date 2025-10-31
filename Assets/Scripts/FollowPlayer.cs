using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;
    
    void Update()
    {
        // Debug.Log(playerTransform.position);

        transform.position = playerTransform.position + offset;
    }
}
