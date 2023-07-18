using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int _score = 0;

    public void AddScore()
    {
        this._score++;
    }    
}
