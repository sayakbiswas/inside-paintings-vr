﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class enlarge : MonoBehaviour {
	public GameObject room;
	//public AudioSource audios;
	// Use this for initialization
	public bool trig = false;
	public bool trig2 = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (transform.localPosition.z);

		if ((transform.localPosition.z > 6.8f) && (transform.localPosition.x < -0.4f) && trig == false) {
			trig = true;
			StartCoroutine (Goodasdasd ());
		}
		if ((transform.localPosition.z > 10f) && (transform.localPosition.x < -0.4f) && trig2 == true) {
			SceneManager.LoadSceneAsync (1);
		}
	}

	IEnumerator Goodasdasd () {
		yield return new WaitForSeconds(3f);
		for (int i = 1; i < 80; i++) {
			yield return new WaitForSeconds(0.01f);
			room.transform.localScale = new Vector3 (room.transform.localScale.x*1.01f, room.transform.localScale.y, room.transform.localScale.z*1.01f);
			room.transform.localPosition = new Vector3 (room.transform.localPosition.x, room.transform.localPosition.y - 0.03f, room.transform.localPosition.z-0.01f);
		}

		trig2 = true;
	
	
	}
}
