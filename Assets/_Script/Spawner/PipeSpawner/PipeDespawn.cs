using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDespawn : LoboMonoBehaviour
{
    [SerializeField] private float _offsetDespawn = 3f;
    private void FixedUpdate()
    {
        this.PipeDespawning();
    }

    void PipeDespawning()
    {
        float PlayerPosX = PlayerCtrl.Instance.transform.position.x;
        if (PlayerPosX - transform.parent.position.x < this._offsetDespawn) return;
        SpawnerCtrl.Instance.PipeSpawner.Despawn(transform.parent);
    }

}
