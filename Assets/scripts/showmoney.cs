using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showmoney : MonoBehaviour {

	public Text duid;

	// Use this for initialization
	void Start () {
		int money = PlayerPrefs.GetInt ("money");
		duid.text = money.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.K)) {
			duid.text = "0";
		}
	}
}
