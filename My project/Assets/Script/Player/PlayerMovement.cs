using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IComponent<PlayerController>
{
    private Rigidbody _rigidbody;
    

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void UpdateComponent(PlayerController owner)
    {
        move(owner);
    }

    private void move(PlayerController owner)
    {
        Vector3 newVelocity = owner._playerInput.MoveVelocity;
        float moveSpeed = 6f;

        if (newVelocity != Vector3.zero)
        {
            LookAt(newVelocity);
        }

        _rigidbody.velocity = newVelocity * moveSpeed;
    }

    private void LookAt(Vector3 direction)
    {
        Quaternion targetAngle = Quaternion.LookRotation(direction);
        _rigidbody.rotation = targetAngle;

    }
}
