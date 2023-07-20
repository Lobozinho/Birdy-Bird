using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementTest : MonoBehaviour
{
    [SerializeField] private bool _isMovingUp = true;
    [SerializeField] private bool _isMovingDown = false;


    private void FixedUpdate()
    {
        this.PipeMoving();
    }

    void PipeMoving()
    {
        this.MovingVertical();
        this.MovingLeft();
    }

    void MovingVertical()
    {
        this.MovingUp();
        this.MovingDown();
    }

    void MovingUp()
    {
        if (!this._isMovingUp) return;

        if (transform.parent.position.y > 1)
        {
            this._isMovingUp = false;
            this._isMovingDown = true;
            return;
        }

        transform.parent.position += Vector3.up * Time.deltaTime;
    }

    void MovingDown()
    {
        if (!this._isMovingDown) return;

        if (transform.parent.position.y < -2)
        {
            this._isMovingUp = true;
            this._isMovingDown = false;
            return;
        }

        transform.parent.position += Vector3.down * Time.deltaTime;
    }

    void MovingLeft()
    {

    }
}
