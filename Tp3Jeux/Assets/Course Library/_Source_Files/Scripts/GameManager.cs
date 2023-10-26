using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using UnityEngine.EventSystems;
using static SaveSystem;

public class GameManager : MonoBehaviour
{
    float spawnRate = 1f;
    public List<GameObject> targets;

    public TextMeshProUGUI scoreText;

    public int score = 0;
    private int nLives = 3;
    private int difficulte;

    public static GameManager instance;

    public List<GameObject> lifeImages;

    public bool gameIsActive = true;

    public GameObject gameOverScreen;

    public AudioSource gameMusic;

    public GameObject mainMenuScreen;

    

    // Start is called before the first frame update
    void Start()
    {

        //Difficulte
        difficulte = GameSettings.Difficulte;

        //Get save
        getSaveDatas();

        spawnRate = spawnRate * difficulte;
        StartCoroutine(SpawnTargets());
        gameMusic.volume = GameSettings.VolumeMusique/10;

        instance = this;
        
        UpdateScore();
        UpdateLives();
        gameOverScreen.SetActive(false);
    }

    private void getSaveDatas()
    {
        if(SaveSystem.CheckHasState()){
            GameState gameState = SaveSystem.CheckAndLoadGameStateData();

            score = gameState.score;
            nLives = gameState.nbVie;
            difficulte += gameState.difficulte;

        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );

    }

    public void GameOver()
    {
        gameIsActive = false;

        gameOverScreen.SetActive(true);
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OuvrirPause();
        } 
    }

    private void OuvrirPause() {
        Time.timeScale = 1f - Time.timeScale;
        //TODO empecher le joueur de cliquer sur des elements pendant la pause
    }

    public void SetPause(bool val = true)
    {
        Time.timeScale = val ? 1f : 0f;
    }

    public void UpdateScore(int scoreToAdd = 0)
    {
        score += scoreToAdd;

        scoreText.text = $"Score: {score}";
    }

    public void UpdateLives(int livesToAdd = 0)
    {
        nLives += livesToAdd;

        for(int i = 0; i < lifeImages.Count; i++)
        {
            lifeImages[i].SetActive(i < nLives);
        }

        if (nLives <= 0) GameOver();
    }

    private IEnumerator SpawnTargets()
    {
        while (gameIsActive)
        {
            yield return new WaitForSeconds(1f / spawnRate);
            var index = Random.Range(0, targets.Count);

            Instantiate(targets[index]);
        }
    }
}
