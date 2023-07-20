using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    [SerializeField] private int _ramdomMove;

    private void OnEnable()
    {
        this._ramdomMove = Random.Range(0, 1);
    }

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
        if (this._ramdomMove == 0) return;
    }

    void MovingLeft()
    {
        if (this._ramdomMove == 1) return;
    }

}
