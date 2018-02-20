using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnflinchingGaze : MonoBehaviour {

    private GameObject target;

	// Use this for initialization
	void Start () {
        if (target == null)
            target = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (target != null)
        {
            Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);

            transform.LookAt(targetPosition);
        }
	}
}
