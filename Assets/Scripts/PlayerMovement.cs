using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float Speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))                 //Walk Forward
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.A))                //Strafe Left
        {
            transform.Translate(Vector3.left * Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.S))                //Walk Backwards
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.D))                //Strafe Right
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }
    }
}
