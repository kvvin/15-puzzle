using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int timeRemaining = 120;
    public Text timerText;

    public void Start()
    {
        // Start the timer.
        StartCoroutine(Countdown());

        // Initialize the timer text.
        timerText.text = timeRemaining.ToString();
    }

    IEnumerator Countdown()
    {
        while (timeRemaining > 0)
        {
            // Decrement the timer.
            timeRemaining--;

            // Update the timer text.
            timerText.text = timeRemaining.ToString();

            // Yield the coroutine to allow Unity to update the scene.
            yield return new WaitForSeconds(1);
        }

        // The timer is done, load the GameOver scene.
        SceneManager.LoadScene("GameOver");
    }
}
