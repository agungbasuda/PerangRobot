using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {

	public player pemain;

	public GameObject satu;
	public GameObject dua;
	public GameObject tiga;
	public GameObject empat;
	public GameObject lima;
	public GameObject enam;
	public GameObject tujuh;
	public GameObject bg;

	// Use this for initialization
	void Start () {
		bg.SetActive (true);
		satu.SetActive (true);
		dua.SetActive (false);
		tiga.SetActive (false);
		empat.SetActive (false);
		lima.SetActive (false);
		enam.SetActive (false);
		tujuh.SetActive (false);
	}

	public void tsatu(){
		satu.SetActive (false);
		dua.SetActive (true);
	}
	public void tdua(){
		dua.SetActive (false);
		tiga.SetActive (true);
	}
	public void ttiga(){
		tiga.SetActive (false);
		empat.SetActive (true);
	}
	public void tempat(){
		empat.SetActive (false);
		lima.SetActive (true);
	}
	public void tlima(){
		lima.SetActive (false);
		enam.SetActive (true);
	}
	public void tenam(){
		enam.SetActive (false);
		tujuh.SetActive (true);
	}
	public void ttujuh(){
		tujuh.SetActive (false);
		bg.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (satu.activeInHierarchy || dua.activeInHierarchy || tiga.activeInHierarchy || empat.activeInHierarchy || lima.activeInHierarchy || enam.activeInHierarchy || tujuh.activeInHierarchy) {
			pemain.canmove = false;
			pemain.canshoot = false;
		} else {
			pemain.canmove = true;
			pemain.canshoot = true;
		}
	}
}
