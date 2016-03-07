using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class InwardForce : MonoBehaviour {

	public float attractionForce = 6f;

	Rigidbody body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		body.AddForce (transform.position * -attractionForce);
	}
}
