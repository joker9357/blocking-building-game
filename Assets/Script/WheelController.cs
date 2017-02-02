using UnityEngine;
using System.Collections;

public class WheelController : MonoBehaviour {
    WheelCollider wheelCollider;
    public Transform visualmodel;
    public float force;
    float curFloat;
    float dir=0;
    float targetFloat;
    
    void Start()
    {

        wheelCollider = GetComponent<WheelCollider>();
        visualmodel = gameObject.transform;



    }
    void FixedUpdate()
    {
        SimulateAxis();
        wheelCollider.motorTorque = curFloat* force*dir ;

    }

    public void SetDir(Transform transform)
    {
        if (transform.rotation.y > 0)
        {
            dir = 1;
        }
        else if (transform.rotation.y < 0)
        {
            dir = -1;
        }
        else
        {
            dir = 0;
        }
        Debug.Log(dir);
    }
    void SimulateAxis()
    {
        if (Input.GetKey(KeyCode.W))
        {
            targetFloat = 1;
        }
        else
        {
            if (Input.GetKey(KeyCode.S))
            {
                targetFloat = -1;
            }
            else
            {
                targetFloat = 0;
            }

        }

        curFloat = Mathf.MoveTowards(curFloat, targetFloat, Time.deltaTime * 5);
    }
}
