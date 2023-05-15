using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
     [SerializeField]Vector3 offset;
    private void LateUpdate()
    {/*
        Vector3 newpos = new Vector3(0, 0, target.position.z) + offset;
        newpos= transform.position;
        transform.position= newpos;
    */
        Vector3 newpo= target.position + offset;
        newpo.y = transform.position.y;
        transform.position = newpo;// - new Vector3(0,0,-1);

    }

}
