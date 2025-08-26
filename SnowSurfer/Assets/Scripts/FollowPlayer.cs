using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Vector3 positionFromPlayer;
    [SerializeField] GameObject player;

    void Start()
    {
        //positionFromPlayer = transform.position - player.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + positionFromPlayer;
    }
}
