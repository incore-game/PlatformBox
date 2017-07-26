using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {
public Transform target;
public float speed;
public Vector3 target_pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (transform.position, target.transform.position,  Time.deltaTime * 0.1f);
		target_pos = Vector3.Lerp(target_pos,target.position,Time.deltaTime*speed);
		transform.LookAt(target_pos);
	}
}
