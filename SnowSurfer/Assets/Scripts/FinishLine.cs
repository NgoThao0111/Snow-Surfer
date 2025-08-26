using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    [SerializeField] ParticleSystem goalParticle;
    [SerializeField] GameObject winMenu;
    [SerializeField] GameObject gameMenu;
    [SerializeField] WinMenuManager winMenuManager;

    void Start()
    {
        winMenu.gameObject.SetActive(false);   
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player"); // avoid error when changing layer's index
        if (collision.gameObject.layer == layerIndex)
        {
            Debug.Log("The player has won");
            goalParticle.Play();
            Invoke("OpenWinMenu", restartDelay); // restart the game when player meet finish line
        }
    }

    void OpenWinMenu()
    {
        winMenu.gameObject.SetActive(true);
        gameMenu.gameObject.SetActive(false);
        Time.timeScale = 0;
        winMenuManager.ShowResult();
    }
}
