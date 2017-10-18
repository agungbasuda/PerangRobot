using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class roomcontroller : MonoBehaviour {
	public GameObject room;
	public AudioSource pintuopen;
	public AudioSource pintuclose;
	public bool isopened;
	public List<Egen> enemies;
	public List<Door> pintu;

	void Start () {
		isopened = true;
		foreach(Egen e in enemies){
			e.musuh.SetActive (false);
		}
	}
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			isopened = false;
			pintuopen.Play ();
			foreach(Egen e in enemies){
				e.musuh.SetActive (true);
			}
		}
	}
	void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
			room.GetComponent <BoxCollider> ().enabled = false;
		}
	}
	void Update () {
		foreach (Egen e in enemies) {
			if (GameObject.FindGameObjectWithTag ("Enemy") == null) {
				isopened = true;
			}
			else
			{
				isopened = false;
			}
		}
			
		if(isopened){
			foreach (Door n in pintu) {
				n.pintu.SetActive (false);
			}
		}
		else if(!isopened){
			foreach (Door n in pintu) {
				n.pintu.SetActive (true);
			}
		}
	}
}

[System.Serializable]
public class Egen{
	public GameObject musuh;
}

[System.Serializable]
public class Door{
	public GameObject pintu;
}