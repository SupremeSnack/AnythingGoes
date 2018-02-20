using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InRangeForInteraction : MonoBehaviour {

    public Camera playerCam;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButtonDown(0))
        {
            Interact();
        }
    }

    void Interact()
    {
        RaycastHit faceHit;
        Debug.DrawRay(playerCam.transform.position, playerCam.transform.forward, Color.red, 2f);
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out faceHit, 2f))
        {
            Debug.Log("success"); //här ska dialog-ui visas
        }
    }
        
    
}
