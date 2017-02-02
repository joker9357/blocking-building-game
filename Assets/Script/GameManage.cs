using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameManage : MonoBehaviour
{
    List<Transform> PartList = new List<Transform>();
    bool PlayMode = false;
    GameObject PartToPlace;
    GameObject PrefabPart = null;
    Vector3 Position= new Vector3(0, -2000, 0);
    public Transform BaseCube;
    Transform Attachment;
    FixedJoint joint;
    Quaternion rot;
    // Use this for initialization
    void Start()
    {
        PartList.Add(BaseCube);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayMode == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                EnablePlayMode();
            }
            PlaceThePart();
        }
        else
        {
            if (PartToPlace)
            {
                Destroy(PartToPlace);
                PartToPlace = null;
            }
        }

    }
    void PlaceThePart()
    {
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("press keypad");
            if (PartToPlace)
            {
                Destroy(PartToPlace);
            }
            PrefabPart = GameObject.Find("Part Block");
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            if (PartToPlace)
            {
                Destroy(PartToPlace);
            }
            PrefabPart = GameObject.Find("Part Wheel");
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            if (PartToPlace)
            {
                Destroy(PartToPlace);
            }
            PrefabPart = GameObject.Find("Part Cross");
        }

        if (!PartToPlace)
        {
            if (PrefabPart)
            {
                PartToPlace = Instantiate(PrefabPart, new Vector3(0,-2000,0), new Quaternion(0,0,0,0)) as GameObject;
                //Debug.Log(PartToPlace.transform.position);
            }
        }
        else
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                //PartToPlace.transform.rotation = new Quaternion(0, 0, 0, 0);
                CheckHit(hit);
            }
            PartToPlace.transform.position = Position;
            PartToPlace.transform.rotation = rot;
            if (Input.GetMouseButtonDown(0))
            {
                joint = PartToPlace.GetComponent<FixedJoint>();
                joint.connectedBody = Attachment.GetComponent<Rigidbody>();
                if (PrefabPart.transform.name == "Part Block")
                {
                    PartToPlace.transform.tag = "Block";
                }
                if (PrefabPart.transform.name == "Part Wheel")
                {
                    WheelController wheelcontro = PartToPlace.GetComponentInChildren<WheelController>();

                    wheelcontro.SetDir(PartToPlace.transform);
                }
                PartToPlace.AddComponent<FindEdge>();
                PartList.Add(PartToPlace.transform);
                
                PartToPlace = null;
            }
            
        }

    }

    void CheckHit(RaycastHit hit)
    {
        Renderer hitrenderer;
        if (hit.transform.tag=="Block")
        {
            Position = hit.transform.position + hit.normal;// +new Vector3(0,0.5f,0);
            Attachment = hit.transform;
            if (hit.transform.GetComponent<MeshRenderer>())
            {
                hitrenderer = hit.transform.GetComponent<MeshRenderer>();
            }
            else
            {
                hitrenderer = hit.transform.GetComponentInChildren<MeshRenderer>();
            }

            Vector3 dir = hitrenderer.bounds.center - Position;
            dir.Normalize();

            rot = Quaternion.LookRotation(dir);
            PartToPlace.transform.rotation = rot;

            //Debug.Log(hit.transform.name);

        }

    }

    public void EnablePlayMode()
    {
        for (int i = 0; i < PartList.Count; i++)
        {
            if (PartList[i] != null)
            {
                PartList[i].GetComponent<Rigidbody>().isKinematic = false;
            }
        }
        PlayMode = true;
    }

    //public void DisablePlayMode()
    //{
    //    BaseCube.transform.position = new Vector3(0, 0, 0);
    //    BaseCube.transform.rotation = new Quaternion(0, 0, 0,0);
    //    BaseCube.GetComponent<Rigidbody>().isKinematic = true;
    //    //for (int i = 0; i < PartList.Count; i++)
    //    //{
    //    //    if (PartList[i] != null)
    //    //    {
    //    //        PartList[i].GetComponent<Rigidbody>().isKinematic = true;
    //    //    }
    //    //}
        
    //    PlayMode = false;
    //}
}
