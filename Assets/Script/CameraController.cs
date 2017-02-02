using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    float speed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            transform.Translate(Input.GetAxis("Mouse X") * Time.deltaTime * speed, Input.GetAxis("Mouse Y") * Time.deltaTime * speed, 0);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.position = new Vector3(0, 1, -12.5f);
        }
    }
}
