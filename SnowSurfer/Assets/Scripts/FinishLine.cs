using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player"); // avoid error when changing layer's index
        if (collision.gameObject.layer == layerIndex)
        {
            Debug.Log("The player has won"); 
            SceneManager.LoadScene(0); // restart the game when player meet finish line
        }
    }
}
