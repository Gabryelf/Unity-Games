using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private Player2 player;
    [SerializeField] private ParticleSystem explosionEffect;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text livesText;

    [SerializeField] private TextMeshProUGUI IronText;
    [SerializeField] private TextMeshProUGUI ScoreText;
    public int Iron;

    public GameObject effShild;

    public Image bar;
    public float fill;

    public GameObject JoystickObj;
    public GameObject ButAttackObj;

    public GameObject butJoyOn;
    public GameObject butJoyOff;

    public bool isJoy;

    public GameObject panelHome;

    private int score;
    private int lives;

    public int Score => score;
    public int Lives => lives;

    private void Awake()
    {
        if (Instance != null) {
            DestroyImmediate(gameObject);
        } else {
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        fill = 1f;
        NewGame();
    }

    private void Update()
    {
        isJoy = PlayerPrefs.GetInt("isJoy") == 1 ? true : false;
        if (isJoy)
        {
            ButAttackObj.SetActive(false);
            JoystickObj.SetActive(false);
            butJoyOn.SetActive(true);
            butJoyOff.SetActive(false);
        }
        else
        {
            ButAttackObj.SetActive(true);
            JoystickObj.SetActive(true);
            butJoyOn.SetActive(false);
            butJoyOff.SetActive(true);
        }

        if (lives <= 0 && Input.GetKeyDown(KeyCode.Return)) {
            NewGame();
        }
    }

    private void NewGame()
    {
        lives = PlayerPrefs.GetInt("lives");
        Asteroid[] asteroids = FindObjectsOfType<Asteroid>();

        for (int i = 0; i < asteroids.Length; i++) {
            Destroy(asteroids[i].gameObject);
        }

        gameOverUI.SetActive(false);

        SetScore(0);
        SetLives(lives);
        Respawn();
    }

    private void SetScore(int score)
    {
        this.score = score;
        scoreText.text = score.ToString();
    }

    private void SetLives(int lives)
    {
        this.lives = lives;
        livesText.text = lives.ToString();
    }

    private void Respawn()
    {
        player.transform.position = Vector3.zero;
        player.gameObject.SetActive(true);
    }

    public void OnAsteroidDestroyed(Asteroid asteroid)
    {
        explosionEffect.transform.position = asteroid.transform.position;
        explosionEffect.Play();

        if (asteroid.size < 0.7f) {
            SetScore(score + 100); // small asteroid
        } else if (asteroid.size < 1.4f) {
            SetScore(score + 50); // medium asteroid
        } else {
            SetScore(score + 25); // large asteroid
        }
    }

    public void OnPlayerDeath(Player2 player)
    {
        player.gameObject.SetActive(false);
        fill = lives / lives;
        bar.fillAmount = fill / lives;
        explosionEffect.transform.position = player.transform.position;
        explosionEffect.Play();

        SetLives(lives - 1);
        
        StartCoroutine(ShildEffect());

        if (lives <= 0) {
            Iron = PlayerPrefs.GetInt("iron");
            Iron += score / 120;
            PlayerPrefs.SetInt("iron", Iron);
            IronText.text = Iron.ToString();
            ScoreText.text = score.ToString();
                
            gameOverUI.SetActive(true);
        } else {
            Invoke(nameof(Respawn), player.respawnDelay);
        }
    }

    public void ToPause2()
    {
        panelHome.SetActive(true);
        Time.timeScale = 0;

    }

    public void OutPause2()
    {
        panelHome.SetActive(false);
        Time.timeScale = 1;

    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void JoystickOn()
    {
        isJoy = false;
        PlayerPrefs.SetInt("isJoy", isJoy ? 1 : 0);
    }

    public void JoystickOff()
    {
        isJoy = true;
        PlayerPrefs.SetInt("isJoy", isJoy ? 1 : 0);
    }

    public void ToMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    private IEnumerator ShildEffect()
    {
        effShild.SetActive(true);
        yield return new WaitForSeconds(3);
        effShild.SetActive(false);
    }
}
