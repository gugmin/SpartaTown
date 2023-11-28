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
        Vector2 moveInput = value.Get<Vector2>().normalized;

        if (moveInput == Vector2.up)
        {

        }
        else if (moveInput == Vector2.down)
        {

        }
        else if (moveInput == Vector2.left)
        {

        }
        else if (moveInput == Vector2.right)
        {

        }
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
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