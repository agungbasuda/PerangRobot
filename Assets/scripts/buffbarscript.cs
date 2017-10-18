using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buffbarscript : MonoBehaviour {

	public player pemain;

	public Text buff2time;
	public Text buff3time;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		buff2time.text = "" + Mathf.Round(pemain.buffdurationskill2);
		buff3time.text = "" + Mathf.Round(pemain.buffdurationskill3);
	}
}
