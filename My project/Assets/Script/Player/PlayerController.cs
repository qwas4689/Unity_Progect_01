using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool isInput = true;

    public PlayerInput _playerInput { get; private set; }

    public PlayerMovement _playerMovement { get; private set; }


    void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (isInput)
        {
            _playerInput.UpdateComponent(this);
        }
    }

    void FixedUpdate()
    {
        _playerMovement.UpdateComponent(this);
    }

}
