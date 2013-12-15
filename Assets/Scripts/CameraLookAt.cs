﻿using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour {

	public Transform target;

	private float smooth = 5;
	private Vector3 newTransformPosition;

	void Start() {
		newTransformPosition = transform.position;
	}

    
    void Update () {
        newTransformPosition.x = Mathf.Lerp(newTransformPosition.x, target.position.x, Time.deltaTime * smooth);	// - 2.1f
        newTransformPosition.y = Mathf.Lerp(newTransformPosition.y, target.position.y, Time.deltaTime * smooth);
    	transform.position = newTransformPosition;
    }
}
