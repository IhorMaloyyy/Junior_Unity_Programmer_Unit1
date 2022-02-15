using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    
    [SerializeField] private Vector3 offset = new Vector3(0, 5, -7);
    
    private Vector3 changeView = new Vector3(0, 1.8f, 1.05f);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
