using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public Transform JumpingStartVector3;
    public Transform JumpingEndVector3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distanceVector = JumpingStartVector3.position - JumpingEndVector3.position;
        Vector3.Dot(transform.right, distanceVector.normalized);

    }
}
