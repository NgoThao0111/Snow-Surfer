using UnityEngine;
using TMPro;

public class FlipCounter : MonoBehaviour
{
    float totalAngle;
    float previousAngle;
    int flipCount;
    int comboCount;
    int highestCombo;
    [SerializeField] TextMeshProUGUI comboCounterText;
    [SerializeField] float comboTimeout = 2f;
    [SerializeField] ScoreManager scoreManager;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flipCount = 0;
        totalAngle = 0;
        previousAngle = 0;
        comboCounterText.gameObject.SetActive(false);
        timer = 0;
        comboCount = 0;
        highestCombo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float currentAngle = transform.rotation.eulerAngles.z;
        totalAngle += Mathf.DeltaAngle(previousAngle, currentAngle);
        if (totalAngle > 320 || totalAngle < -320)
        {
            //flipParticleSystem.Play();
            totalAngle = 0;
            flipCount++;
            comboCount++;
            Debug.Log(comboCount);
            comboCounterText.gameObject.SetActive(true);
            comboCounterText.text = "Flip! x" + comboCount;
            timer = comboTimeout;
            scoreManager.AddScore(50 + comboCount * 50);
        }
        if (timer > 0) timer -= Time.deltaTime; // count down
        else if (comboCount > 0)
        {
            if (comboCount > highestCombo) highestCombo = comboCount;
            comboCount = 0; // reset count
            Debug.Log(comboCount);
            comboCounterText.gameObject.SetActive(false);
        }
        previousAngle = currentAngle;
    }

    public int GetHighestCombo()
    {
        return highestCombo;
    }

    public int GetTotalFlip()
    {
        return flipCount;
    }
}
