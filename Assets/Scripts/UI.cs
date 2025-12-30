using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using YG;


public class UI : MonoBehaviour 
{
	public GameObject menuUI;
	public GameObject gameUI;
	public GameObject gameOverUI;

	public GameObject diamondTextObj;
	public GameObject scoreTextObj;


	public GameObject help1;
	public GameObject help2;
	public GameObject help3;


	private int startCredit;
	private int finishCredit;
	private int diamond;
	private int iron;

	public float hiscore;
	[SerializeField] private TextMeshProUGUI DiamondText;
	[SerializeField] private TextMeshProUGUI critText;
	[SerializeField] private TextMeshProUGUI creditText;
	[SerializeField] private TextMeshProUGUI ironText;


	//Game UI
	public Text timeElapsed;
	public Slider planetHealthBar;

	//Game Over UI
	public Text goDefendTime;
	public Text goHighscoreTime;

	public static UI ui;

	public GameObject panel_loading , planet;

	public GameObject panelHome;

	void Awake () { ui = this; }

	void Start ()
	{
		planetHealthBar.maxValue = Planet.p.health;
		planetHealthBar.value = Planet.p.health;
	}

	void Update ()
	{
		if(Game_planet.g.gameActive)
		{
			SetTimeElapsed();
			diamond = PlayerPrefs.GetInt("diamond");
			DiamondText.text = diamond.ToString();
			creditText.text = diamond.ToString();
			iron = PlayerPrefs.GetInt("iron");
			ironText.text = iron.ToString();
		}
	}

	//On the menu screen, when the "Play" button gets pressed.
	public void OnPlayButton ()
	{
		CameraController_planet.c.TransitionToGameView();
		menuUI.SetActive(false);
		startCredit = PlayerPrefs.GetInt("diamond");
	}

	//On the menu or game over screen, when the "Quit" button gets pressed.
	public void OnQuitButton ()
	{
		planet.SetActive(false); 
		panel_loading.SetActive(true); 
		SceneManager.LoadSceneAsync(0 , LoadSceneMode.Single); 
	}

	//On the game over screen, when the "Menu" button gets pressed.
	public void OnMenuButton ()
	{
		SceneManager.LoadSceneAsync(22 , LoadSceneMode.Single);
	}

	//Enables the menu UI game object.
	public void SetMenuUI ()
	{
		menuUI.SetActive(true);
	}

	//Enables the game UI game object.
	public void SetGameUI ()
	{
		gameUI.SetActive(true);
	}

	//Enables the game over UI game object.
	public void SetGameOverUI ()
	{
		gameOverUI.SetActive(true);
		gameUI.SetActive(false);

		//Setting text values.
		goDefendTime.text = "\n<size=50>" + GetTimeAsString(Game_planet.g.gameTime) + "</size>";
		diamond = PlayerPrefs.GetInt("diamond");
		diamond += 5;
		PlayerPrefs.SetInt("diamond", diamond);
		hiscore = Game_planet.g.gameTime;
		PlayerPrefs.SetInt("hiscore", (int)hiscore);
		
		//Set highscore text.
		if (Game_planet.g.gameTimeHighscore == 0)
		{
			goHighscoreTime.text = "\n<size=50>" + GetTimeAsString(Game_planet.g.gameTime) + "</size>";
			Game_planet.g.SetTimeAsHighscore();
		}
		else
		{
			goHighscoreTime.text = "\n<size=50>" + GetTimeAsString(Game_planet.g.gameTimeHighscore) + "</size>";

			//If the current time is higher than the highscore, set that as the highscore.
			if(Game_planet.g.gameTime > Game_planet.g.gameTimeHighscore)
            {
				Game_planet.g.SetTimeAsHighscore();
				diamond = PlayerPrefs.GetInt("diamond");
				diamond += 20;
				PlayerPrefs.SetInt("diamond", diamond);
				hiscore = Game_planet.g.gameTime;
				PlayerPrefs.SetInt("hiscore", (int)hiscore);
			}
            else
            {
				Game_planet.g.SetTimeAsHighscore();
				diamond = PlayerPrefs.GetInt("diamond");
				diamond += 10;
				PlayerPrefs.SetInt("diamond", diamond);
				hiscore = Game_planet.g.gameTime;
				PlayerPrefs.SetInt("hiscore", (int)hiscore);
			}
			
		}
		finishCredit = PlayerPrefs.GetInt("diamond");
		finishCredit -= startCredit;
		critText.text = finishCredit.ToString();
	}

	//Sets the value of the planet health bar. Called when the planet takes damage.
	public void SetPlanetHealthBarValue (int value)
	{
		planetHealthBar.value = value;
		StartCoroutine(PlanetHealthBarFlash());
		
	}

	//Flashes the health bar red quickly.
	IEnumerator PlanetHealthBarFlash ()
	{
		Image fill = planetHealthBar.transform.Find("Fill Area/Fill").GetComponent<Image>();

		if(fill.color != Color.red)
		{
			Color dc = fill.color;
			fill.color = Color.red;

			yield return new WaitForSeconds(0.05f);

			fill.color = dc;
		}
	}

	//Sets the text that shows how long the game has been going for.
	void SetTimeElapsed ()
	{
		timeElapsed.text = " \n<size=55>" + GetTimeAsString(Game_planet.g.gameTime) + "</size>";
	}

	//Converts a number to a MINS:SECS time format.
	string GetTimeAsString (float t)
	{
		string mins = Mathf.FloorToInt(t / 60).ToString();

		if(int.Parse(mins) < 10)
			mins = "0" + mins;

		string secs = ((int)(t % 60)).ToString();

		if(int.Parse(secs) < 10)
			secs = "0" + secs;

		return mins + ":" + secs;
	}

	public void ToHome()
    {
		Time.timeScale = 0;
		panelHome.SetActive(true);

		diamondTextObj.SetActive(true);
		scoreTextObj.SetActive(true);

	}

	

	public void ToHome1()
	{
		
		panelHome.SetActive(true);

		diamondTextObj.SetActive(true);
		scoreTextObj.SetActive(true);

	}

	public void OutHome()
	{

		panelHome.SetActive(false);
		Time.timeScale = 1;

		diamondTextObj.SetActive(false);
		scoreTextObj.SetActive(false);

	}

	public void HelpPlay()
    {
		StartCoroutine(Help());
    }

	private IEnumerator Help()
    {
		help1.SetActive(true);
		yield return new WaitForSeconds(7);
		help2.SetActive(true);
		help1.SetActive(false);
		yield return new WaitForSeconds(7);
		help3.SetActive(true);
		help2.SetActive(false);
		yield return new WaitForSeconds(7);
		help3.SetActive(false);
	}

	public void ToSecondScene()
    {
		SceneManager.LoadScene(1);
	}
}
