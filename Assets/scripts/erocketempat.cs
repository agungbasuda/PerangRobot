using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class erocketempat : MonoBehaviour {
	public bool canact;

	public GameObject meletus;
	public GameObject model;
	private float meletustime;


	[SerializeField]
	private estat ehealth;

	public playerspotted spotp;

	public float attack;

	public float defend;

	public float bulletspeed;

	public float timebetweenshots = 5f;

	private float timestamp;

	public erocketbullet peluru;

	public Transform asalpeluru;

	bool playerinrange;

	//private float fillamount;

	//[SerializeField]
	//private enemystat ehealth;

	//[SerializeField]
	//private float lerpspeed;

	//[SerializeField]
	//private float secondlerpspeed;

	//[SerializeField]
	//private Image content;

	//[SerializeField]
	//private Image secondcontent;

	public player peplayer;

	//public player peplayer;

	public Transform target;

	public float movespeed;

	public float rotationspeed;

	private Transform mytransform;

	//public bool isAlive;

	void Awake(){
		mytransform = transform;
		ehealth.Initialize ();
	}

	// Use this for initialization
	void Start () {
		canact = true;

		meletus.SetActive(false);
		//		isAlive = true;

		GameObject kung = GameObject.FindGameObjectWithTag ("Player");
		peplayer = kung.GetComponent<player>();

		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		target = go.transform;
	}

	//public float emaxvalue{ get; set;}

	//public float Value{
	//	set{ 
	//		fillamount = Map (value, 0, emaxvalue, 0, 1);
	//	}
	//}

	//private float Map(float value, float inMin,float inMax, float outMin, float outMax)	{
	//	return(value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	//}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			playerinrange = true;
		}
		if(other.tag == "playerbullet"){
			if (peplayer.attack - defend <= 0) {
				ehealth.ECurvalue -= 1f;
			} else {
				ehealth.ECurvalue -= peplayer.attack - defend;
			}

			//egun1ketembak = true;
			//damagecontrol newdamage = Instantiate (damagekontrol, asaldamage.position, asaldamage.rotation) as damagecontrol;
		}
	}

	void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
			playerinrange = false;
		}
	}

	// Update is called once per frame
	void Update () {
		if (canact) {
			if (playerinrange && Time.time >= timestamp) {
				erocketbullet newbullet = Instantiate (peluru, asalpeluru.position, asalpeluru.rotation) as erocketbullet;
				newbullet.speed = bulletspeed;
				timestamp = Time.time + timebetweenshots * 0.5f;
			}

			if (!playerinrange) {
				if (spotp.chaseplayer) {
					mytransform.position += mytransform.forward * movespeed * Time.deltaTime;
				}
			}
			mytransform.rotation=Quaternion.Slerp(mytransform.rotation, Quaternion.LookRotation(target.position - mytransform.position), rotationspeed*Time.deltaTime);
		}

		//if (fillamount != content.fillAmount) {
		//	content.fillAmount = Mathf.Lerp(content.fillAmount,fillamount,Time.deltaTime*lerpspeed);
		//	secondcontent.fillAmount = Mathf.Lerp(secondcontent.fillAmount,fillamount,Time.deltaTime*secondlerpspeed);
		//}


		if (ehealth.ECurvalue <= 0) {
			this.GetComponent <CharacterController> ().enabled = false;
			model.SetActive (false);
			canact = false;
			meletus.SetActive (true);
			meletustime += Time.deltaTime;
			if(meletustime >= 3){
				Destroy (this.gameObject);
			}
		}

		mytransform.rotation=Quaternion.Slerp(mytransform.rotation, Quaternion.LookRotation(target.position - mytransform.position), rotationspeed*Time.deltaTime);

	}
}
