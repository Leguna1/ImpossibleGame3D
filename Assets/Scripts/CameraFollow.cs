using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CameraFollow : MonoBehaviour
    {
        private void LateUpdate()
        {
            GameObject player = GameObject.Find("Player");
            Vector3 target = player.transform.position + new Vector3(0, 2.6f, -49f);
            transform.position = target;
        }
    }
}