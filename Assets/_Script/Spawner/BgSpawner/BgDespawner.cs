using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgDespawner : Despawner
{
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.offsetDespawn *= 4;
    }

    protected override void Despawn()
    {
        SpawnerCtrl.Instance.BgSpawner.Despawn(transform.parent);
    }
}
