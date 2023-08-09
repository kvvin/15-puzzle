using UnityEngine;
using UnityEngine.SceneManagement;


public class restart : MonoBehaviour
{
    public void Restart()
    {
        // Load the first scene in the game.
        SceneManager.LoadScene("Game");
    }
}
