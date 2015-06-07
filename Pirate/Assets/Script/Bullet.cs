using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float speed = 15.0f;
	public Vector3 Direction {get; set;}

	private float _lifetime;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		_lifetime += Time.deltaTime;

		if (_lifetime > 2) {
			Destroy (gameObject);
			return;
		}

		transform.position += Direction * speed * Time.deltaTime;
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "WeaponTag" || c.gameObject.tag == "ZombieTag") {
			Destroy (gameObject);
		}
	}
}
