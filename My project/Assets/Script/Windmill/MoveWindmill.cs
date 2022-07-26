using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWindmill : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float ReturnTime;
    private float Speed = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ReturnTime += Time.deltaTime;
        _rigidbody.velocity = new Vector3(0f, 0f, Speed);

        if (ReturnTime >= 3f)
        {
            Speed *= -1;
            ReturnTime = 0f;
        }
    }
}
