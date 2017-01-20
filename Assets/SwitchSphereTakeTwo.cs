using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSphereTakeTwo : MonoBehaviour {


	private int sphereNumber;

	public GameObject s1;
	public GameObject s2;
	public GameObject s3;

	// Use this for initialization
	void Start () {
		sphereNumber = 1;
		s1.transform.position = new Vector3 (0f, 0f, 0f);
		s2.transform.position = new Vector3 (100f, 100f, 100f);
		s3.transform.position = new Vector3 (100f, 100f, 100f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			if (sphereNumber == 1) {
				s2.transform.position = new Vector3 (0f, 0f, 0f);
				s1.transform.position = new Vector3 (100f, 100f, 100f);
				s3.transform.position = new Vector3 (100f, 100f, 100f);
				sphereNumber = 2;
			} else if (sphereNumber == 2) {
				s3.transform.position = new Vector3 (0f, 0f, 0f);
				s1.transform.position = new Vector3 (100f, 100f, 100f);
				s2.transform.position = new Vector3 (100f, 100f, 100f);
				sphereNumber = 3;
			} else {
				s1.transform.position = new Vector3 (0f, 0f, 0f);
				s2.transform.position = new Vector3 (100f, 100f, 100f);
				s3.transform.position = new Vector3 (100f, 100f, 100f);
				sphereNumber = 1;
			}
		}
	}
}
