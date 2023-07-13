using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    void Update()
    {
        this.Moving();
    }

    void Moving()
    {
        transform.position += Vector3.left * this._speed * Time.deltaTime;
    }    

}
