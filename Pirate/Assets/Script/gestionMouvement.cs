using UnityEngine;
using System.Collections;

public class gestionMouvement : MonoBehaviour {

	// Use this for initialization
	public float speed = 0.01f;

	//private Animator anim;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 move = Vector3.zero;

		if (Input.GetKey (KeyCode.UpArrow)) {
			//anim.Play ("Walk");
			move += Vector3.left;
			//this.gameObject.transform.position += Vector3.forward * speed;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			move += Vector3.right;
			//this.gameObject.transform.position += Vector3.back * speed;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			move+= Vector3.back;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			move+= Vector3.forward;
		}
		this.gameObject.transform.position += move * speed * Time.fixedDeltaTime;
	}

	void OnCollisionEnter(Collision c)
	{
		if (c.collider.tag == "ZombieTag") {
			//Instantiate(this.zombie,this.gameObject.transform.position,this.gameObject.transform.rotation);
		
			//Player.Instance.HP--;
			Debug.Log("I haz "+Player.Instance.HP.ToString()+"hp");
			if (Player.Instance.HP < 1) {
				Destroy(this.gameObject);
			}
		}
	}
	// Update is called once per frame
}
