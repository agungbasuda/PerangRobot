using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playersurvival : MonoBehaviour {
	private survivalguide svg;

	public GameObject clear;
	public GameObject failed;

	private float timer;

	public Text timeleft;

	private survivalship surship;

	public bool playerstart;

	public bool canmove;

	public Vector3 mousepos;

	public Vector3 pointtolook;

	private CharacterController cece;

	public float rotationspeed;

	private Quaternion targetrotation;

	private Camera maincamera;

	private Animator anim;

	[SerializeField]
	public stat health;
	public float speed;

	void Awake(){
		surship = GameObject.FindObjectOfType<survivalship> ();

		health.Initialize ();
	}

	// Use this for initialization
	void Start () {
		svg = GameObject.FindObjectOfType<survivalguide> ();

		timer = 60;
		timeleft.text = timer.ToString ();

		rotationspeed = 4500f;
		health.Curvalue = 20f;
		health.Maxvalue = 20f;
		speed = 150f;

		Time.timeScale = 1;

		playerstart = true;

		canmove = true;

		cece = GetComponent<CharacterController> ();

		maincamera = FindObjectOfType<Camera>();

		anim = gameObject.GetComponentInChildren<Animator> ();
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "egun1bullet"){
			health.Curvalue -= surship.attack;
			}
		}

	// Update is called once per frame
	void Update () {
		if (svg.mulai) {
			timer -= Time.deltaTime;
			timeleft.text = "" + Mathf.Round (timer);
		}
		if(!playerstart){
			if(health.Curvalue == 0f){
				Time.timeScale = 0;
				failed.SetActive (true);
			}

			if(timer <= 0f){
				Time.timeScale = 0;
				clear.SetActive (true);
			}
		}

		if(playerstart){
			health.Curvalue = health.Maxvalue;
			playerstart = false;
		}

		Ray cameraray = maincamera.ScreenPointToRay (Input.mousePosition);
		Plane Groundplane = new Plane (Vector3.up, Vector3.zero);
		float raylength;
		if(Groundplane.Raycast(cameraray, out raylength)){
			pointtolook = cameraray.GetPoint (raylength);
			Debug.DrawLine (cameraray.origin, pointtolook, Color.blue);
		}

		if(canmove){
			targetrotation = Quaternion.LookRotation (pointtolook - new Vector3(transform.position.x, 0, transform.position.z));
			transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle (transform.eulerAngles.y, targetrotation.eulerAngles.y, rotationspeed*Time.deltaTime);

			Vector3 input = new Vector3 (Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

			cece.Move(input*speed*Time.deltaTime);
		}
	}
}
