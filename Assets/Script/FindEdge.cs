using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FindEdge : MonoBehaviour {
    List<Vector3> direction = new List<Vector3>();
    List<Transform> EnabledPosition = new List<Transform>();
    List<Transform> DisabledPosition = new List<Transform>();
    Joint joint;
    public Renderer RenderToUse;
    public bool IfDebug;
    public GameObject DebugGameObject;
    [SerializeField]
    SelectDirections selectDirections;

    [System.Serializable]
    public class SelectDirections
    {
        public bool up;
        public bool down;
        public bool left;
        public bool right;
        public bool forward;
        public bool back;
    }
    // Use this for initialization
    void Start () {

        //Transform trans = RenderToUse.transform;

        //if (selectDirections.up)
        //{
        //    //Vector3 offset = trans.up;
        //    Vector3 boundaryoffset = new Vector3(0, RenderToUse.bounds.extents.y, 0);
        //    Vector3 FinalPosition = trans.position + boundaryoffset;
        //    //Debug.Log("up OK");
        //    direction.Add(FinalPosition);
        //}
        //if (selectDirections.down)
        //{
        //    Vector3 boundaryoffset = new Vector3(0, RenderToUse.bounds.extents.y, 0);
        //    Vector3 FinalPosition = trans.position - boundaryoffset;
        //    direction.Add(FinalPosition);
        //    //Debug.Log("down OK");
        //}
        //if (selectDirections.left)
        //{
        //    Vector3 boundaryoffset = new Vector3(RenderToUse.bounds.extents.x, 0, 0);
        //    Vector3 FinalPosition = trans.position - boundaryoffset;
        //    direction.Add(FinalPosition);
        //    //Debug.Log("left OK");
        //}
        //if (selectDirections.right)
        //{
        //    Vector3 boundaryoffset = new Vector3(RenderToUse.bounds.extents.x, 0, 0);
        //    Vector3 FinalPosition = trans.position + boundaryoffset;
        //    direction.Add(FinalPosition);
        //    //Debug.Log("right OK");
        //}
        //if (selectDirections.forward)
        //{
        //    Vector3 boundaryoffset = new Vector3(0, 0, RenderToUse.bounds.extents.z);
        //    Vector3 FinalPosition = trans.position - boundaryoffset;
        //    direction.Add(FinalPosition);
        //    //Debug.Log("forward OK");
        //}
        //if (selectDirections.back)
        //{
        //    Vector3 boundaryoffset = new Vector3(0, 0, RenderToUse.bounds.extents.z);
        //    Vector3 FinalPosition = trans.position + boundaryoffset;
        //    direction.Add(FinalPosition);
        //    //Debug.Log("back OK");
        //}




        //for (int i = 0; i < direction.Count; i++)
        //{
        //    GameObject obj;
        //    if (IfDebug)
        //    {
        //        obj = Instantiate(DebugGameObject, direction[i], Quaternion.identity) as GameObject;

        //    }else
        //    {
        //        obj = new GameObject();
        //        obj.transform.position = direction[i];
        //    }
        //    obj.transform.parent = transform;
        //    EnabledPosition.Add(obj.transform);

        //}



    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public Transform ReturnPostion(Vector3 hit)
    {
        Transform result=null;

        return result;
    }
}
