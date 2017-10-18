using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class roomcontrollerboss : MonoBehaviour {
	public AudioSource bunyi;

	public GameObject playerbar;
	public player pemain;
	public bool isbossdead;

	public GameObject cleared;
	public GameObject bossalert;

	public GameObject bosshealthui;
	public GameObject room;
	public AudioSource pintuopen;
	public AudioSource pintuclose;
	public bool isopened;

	public List<EBgen> enemies;
	public List<BDoor> pintu;

	// Use this for initialization
	void Start () {
		isbossdead = false;

		cleared.SetActive (false);
		bossalert.SetActive (false);

		isopened = true;
		bosshealthui.SetActive (false);
		foreach(EBgen e in enemies){
			e.boss.SetActive (false);
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			isopened = false;
			pintuopen.Play ();
			foreach(EBgen e in enemies){
				e.boss.SetActive (true);
				isbossdead = false;
			}
			bosshealthui.SetActive (true);
			bossalert.SetActive (true);
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

		if(isbossdead){
			bosshealthui.SetActive (false);
			playerbar.SetActive (false);
			cleared.SetActive (true);
			pemain.canmove = false;
			pemain.canshoot = false;
		}

		foreach (EBgen e in enemies) {
			if(GameObject.FindGameObjectWithTag("Boss") == null)
			{
				isopened = true;
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

			foreach (BDoor n in pintu) {
				n.pintu.SetActive (false);
			}

			//pintu1.SetActive (false);
			//pintu2.SetActive (false);

		}

		else if(!isopened){

			foreach (BDoor n in pintu) {
				n.pintu.SetActive (true);
			}
				
			//pintu1.SetActive (true);
			//pintu2.SetActive (true);
		}

	}
}

[System.Serializable]
public class EBgen{

	public GameObject boss;

}

[System.Serializable]
public class BDoor{

	public GameObject pintu;

}