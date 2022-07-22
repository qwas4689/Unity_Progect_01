using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _playerInput;
    private Rigidbody _rigidbody;

    private float MoveSpeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float XSpeed = _playerInput.Rotate * MoveSpeed;
        float ZSpeed = _playerInput.Move * MoveSpeed;

        _rigidbody.velocity = new Vector3(XSpeed, 0f, ZSpeed).normalized;
    }
}
