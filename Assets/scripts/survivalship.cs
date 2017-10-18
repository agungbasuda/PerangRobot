using UnityEngine;
using System.Collections;

public class survivalship : MonoBehaviour {
	private survivalguide svg;

	public float attack;

	public float bulletspeed;

	public float timebetweenshots = 2f;

	private float timestamp;

	public egunbullet peluru;

	public Transform asalpeluru;

	public player peplayer;

	public Transform target;

	public float rotationspeed;

	private Transform mytransform;

	void Awake(){
		mytransform = transform;
	}

	// Use this for initialization
	void Start () {
		svg = GameObject.FindObjectOfType<survivalguide> ();

		GameObject kung = GameObject.FindGameObjectWithTag ("Player");
		peplayer = kung.GetComponent<player>();

		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		target = go.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (svg.mulai) {
			if (Time.time >= timestamp) {
				egunbullet newbullet = Instantiate (peluru, asalpeluru.position, asalpeluru.rotation) as egunbullet;
				newbullet.speed = bulletspeed;
				timestamp = Time.time + timebetweenshots * 0.5f;
			}
		}

		mytransform.rotation=Quaternion.Slerp(mytransform.rotation, Quaternion.LookRotation(target.position - mytransform.position), rotationspeed*Time.deltaTime);
	}
}
