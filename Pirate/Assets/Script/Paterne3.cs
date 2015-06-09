using UnityEngine;
using System.Collections;

public class Paterne3 : MonoBehaviour {
	
	public GameObject spawn;
	public GameObject check1;
	GameObject despawn;
	GameObject etape1;
	// Use this for initialization
	void Start () {
		despawn = GameObject.FindGameObjectWithTag ("etape");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = (despawn.transform.position - this.transform.position).normalized;
		this.transform.position += direction * 4.0f * Time.deltaTime;
		this.transform.rotation = Quaternion.LookRotation (direction, this.transform.up);
	}
	
	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag == "etape") {
			Debug.Log("dasx");
			despawn = GameObject.FindGameObjectWithTag ("dead2");
		}
		if (c.gameObject.tag == "dead2") {
			Destroy(this.gameObject);
		}
	}
}
