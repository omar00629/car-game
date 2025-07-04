using UnityEngine;
using UnityEngine.UI;

public class RaceManager : MonoBehaviour
{
    public float timeLimit = 60f;
    public Text timerText;

    private float currentTime;

    void Start() => currentTime = timeLimit;

    void Update()
    {
        currentTime -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.Ceil(currentTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
            Debug.Log("Race Complete!");
    }
}