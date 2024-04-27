using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour {
    //PlayerStateManager - Context Class, Use to pass DATA to each State

    private float dirX, dirY;
    private float _jumpStart;
    private Animator anim;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D rb;
    private bool isOnGround = false;
    private bool _hasFlip;
    private bool _hasStart;
    private bool _canJump;
    private bool _forceApply;



    public float GetDirX() { return dirX; }

    public float GetDirY() { return dirY; }

    public bool GetIsOnGround() { return isOnGround; }
    public bool CanJump { get => _canJump; }

    public Rigidbody2D GetRigidBody2D() { return rb; }

    public Animator GetAnimator() { return anim; }

    private void Awake() {

        GetReferenceComponents();
    }

    private void GetReferenceComponents()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

      private void SetupProperties()
    {
        _state = idleState;
        _state.EnterState(this);
        rb.gravityScale = _playerStats.GravScale;
    }

    private void OnDestroy()
    {
        UnsubcribeAllEvents();
    }

     private void UnsubcribeAllEvents()
    {
        
        //Unsub mọi Events khi load lại scene tránh bị null ref từ event cũ
    }

}