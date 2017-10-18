using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class canvaslookatcamera : MonoBehaviour {

	[SerializeField]
	public Canvas thecanvas;

	void Start(){
		//mycamera = GameObject.FindGameObjectWithTag ("MainCamera");
		//Canvas thecanvas = mycanvas.GetComponent<Canvas> ();
		//thecanvas.worldCamera = mycamera;

		GameObject kung = GameObject.FindGameObjectWithTag ("MainCamera");
		thecanvas.worldCamera = kung.GetComponent<Camera>();

		//Camera kamera = GetComponent<Camera>().GetComponent<Camera>();
		//Canvas kanvas = FindObjectOfType<Canvas> ().worldCamera;
		//kanvas = kamera;
	}

	void Update () {
		var camera = GetComponent<Canvas> ().worldCamera;
		transform.rotation = Quaternion.LookRotation (camera.transform.forward, camera.transform.up);
	}
}
