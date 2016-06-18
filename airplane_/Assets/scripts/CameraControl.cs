﻿using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    GameObject player;
    Vector3 offset;

	// Use this for initialization
	void Start () {

        player = GameObject.FindWithTag("Player");
        offset = player.transform.position - transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void LateUpdate() {

        transform.position = player.transform.position - offset;
    }
}
