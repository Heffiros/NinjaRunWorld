using UnityEngine;
using System.Collections;

public class EatBrains : MonoBehaviour {
	public float speed;
	private GameObject _player;
	public int hp = 2;
	//public GameObject explosionEffect;

	// Use this for initialization
	void Start () {
		_player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (hp < 1 || gameObject == null) {
			return;
		}

		Vector3 direction = (_player.transform.position - this.transform.position).normalized * Time.deltaTime * speed;
		this.transform.position += direction;

		transform.LookAt (_player.transform);
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "WeaponTag") {
			Destroy (c.collider);
			hp--;
			// are we RIP
			if (hp == 0) {
				Player.Instance.AddPoints(Player.PointIncome.ZOMBIE);
				Destroy(gameObject);
			}
		}
	}
}
