using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public CameraShake cameraShake;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E is pressed");
            StartCoroutine(cameraShake.Shake(0.25f, 0.4f));
        }
	}
}
