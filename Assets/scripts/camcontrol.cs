using UnityEngine;
using System.Collections;

public class camcontrol : MonoBehaviour {
	[SerializeField]
	private Transform target;

	Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.position;
	}

	// Update is called once per frame
	void Update () {
		Vector3 targetcampos = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetcampos, 20 * Time.deltaTime);
	}
}
