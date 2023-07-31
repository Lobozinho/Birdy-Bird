using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdList : LoboMonoBehaviour
{
    [SerializeField] private List<Transform> _birds;

    [SerializeField] private int _birdCount = 0;
    public int BirdCount => _birdCount;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBirds();
    }

    void LoadBirds()
    {
        if (this._birds.Count > 0) return;
        
        foreach(Transform bird in transform)
        {
            this._birds.Add(bird);
            bird.gameObject.SetActive(false);
        }

        this._birds[this._birdCount].gameObject.SetActive(true);
    }

    public void NextBird()
    {
        this.ChangeActiveBird();
        this._birdCount++;
        if (this._birdCount >= this._birds.Count) this._birdCount = 0;
        this.ChangeActiveBird();
    }

    public void PreviousBird()
    {
        this.ChangeActiveBird();
        this._birdCount--;
        if (this._birdCount < 0) this._birdCount = this._birds.Count - 1;
        this.ChangeActiveBird();
    }

    void ChangeActiveBird()
    {
        bool activeSeft = this._birds[this._birdCount].gameObject.activeSelf;
        this._birds[this._birdCount].gameObject.SetActive(!activeSeft);
    }

}
