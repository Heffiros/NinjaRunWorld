using UnityEngine;
using System.Collections;

public class fistage : MonoBehaviour {
	public Bullet projectile;
	public float delay = 1f;
	private float _timeSinceLast;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		_timeSinceLast += Time.deltaTime;

		if (Input.GetKey (KeyCode.Space) && _timeSinceLast > delay) {
			var bullet = (Bullet)Instantiate (projectile, gameObject.transform.position, Quaternion.identity);
			bullet.Direction -= transform.right;
			_timeSinceLast = 0;
		}
	}
}
