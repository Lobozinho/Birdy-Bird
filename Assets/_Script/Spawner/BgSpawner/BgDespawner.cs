using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgDespawner : LoboMonoBehaviour
{
    [SerializeField] private float _offsetDespawn = 9f;

    private void FixedUpdate()
    {
        this.BgDespawning();
    }

    void BgDespawning()
    {
        float PlayerPosX = PlayerCtrl.Instance.transform.position.x;
        if (PlayerPosX - transform.parent.position.x < this._offsetDespawn) return;
        SpawnerCtrl.Instance.PipeSpawner.Despawn(transform.parent);
    }
}
