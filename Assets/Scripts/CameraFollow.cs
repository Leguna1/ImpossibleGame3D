using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace DefaultNamespace
{
    public class CameraFollow : MonoBehaviour
    {
        private void LateUpdate()
        {
            GameObject player = GameObject.Find("Player");
            Vector3 target = player.transform.position + new Vector3(0, 2.59214f, -5.5603f);
            transform.position = target;
        }
    }
}