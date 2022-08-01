using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWindmill : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float ReturnTime;
    private float Speed = 4.5f;
    private Vector3 moveForward;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        moveForward = gameObject.transform.forward;

    }

    // Update is called once per frame
    void Update()
    {
        ReturnTime += Time.deltaTime;
        _rigidbody.velocity = moveForward * Speed;

        if (ReturnTime >= 5f)
        {
            Speed *= -1;
            ReturnTime = 0f;
        }
    }
}
