using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class score : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerscore;
    public Text scoreText;
    public GameObject GameOver;

    public void addScore()
    {
        if(GameOver.activeSelf)
        {
            Time.timeScale = 0f;
        }
        if (!GameOver.activeSelf)
        {
            playerscore = playerscore + 1;
            scoreText.text = playerscore.ToString();
        }
        else
        {  
            playerscore = 0;
            scoreText.text = playerscore.ToString();
           
        }

    }
    public void Restartgame()
    {
 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void gameOver()
    {
        GameOver.SetActive(true);
        playerscore = 0;
        scoreText.text = playerscore.ToString();

    }
}
