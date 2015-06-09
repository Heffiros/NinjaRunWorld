using UnityEngine;
using System;
using System.Collections.Generic;

public class Bullet : MonoBehaviour {
	public float speed = 15.0f;
	public List<string> triggerTags;
	public float lifespan = 2;
	private float _lifetime;
	public Vector3 Direction {get; set;}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		_lifetime += Time.deltaTime;

		if (_lifetime > lifespan) {
			Destroy (gameObject);
			return;
		}

		transform.position += Direction * speed * Time.deltaTime;
	}

	void OnCollisionEnter(Collision c) {
		if (triggerTags.Contains(c.gameObject.tag)) {
			Destroy (gameObject);
		}
	}
}
