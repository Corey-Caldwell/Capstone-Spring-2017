using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	
	public bool isPaused;
	public bool isControlOn;
	public GameObject pauseMenuCanvas;

	public GameObject controlMenuCanvas;
	// Update is called once per frame
	void Update () {
		
		if (isPaused) {
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0f;
		} else {
			pauseMenuCanvas.SetActive (false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			isPaused = !isPaused;
		}
		if (isControlOn) {
			controlMenuCanvas.SetActive (true);
		} else {
			controlMenuCanvas.SetActive (false);
		}
	}
	public void Resume()
	{
		isPaused = false;
	}
	public void Quit()
	{
		Application.Quit();
	}
	public void Control()
	{
		isControlOn = true;
	}
	public void CloseControl()
	{
		isControlOn = false;
	}

}
