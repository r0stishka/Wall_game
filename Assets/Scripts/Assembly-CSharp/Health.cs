using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
	public float health = 1f;

	public GameObject gameOverPanel;

	public Text gameOverText;

	public GameObject gameWinPanel;

	private void Start()
	{
		Time.timeScale = 1f;
		gameOverPanel.SetActive(false);
	}

	private void Update()
	{
		if (health <= 0f)
		{
			GameOver();
			Time.timeScale = 0f;
		}
		else if (health > 1f)
		{
			GameWin();
			Time.timeScale = 0f;
		}
	}

	public void getDamage(float amount)
	{
		health -= amount;
	}

	public void getHealth(float win)
	{
		health += win;
	}

	private void GameOver()
	{
		gameOverPanel.SetActive(true);
		gameOverText.text = "GAME OVER";
	}

	private void GameWin()
	{
		gameWinPanel.SetActive(true);
	}

	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void NextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void MainMenuLevel()
	{
		SceneManager.LoadScene(0);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
