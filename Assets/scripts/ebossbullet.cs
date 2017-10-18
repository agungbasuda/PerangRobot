using UnityEngine;
using System.Collections;

public class ebossbullet : MonoBehaviour {

	//pelurunya musuh

	public GameObject pelurunya;

	public AudioSource bunyi1;

	[HideInInspector]
	public float speed;

	public float lifetime;

	void Start(){
		bunyi1.Play ();
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.forward * speed * Time.deltaTime);

		lifetime -= Time.deltaTime;

		if(lifetime<=0){
			Destroy (gameObject);
		}
	}
}
