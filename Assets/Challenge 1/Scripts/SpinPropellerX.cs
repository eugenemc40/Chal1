using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public GameObject plane;//variable object propeller
    private float rotationSpeed=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate propeller
        plane.transform.RotateAroundLocal(Vector3.forward, rotationSpeed);
    }
}
