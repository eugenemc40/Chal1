using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;//variable object plane
    private Vector3 offset = new Vector3(30, 0, 10); //variable movement ofset

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //movement of the camera is as the plane moves ensureing its always in frame
        transform.position = plane.transform.position + offset;
    }
}
