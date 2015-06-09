using UnityEngine;
using System.Collections;

public class Teleportation : MonoBehaviour {

	//public GameObject particle;
	// Use this for initialization
	public ParticleSystem particle;
	private int count;
	void Start () {
		//gameObject.GetComponent<ParticleSystem>().enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		int enemyCount = GameObject.FindGameObjectsWithTag ("ZombieSpawn").Length;
			//this.gameObject.particleEmitter = true;
		if (enemyCount == 0 && count == 0) {
			count =1;
			GameObject.Instantiate(this.particle, this.gameObject.transform.position, Quaternion.Euler(-90,0,0));
			particle.Play();

		}
	}

	void OnCollisionEnter(Collision c)
	{
		if ((c.gameObject.tag == "Player") && count == 1) {
			Player.Instance.GoShopThenLevel(Player.Instance.GetNextLevel());
		}
	}
}
