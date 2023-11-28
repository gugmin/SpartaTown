using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;
    Vector3 playerDir;
    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        //Debug.Log("dddddddddddddddddd" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
        anim.SetFloat("Speed", dir.normalized.megnitude);
        anim.ResetTrigger("Jump");
    }

    public void OnJump(InputValue value)
    {
        anim.SetTrigger("Jump");
    }

    public void OnLook(InputValue value)
    {
        // Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;
        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
        Debug.DrawRay(newAim, playerDir * 1.0f, Color.red);
        RaycastHit2D raycast = Physics2D.Raycast(newAim, playerDir * 1.0f);




    }

    public void OnFire(InputValue value)
    {
        //Debug.Log("OnFire" + value.ToString());
        IsAttacking = value.isPressed;
    }
}