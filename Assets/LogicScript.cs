using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;
    private bool isGameOver = false; // Boolean to check if the game is over; used to stop score updates

    [ContextMenu("Increase Score")]

   
    public void addScore(int scoreAdd) 
    {
        if (!isGameOver) // Only add to the score if the game is not over
        { 

            playerScore += scoreAdd;
            scoreText.text = playerScore.ToString();
            dingSFX.Play();

        }
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        isGameOver = true; // Set isGameOver to true to stop any further score updates
        gameOverScreen.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
