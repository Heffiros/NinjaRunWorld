using UnityEngine;
using System.Collections;

public class MobSpawner : MonoBehaviour {
	public float timeout;
	public GameObject Enemy;
	public int hp = 5;

	private float _timeSinceLast;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (hp < 1) {
			return;
		}

		_timeSinceLast += Time.deltaTime;

		if (_timeSinceLast > timeout) {
			Instantiate(Enemy, gameObject.transform.position, Quaternion.identity);

			_timeSinceLast = 0;
		}
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "WeaponTag") {
			hp--;
			if (hp == 0) {
				Destroy (gameObject);
			}
		}
	}
}
