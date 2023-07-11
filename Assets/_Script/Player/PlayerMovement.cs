using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    private void Update()
    {
        this.Moving();
    }

    void Moving()
    {
        this.MovingUp();
    }

    void MovingUp()
    {
        if (!InputManager.Instance.PressSpace) return;
        PlayerCtrl.Instance.Rigidbody2D.velocity = Vector2.up * this._jumpForce;
    }    
}
