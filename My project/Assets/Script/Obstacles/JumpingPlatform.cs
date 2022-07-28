using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingPlatform : MonoBehaviour
{
    private Rigidbody _rigidbody;

    Vector3 _myVector3;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _myVector3 = new Vector3(0f, 10f, 0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(_myVector3 * Time.fixedDeltaTime);
        _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);      
    }

}
