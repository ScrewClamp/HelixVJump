using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Player player;
    public Vector3 PlatformToCameraOffSet;
    public float Speed;
    void Update()
    {
        if (player.CurrentPlatform == null) return;

        Vector3 targetPosition = player.CurrentPlatform.transform.position + PlatformToCameraOffSet;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
    }
}
