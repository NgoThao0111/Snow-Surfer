using UnityEngine;
using TMPro;

public class TutorialTrigger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI rotateText;
    [SerializeField] TextMeshProUGUI brakeText;
    [SerializeField] float textDisappearDelay = 5f;

    void Start()
    {
        rotateText.gameObject.SetActive(false);
        brakeText.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RotateTrigger"))
        {
            rotateText.gameObject.SetActive(true);
            Destroy(rotateText.gameObject, textDisappearDelay);
        }
        else if (collision.gameObject.CompareTag("BrakeTrigger"))
        {
            brakeText.gameObject.SetActive(true);
            Destroy(brakeText.gameObject, textDisappearDelay);            
        }
    }
}
