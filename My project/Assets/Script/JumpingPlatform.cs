using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingPlatform : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float num;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        num += 3f;
        _rigidbody.MoveRotation(Quaternion.Euler(0f, 0f, num));      
    }

}
