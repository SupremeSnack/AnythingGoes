using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainStopDeleter : MonoBehaviour {

    private GameObject you;

    private float dist;

    // Use this for initialization
    void Start()
    {
        you = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, you.transform.position);
        if (dist >= 150)
        {
            Destroy(gameObject);
        }
    }
}
