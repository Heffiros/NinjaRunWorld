	using UnityEngine;
using System.Collections;

public class sponer2 : MonoBehaviour {
	public GameObject mobPrefab;
	public float interval;
	
	float timeElapsed;
	
	// Use this for initialization
	void Start () {
		timeElapsed = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;
		
		if (timeElapsed >= interval) {
			GameObject.Instantiate(mobPrefab, this.transform.position, Quaternion.identity);
			timeElapsed = 0;
		}
	}
}
