using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawner : LoboMonoBehaviour
{
    [SerializeField] protected float offsetDespawn;
    protected virtual void FixedUpdate()
    {
        this.Despawning();
    }

    protected virtual void Despawning()
    {
        float PlayerPosX = PlayerCtrl.Instance.transform.position.x;
        if (PlayerPosX - transform.parent.position.x < this.offsetDespawn) return;
        this.Despawn();
    }

    protected abstract void Despawn();
    
}
