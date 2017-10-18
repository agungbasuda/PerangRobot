using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour {
	public GameObject boss;

	public Transform target;

	private Transform mytransform;

	public float rotationspeed;

	public float movespeed;


	void Awake(){
		mytransform = transform;
	}

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		target = go.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(boss == null){
			Destroy (gameObject);
		}

		mytransform.position += mytransform.forward * movespeed * Time.deltaTime;

		mytransform.rotation=Quaternion.Slerp(mytransform.rotation, Quaternion.LookRotation(target.position - mytransform.position), rotationspeed*Time.deltaTime);
	}
}
