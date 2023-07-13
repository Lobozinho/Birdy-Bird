using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDespawn : LoboMonoBehaviour
{
    
    private void FixedUpdate()
    {
        this.PipeDespawning();
    }

    void PipeDespawning()
    {
        if (transform.parent.position.x > -3.5f) return;
        SpawnerCtrl.Instance.PipeSpawner.Despawn(transform.parent);
    }

}
