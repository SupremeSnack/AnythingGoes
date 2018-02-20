using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingFog : MonoBehaviour {

    private GameObject you;
//    private GameObject dirLight;

    private float dist;
    private float fogValue;
//    private float dirLightRotation;



	// Use this for initialization
	void Start () {
        you = GameObject.FindWithTag("Player");
//        dirLight = GameObject.FindWithTag("Light1");

    }
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(gameObject.transform.position, you.transform.position);

        if (dist < 400)
        {
            fogValue = 0.001f * (dist/4);
//            dirLightRotation = 0.4f * (dist / 4);
        }

        RenderSettings.fogDensity = fogValue;
        //Debug.Log("beep" + dist);
//        dirLight.transform.rotation = Quaternion.Euler(50 + dirLightRotation, -30, 0);
    }
}
