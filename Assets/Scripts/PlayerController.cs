using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 6.0f;
    public float jumpForce = 1f;

    private Rigidbody rb;

    private bool onGround = true;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked; //disables mouse ingame
	}

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;//makes movements more smooth?

        transform.Translate(straffe, 0, translation);

        RaycastHit hit;
        Vector3 physicsCentre = this.transform.position + this.GetComponent<CapsuleCollider>().center;//finds center of capsulecollider

        Debug.DrawRay(physicsCentre, Vector3.down, Color.red, 1.2f);//debug for showing the ray
        if (Physics.Raycast(physicsCentre, Vector3.down, out hit, 1.2f))//sends raycast from a availiable capsulecollider
        {
            if (hit.transform.gameObject.tag != "Player")//this ensures that the raycast does not register anything tagged with player
            {
                onGround = true;
            }
        }
        else
        {
            onGround = false;
        }
        //Debug.Log(onGround);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;//reenables mouse

        //Jumping:
        if (Input.GetKeyDown("space") && onGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
