using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _playerInput;
    private Rigidbody _rigidbody;
    private Animator _animator;


    private float MoveSpeed = 6f;

    private bool isRollCoolTimeOn;
    private bool isJump;
    private bool isRoll;

    public Vector3 MoveVelocity { get; private set; }

    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponentInChildren<Animator>();
    }

    void FixedUpdate()
    {
        run();
    }

    void Update()
    {
        jump();
        roll();
        
    }

    private void run()
    {
        MoveVelocity = new Vector3(_playerInput.Xmoving, 0f, _playerInput.Zmoving).normalized;

        if (_playerInput.Runing)
            transform.position += MoveVelocity * MoveSpeed * Time.deltaTime;
        else
            transform.position += MoveVelocity * MoveSpeed * 0.4f * Time.deltaTime;

        transform.LookAt(transform.position + MoveVelocity);

        runAin();
    }

    private void runAin()
    {
        _animator.SetBool(PlayerAnimID.Walk, MoveVelocity != Vector3.zero);
        _animator.SetBool(PlayerAnimID.Run, _playerInput.Runing);
    }

    private void jump()
    {
        if (_playerInput.Jumping && !isJump && !isRoll)
        {
            _rigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            jumpAni();
            isJump = true;
        }
    }

    private void jumpAni()
    {
        _animator.SetBool(PlayerAnimID.Jump, true);
        _animator.SetTrigger(PlayerAnimID.DoJump);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            _animator.SetBool(PlayerAnimID.Jump, false);
            isJump = false;
            isRoll = false;
        }
    }

    private void roll()
    {
        if (_playerInput.Rolling && !isRollCoolTimeOn && !isJump && !isRoll)
        {
            MoveSpeed *= 2;
            _animator.SetTrigger(PlayerAnimID.DoRoll);
            _rigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            isRollCoolTimeOn = true;
            isRoll = true;

            Invoke("rollOut", 7f);
        }
    }

    private void rollOut()
    {
        MoveSpeed *= 0.5f;
        isRollCoolTimeOn = false;
    }
}
