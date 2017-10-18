using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class player : MonoBehaviour {
	public GameObject failed;

	public bool playerstart;

	public GameObject poweraura;
	public GameObject guardaura;

	public bool canshoot;
	public bool canmove;

	public GameObject manaalert;
	public GameObject cdalert;

	public Vector3 mousepos;

	public Vector3 pointtolook;

	private ebossulet1 ulet1;
	private ebossulet2 ulet2;
	private ebossulet3 ulet3;
	private ebossulet4 ulet4;
	private ebossulet5 ulet5;
	private egunsatu gun1;
	private egundua gun2;
	private eguntiga gun3;
	private egunempat gun4;
	private egunlima gun5;
	private erocketsatu rkt1;
	private erocketdua rkt2;
	private erockettiga rkt3;
	private erocketempat rkt4;
	private erocketlima rkt5;

	public bulletcontroller peluru;
	public Transform asalpeluru;
	public float bulletspeed;

	public float buff2durationcache;
	public float buff3durationcache;

	public float attackcache;
	public float defendcache;

	public bool skill2isbuff = false;
	public bool skill3isbuff = false;

	public GameObject skill2buff;
	public GameObject skill3buff;

	public float buffdurationskill2 = 20f;
	public float buffdurationskill3 = 10f;

	public AudioSource bunyi1;
	public AudioSource bunyi2;
	public AudioSource heals;
	public AudioSource powers;
	public AudioSource shields;

	public bool reloading;

	public float timebetweenshots = 2f;

	private float timestamp;

	private CharacterController cece;

	public float rotationspeed;

	private Quaternion targetrotation;

	private Camera maincamera;

	[SerializeField]
	public stat health;
	[SerializeField]
	public stat mana;
	[SerializeField]
	public float attack;
	[SerializeField]
	public float defend;
	[SerializeField]
	public float speed;

	[SerializeField]
	private stat ammo;

	[SerializeField]
	private List<Skill> skills;

	private Animator anim;

	void OnTriggerStay(Collider other){
		if(other.tag == "laser1"){
			if (ulet1.attack * 0.05f - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= ulet1.attack * 0.05f - defend;
			}
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "erocket1bullet"){
			if (rkt1.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= rkt1.attack - defend;
			}
		}
		else if(other.tag == "erocket2bullet"){
			if (rkt2.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= rkt2.attack - defend;
			}
		}
		else if(other.tag == "erocket3bullet"){
			if (rkt3.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= rkt3.attack - defend;
			}
		}
		else if(other.tag == "erocket4bullet"){
			if (rkt4.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= rkt4.attack - defend;
			}
		}
		else if(other.tag == "erocket5bullet"){
			if (rkt5.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= rkt5.attack - defend;
			}
		}
		else if(other.tag == "egun1bullet"){
			if (gun1.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= gun1.attack - defend;
			}
		}
		else if(other.tag == "egun2bullet"){
			if (gun2.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= gun2.attack - defend;
			}
		}
		else if(other.tag == "egun3bullet"){
			if (gun3.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= gun3.attack - defend;
			}
		}
		else if(other.tag == "egun4bullet"){
			if (gun4.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= gun4.attack - defend;
			}
		}
		else if(other.tag == "egun5bullet"){
			if (gun5.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= gun5.attack - defend;
			}
		}
		else if(other.tag == "boss1bullet"){
			if (ulet1.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= ulet1.attack - defend;
			}
		}
		else if(other.tag == "boss2bullet"){
			if (ulet2.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= ulet2.attack - defend;
			}
		}
		else if(other.tag == "boss3bullet"){
			if (ulet3.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= ulet3.attack - defend;
			}
		}
		else if(other.tag == "boss4bullet"){
			if (ulet4.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= ulet4.attack - defend;
			}
		}
		else if(other.tag == "boss5bullet"){
			if (ulet5.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= ulet5.attack - defend;
			}
		}
		else if(other.tag == "laser1"){
			if (ulet1.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= ulet1.attack - defend;
			}
		}
		else if(other.tag == "laser2"){
			if (ulet2.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= ulet2.attack - defend;
			}
		}
		else if(other.tag == "laser3"){
			if (ulet3.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= ulet3.attack - defend;
			}
		}
		else if(other.tag == "laser4"){
			if (ulet4.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= ulet4.attack - defend;
			}
		}
		else if(other.tag == "laser5"){
			if (ulet5.attack - defend <= 0) {
				health.Curvalue -= 1f;
			} else {
				health.Curvalue -= ulet5.attack - defend;
			}
		}
	}
		
	private void Awake(){

		health.Initialize ();
		mana.Initialize ();
		ammo.Initialize ();

		gun1 = GameObject.FindObjectOfType<egunsatu> ();
		gun2 = GameObject.FindObjectOfType<egundua> ();
		gun3 = GameObject.FindObjectOfType<eguntiga> ();
		gun4 = GameObject.FindObjectOfType<egunempat> ();
		gun5 = GameObject.FindObjectOfType<egunlima> ();
		rkt1 = GameObject.FindObjectOfType<erocketsatu> ();
		rkt2 = GameObject.FindObjectOfType<erocketdua> ();
		rkt3 = GameObject.FindObjectOfType<erockettiga> ();
		rkt4 = GameObject.FindObjectOfType<erocketempat> ();
		rkt5 = GameObject.FindObjectOfType<erocketlima> ();
		ulet1 = GameObject.FindObjectOfType<ebossulet1> ();
		ulet2 = GameObject.FindObjectOfType<ebossulet2> ();
		ulet3 = GameObject.FindObjectOfType<ebossulet3> ();
		ulet4 = GameObject.FindObjectOfType<ebossulet4> ();
		ulet5 = GameObject.FindObjectOfType<ebossulet5> ();

	}
		
	void Start(){
		Time.timeScale = 1;

		int lvl = PlayerPrefs.GetInt("lvl");
		if (lvl == 2) {
			health.Maxvalue = 500f;
			mana.Maxvalue = 150f;
			attack = 5f;
			defend = 1f;
			speed = 60f;
		} else if (lvl == 3) {
			health.Maxvalue = 1000f;
			mana.Maxvalue = 200f;
			attack = 10f;
			defend = 5f;
			speed = 70f;
		} else if (lvl == 4) {
			health.Maxvalue = 10000f;
			mana.Maxvalue = 250f;
			attack = 100f;
			defend = 10f;
			speed = 80f;
		} else if (lvl == 5) {
			health.Maxvalue = 100000f;
			mana.Maxvalue = 300f;
			attack = 1000f;
			defend = 100f;
			speed = 90f;
		} else {
			health.Maxvalue = 100f;
			mana.Maxvalue = 100f;
			attack = 1f;
			defend = 0f;
			speed = 50f;
		}

		playerstart = true;

		poweraura.SetActive (false);
		guardaura.SetActive (false);

		canshoot = true;
		canmove = true;

		manaalert.SetActive (false);
		cdalert.SetActive (false);

		skill2buff.SetActive (false);
		skill3buff.SetActive (false);

		cece = GetComponent<CharacterController> ();
		maincamera = FindObjectOfType<Camera>();
		//maincamera=GameObject.FindGameObjectWithTag("kamera2");

		anim = gameObject.GetComponentInChildren<Animator> ();

	}

	void Update(){
		if(!playerstart){
			if(health.Curvalue == 0f){
				Time.timeScale = 0;
				failed.SetActive (true);
			}
		}
			
		if(playerstart){
			health.Curvalue = health.Maxvalue;
			mana.Curvalue = mana.Maxvalue;
			playerstart = false;
		}

		if (Input.GetMouseButton(0)) {
			anim.SetInteger ("kontrolanimasi", 1);
		} 
		else
			anim.SetInteger ("kontrolanimasi", 0);

		if(canshoot){
			if (!reloading && Time.time >= timestamp && Input.GetMouseButton (0)) {
				ammo.Curvalue -= 1;
				bulletcontroller newbullet = Instantiate (peluru, asalpeluru.position, asalpeluru.rotation) as bulletcontroller;
				newbullet.speed = bulletspeed;
				bunyi1.Play ();
				timestamp = Time.time + timebetweenshots * 0.5f;
			}
		}

		//mana regen code
		mana.Curvalue += Time.deltaTime * 3;

		//aim code
		Ray cameraray = maincamera.ScreenPointToRay (Input.mousePosition);
		Plane Groundplane = new Plane (Vector3.up, Vector3.zero);
		float raylength;
		if(Groundplane.Raycast(cameraray, out raylength)){
			pointtolook = cameraray.GetPoint (raylength);
			Debug.DrawLine (cameraray.origin, pointtolook, Color.blue);
		}

		//movement code
		if(canmove){
			targetrotation = Quaternion.LookRotation (pointtolook - new Vector3(transform.position.x, 0, transform.position.z));
			transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle (transform.eulerAngles.y, targetrotation.eulerAngles.y, rotationspeed*Time.deltaTime);
			Vector3 input = new Vector3 (Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
			cece.Move(input*speed*Time.deltaTime);
		}
			
		if (ammo.Curvalue == ammo.Maxvalue) {
			reloading = false;
		}
			
		//reload code
		if(ammo.Curvalue < ammo.Maxvalue && Input.GetKeyDown(KeyCode.R)){
			bunyi2.Play ();
		reloading = true;
		}

		//auto reload code
		if(ammo.Curvalue == 0){
			bunyi2.Play ();
			reloading = true;
		}

		if (reloading && Time.time>=timestamp) {
			ammo.Curvalue += 1f;
			timestamp = Time.time + timebetweenshots*0.1f;
		}

		if (!reloading) {
			bunyi2.Stop ();
		}

		//script skill
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			if (skills [0].currentcooldown >= skills [0].cooldown && mana.Curvalue >= skills [0].manacost) {
				skills [0].currentcooldown = 0;
				mana.Curvalue -= skills [0].manacost;
				health.Curvalue += health.Maxvalue * 70/100;
				heals.Play ();
			}
			else if(skills [0].currentcooldown < skills [0].cooldown){
				cdalert.SetActive (true);
			}
			else if(mana.Curvalue <= skills [0].manacost){
				manaalert.SetActive (true);
			}
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			if (skills [1].currentcooldown >= skills [1].cooldown && mana.Curvalue >= skills [1].manacost) {
				skills [1].currentcooldown = 0;
				mana.Curvalue -= skills [1].manacost;
				buff2durationcache = buffdurationskill2;
				attackcache = attack;
				skill2buff.SetActive (true);
				skill2isbuff = true;
				attack = attack*3f;
				powers.Play ();
				poweraura.SetActive (true);
			}
			else if(skills [1].currentcooldown < skills [1].cooldown){
				cdalert.SetActive (true);
			}
			else if(mana.Curvalue <= skills [1].manacost){
				manaalert.SetActive (true);
			}
		}	
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			if (skills [2].currentcooldown >= skills [2].cooldown && mana.Curvalue >= skills [2].manacost) {
				skills [2].currentcooldown = 0;
				mana.Curvalue -= skills [2].manacost;
				buff3durationcache = buffdurationskill3;
				defendcache = defend;
				skill3buff.SetActive (true);
				skill3isbuff = true;
				defend = defend + 10000f;
				shields.Play ();
				guardaura.SetActive (true);
			}
			else if(skills [2].currentcooldown < skills [2].cooldown){
				cdalert.SetActive (true);
			}
			else if(mana.Curvalue <= skills [2].manacost){
				manaalert.SetActive (true);
			}
		}	

		if (skill2isbuff) {
			buffdurationskill2 -= Time.deltaTime;
		}

		if(buffdurationskill2 <= 0f){
			skill2buff.SetActive (false);
			attack = attackcache;
			buffdurationskill2 = buff2durationcache;
			skill2isbuff = false;
			poweraura.SetActive (false);
		}

		if(skill3isbuff) {
			buffdurationskill3 -= Time.deltaTime;
		}

		if(buffdurationskill3 <= 0f){
			skill3buff.SetActive (false);
			defend = defendcache;
			buffdurationskill3 = buff3durationcache;
			skill3isbuff = false;
			guardaura.SetActive (false);
		}

		if (mana.Curvalue < skills [0].manacost) {
			skills [0].gabisa.SetActive (false);
		}
		if (mana.Curvalue < skills [1].manacost) {
			skills [1].gabisa.SetActive (false);
		}
		if (mana.Curvalue < skills [2].manacost) {
			skills [2].gabisa.SetActive (false);
		}
		if (mana.Curvalue >= skills [0].manacost) {
			skills [0].gabisa.SetActive (true);
		}
		if (mana.Curvalue >= skills [1].manacost) {
			skills [1].gabisa.SetActive (true);
		}
		if (mana.Curvalue >= skills [2].manacost) {
			skills [2].gabisa.SetActive (true);
		}

		foreach (Skill s in skills) {
			if (s.currentcooldown >= s.cooldown) {
				s.waktu.text = "";
			}

			if (s.currentcooldown < s.cooldown) {
				s.currentcooldown += Time.deltaTime;
				s.currentwaktu -= Time.deltaTime;
				s.skillcon.fillAmount = s.currentcooldown / s.cooldown;
				if(s.currentwaktu < 0){
					s.waktu.text = "";
					s.currentwaktu = s.cooldown;
				}
				else
					s.waktu.text = "" + Mathf.Round(s.currentwaktu);
			}
		}
	}
}

[System.Serializable]
public class Skill
{
	public float cooldown;
	public Image skillcon;
	public float currentcooldown;
	public Text waktu;
	public float currentwaktu;
	public float manacost;
	public GameObject gabisa;
}