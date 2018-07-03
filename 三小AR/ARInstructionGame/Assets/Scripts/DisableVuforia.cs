using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DisableVuforia : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<VuforiaBehaviour>().enabled)
        {
            GetComponent<VuforiaBehaviour>().enabled = false;
        }

        if (GetComponent<VideoBackgroundBehaviour>().enabled)
        {
            GetComponent<VideoBackgroundBehaviour>().enabled = false;
        }

        GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
    }

}
