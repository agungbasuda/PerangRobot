using UnityEngine;
using System.Collections;

public class survivalguide : MonoBehaviour {
	public bool mulai;

	public bool siapmulai;

	public GameObject ini;

	public GameObject trituwan;

	public float waktu;

	// Use this for initialization
	void Start () {
		siapmulai = false;
		waktu = 4f;
	}

	public void Resume(){
		ini.SetActive (false);
		trituwan.SetActive (true);
		siapmulai = true;
	}

	// Update is called once per frame
	void Update () {
		if(siapmulai){
			waktu -= Time.deltaTime;
			if(waktu <= 0){
				mulai = true;
			}
		}

		if(mulai){
			trituwan.SetActive (false);
		}
	}
}
