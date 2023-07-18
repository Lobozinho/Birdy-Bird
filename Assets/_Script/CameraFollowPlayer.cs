using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    private void Update()
    {
        this.Following();
    }

    void Following()
    {
        float playerPosX = PlayerCtrl.Instance.transform.position.x;
        transform.position = new Vector3(playerPosX, 0, -10);
    }

}
