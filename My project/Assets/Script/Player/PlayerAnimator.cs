using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour, IComponent<PlayerController>
{
    public int moveAnimation { get; private set; }
    private Animator _animator;
    private float _moveAnimationPlaySpeed = 0.9f;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _moveAnimationPlaySpeed = PlayerAnimID.Run;
    }

    public void UpdateComponent(PlayerController owner)
    {
        move(owner);
    }

    public void move(PlayerController owner)
    {
        float run = (owner._playerInput.MoveVelocity != Vector3.zero) ? _moveAnimationPlaySpeed : 0f;
        _animator.SetFloat(moveAnimation, run);
    }
}
