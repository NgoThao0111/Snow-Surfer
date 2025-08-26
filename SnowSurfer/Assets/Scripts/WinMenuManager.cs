using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WinMenuManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] FlipCounter flipCounter;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI flipCountText;
    [SerializeField] TextMeshProUGUI highestComboText;
    public void ShowResult()
    {
        scoreText.text = "Score: " + scoreManager.getScore();
        flipCountText.text = "Flip count: " + flipCounter.GetTotalFlip();
        highestComboText.text = "Highest combo: " + flipCounter.GetHighestCombo();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
