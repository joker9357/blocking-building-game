using UnityEngine;
using System.Collections;

public class Pivot : MonoBehaviour {
    float rotspeed = -5f;
   
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        float rotX = Input.GetAxis("Mouse X") * rotspeed;
        float rotY = Input.GetAxis("Mouse Y") * rotspeed;
        if (Input.GetMouseButton(1))
        {
            transform.Rotate(Vector3.up, -rotX);
            transform.Rotate(Vector3.right, -rotY);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
	}
}
