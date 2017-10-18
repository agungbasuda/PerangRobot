using UnityEngine;
using System.Collections;

public class playerspotted : MonoBehaviour {

	public bool chaseplayer;

	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			chaseplayer = true;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
