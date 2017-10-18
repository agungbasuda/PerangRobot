using UnityEngine;
using System.Collections;

public class alert : MonoBehaviour {

	public float temp;
	private float tempcache;

	// Use this for initialization
	void Start () {
		tempcache = temp;
	}
	
	// Update is called once per frame
	void Update () {
		temp -= Time.deltaTime;
		if(temp <= 0){
			this.gameObject.SetActive(false);
			temp = tempcache;
		}
	}
}
