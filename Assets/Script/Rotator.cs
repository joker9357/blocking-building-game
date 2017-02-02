using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    Rigidbody rig;
    public Transform visualModel;
    public float force;
    float curFloat;

    float targetFloat;
    void Start()
    {

        rig = GetComponent<Rigidbody>();


    }
    void FixedUpdate()
    {
        SimulateAxis();
        visualModel.Rotate(curFloat * 20, 0, 0);
        rig.AddForce(Vector3.up * force * curFloat);

    }


    void SimulateAxis()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            targetFloat = 1;

        }
        else
        {

            targetFloat = 0;


        }

        curFloat = Mathf.MoveTowards(curFloat, targetFloat, Time.deltaTime * 5);
    }
}
