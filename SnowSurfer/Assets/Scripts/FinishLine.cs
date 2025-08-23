using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player"); // avoid error when changing layer's index
        if (collision.gameObject.layer == layerIndex)
        {
            Debug.Log("The player has won");
            Invoke("Restart", restartDelay); // restart the game when player meet finish line
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
