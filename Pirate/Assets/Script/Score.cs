using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text score;
	public Text Vague;
	// Use this for initialization
	void Start () {
		score = score.GetComponent<Text> ();
		Vague = Vague.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Points = " + Player.Instance.Points.ToString();
		Vague.text = "Wave = " + Player.Instance.Wave.ToString();
	}
}
