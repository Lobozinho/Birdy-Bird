using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    [SerializeField] private int _ramdomMove = 0;

    [SerializeField] private bool _isMovingUp = true;
    [SerializeField] private bool _isMovingDown = false;

    private void OnEnable()
    {
        if (ManagersCtrl.Instance.LevelManager.GameLevel > 7)
        {
            this._ramdomMove = 2;
            return;
        }
        this._ramdomMove = Random.Range(0, 2);
    }

    private void FixedUpdate()
    {
        this.PipeMoving();
    }

    void PipeMoving()
    {
        if (ManagersCtrl.Instance.LevelManager.GameLevel < 6) return;
        this.MovingVertical();
        this.MovingLeft();
    }

    void MovingVertical()
    {
        if (this._ramdomMove == 0) return;
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

        transform.parent.position += Vector3.down * Time.fixedDeltaTime;
    }

    void MovingLeft()
    {
        if (this._ramdomMove == 1) return;
        transform.parent.position += Vector3.left * Time.fixedDeltaTime;
    }

}
