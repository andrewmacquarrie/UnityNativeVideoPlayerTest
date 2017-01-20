using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSwitch : MonoBehaviour {

	private int sphereNumber;

	public GameObject s1;
	public GameObject s2;
	public GameObject s3;
	UnityEngine.Video.VideoPlayer vp1;
	UnityEngine.Video.VideoPlayer vp2;
	UnityEngine.Video.VideoPlayer vp3;

	private long currentFrame;

	private UnityEngine.Video.VideoPlayer vPlayer;

	// Use this for initialization
	void Start () {
		currentFrame = 0;
		sphereNumber = 1;
		s2.SetActive(false);
		s3.SetActive(false);


		vp1 = s1.GetComponent<UnityEngine.Video.VideoPlayer>();
		vp2 = s2.GetComponent<UnityEngine.Video.VideoPlayer>();
		vp3 = s3.GetComponent<UnityEngine.Video.VideoPlayer>();


		vp1.prepareCompleted += Prepared;
		vp2.prepareCompleted += Prepared;
		vp3.prepareCompleted += Prepared;
	}

	void Prepared(UnityEngine.Video.VideoPlayer vPlayer) {
		for (int i = 0; i < currentFrame; i++) {
			vPlayer.StepForward();
		}
		vPlayer.Play();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			if (sphereNumber == 1) {
				currentFrame = vp1.frame;
				s1.SetActive(false);
				s2.SetActive(true);
				//vp2.time = frame;
				/*
				for (int i = 0; i < frame; i++) {
					vp2.StepForward();
				}*/
				sphereNumber = 2;
			} else if (sphereNumber == 2) {
				currentFrame = vp2.frame;
				s2.SetActive(false);
				s3.SetActive(true);
				//vp3.time = frame;
				/*for (int i = 0; i < frame; i++) {
					vp3.StepForward();
				}*/
				sphereNumber = 3;
			} else {
				currentFrame = vp3.frame;
				s3.SetActive(false);
				s1.SetActive(true);
				//vp1.time = frame;
				/*for (int i = 0; i < frame; i++) {
					vp1.StepForward();
				}*/
				sphereNumber = 1;
			}
		}
	}
}
