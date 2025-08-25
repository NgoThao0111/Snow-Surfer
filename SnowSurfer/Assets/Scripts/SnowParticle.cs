using UnityEngine;

public class SnowParticle : MonoBehaviour
{
    int floorLayerIndex;
    [SerializeField] ParticleSystem snowParticleSystem;
    void Start()
    {
        floorLayerIndex = LayerMask.NameToLayer("Floor");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == floorLayerIndex)
        {
            snowParticleSystem.Play();
        }

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == floorLayerIndex)
        {
            snowParticleSystem.Stop();
        }
        
    }
}
