using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class minibossulet5 : MonoBehaviour {
	public bool canact;

	public GameObject meletus;
	public GameObject model;
	private float meletustime;

	public roomcontrollerminiboss control;

	private float fillamount;

	public AudioSource bunyi1;

	[SerializeField]
	private stat ehealth;

	public float attack;

	public float defend;

	public float bulletspeed;

	private float timestamp;

	public Transform target;

	public float timebetweenshots = 2f;

	public float rotationspeed;

	private Transform mytransform;

	public player peplayer;

	public ebossbullet peluru;

	public Transform asalpeluru;

	void Awake(){
		ehealth.Initialize ();
	}

	// Use this for initialization
	void Start () {
		mytransform = this.transform;

		GameObject kung = GameObject.FindGameObjectWithTag ("Player");
		peplayer = kung.GetComponent<player>();

		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		target = go.transform;
	}

	// Update is called once per frame
	void Update () {
		mytransform.rotation=Quaternion.Slerp(mytransform.rotation, Quaternion.LookRotation(target.position - mytransform.position), rotationspeed*Time.deltaTime);
		if (canact) {
			if (Time.time >= timestamp) {
				ebossbullet newbullet = Instantiate (peluru, asalpeluru.position, asalpeluru.rotation) as ebossbullet;
				newbullet.speed = bulletspeed;
				bunyi1.Play ();
				timestamp = Time.time + timebetweenshots * 0.5f;
			}
		}
		if (ehealth.Curvalue <= 0) {
			meletus.SetActive (true);
			model.SetActive (false);
			control.isminibossdead = true;
			meletustime += Time.deltaTime;
			canact = false;
			if(meletustime >= 3){
				Destroy (this.gameObject);
			}
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "playerbullet"){
			if (peplayer.attack - defend <= 0) {
				ehealth.Curvalue -= 1f;
			} else {
				ehealth.Curvalue -= peplayer.attack - defend;
			}
		}
	}

}
