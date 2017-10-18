using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class roomcontrollerminiboss : MonoBehaviour {
	public AudioSource bunyi;

	public bool isminibossdead;

	public GameObject minibossalert;

	public GameObject bosshealthui;
	public GameObject room;
	public AudioSource pintuopen;
	public AudioSource pintuclose;
	public bool isopened;

	public List<MBgen> enemies;
	public List<MBDoor> pintu;

	// Use this for initialization
	void Start () {
		isminibossdead = false;

		minibossalert.SetActive (false);

		isopened = true;
		bosshealthui.SetActive (false);
		foreach(MBgen e in enemies){
			e.boss.SetActive (false);
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			isopened = false;
			pintuopen.Play ();
			foreach(MBgen e in enemies){
				e.boss.SetActive (true);
				isminibossdead = false;
			}
			bosshealthui.SetActive (true);
			minibossalert.SetActive (true);
			bunyi.Play ();
		}
	}

	void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
			room.GetComponent <BoxCollider> ().enabled = false;
		}
	}

	// Update is called once per frame
	void Update () {

		if(isminibossdead){
			bosshealthui.SetActive (false);
		}

		foreach (MBgen e in enemies) {
			if(GameObject.FindGameObjectWithTag("MiniBoss") == null)
			{
				isopened = true;
				bosshealthui.SetActive (false);
				//cleared.SetActive(true);
				//pintuclose.Play ();
			}
			//else if(GameObject.FindObjectOfType<egunsatu>() == null)
			//{
			//	isopened = true;
			//	Debug.Log ("kung kung kung");
			//	//pintuclose.Play ();
			//}
			else
			{
				isopened = false;
			}
		}

		if(isopened){

			foreach (MBDoor n in pintu) {
				n.pintu.SetActive (false);
			}

			//pintu1.SetActive (false);
			//pintu2.SetActive (false);

		}

		else if(!isopened){

			foreach (MBDoor n in pintu) {
				n.pintu.SetActive (true);
			}

			//pintu1.SetActive (true);
			//pintu2.SetActive (true);
		}

	}
}

[System.Serializable]
public class MBgen{

	public GameObject boss;

}

[System.Serializable]
public class MBDoor{

	public GameObject pintu;

}