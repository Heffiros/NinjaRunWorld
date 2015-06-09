using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Canvas QuitMenu;

	public Button startText;
	public Button exitText;
	
	// Use this for initialization
	void Start () {
		QuitMenu = QuitMenu.GetComponent<Canvas> ();

		exitText = exitText.GetComponent<Button> ();
		startText = startText.GetComponent<Button> ();
	
		QuitMenu.enabled = false;
	}

	
	public void exitGame () {
		Application.Quit();
	}

	public void noPress () {
		QuitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void ExitPress() {
		QuitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}

	public void LaunchGame() {
		Application.LoadLevel (1);
	}
}
