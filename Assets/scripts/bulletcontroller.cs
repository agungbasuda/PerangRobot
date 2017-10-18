using UnityEngine;
using System.Collections;

public class bulletcontroller : MonoBehaviour {

	//object peluru
	public GameObject pelurunya;
	//suara peluru ditembak
	public AudioSource bunyi1;
	//kecepatan peluru
	[HideInInspector]
	public float speed;
	//umur peluru
	public float lifetime;

	//peluru bertumbukan dengan objek lain
	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy"){
			bunyi1.Play ();
			Destroy (gameObject);
		}
		else if(other.tag == "Boss"){
			bunyi1.Play ();
			Destroy (gameObject);
		}
		else if(other.tag == "MiniBoss"){
			bunyi1.Play ();
			Destroy (gameObject);
		}
	}
	void Update () {
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
		lifetime -= Time.deltaTime;
		if(lifetime<=0){
			Destroy (gameObject);
		}
	}
}
