using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace DefaultNamespace
{
    public class CameraFollow : MonoBehaviour
    {
        public float yPosition = 2.5f;
        public float zPosition = -5.5f;-------------


        private void LateUpdate()
        {
            GameObject player = GameObject.Find("Player");
            if (player == null)
            {
                return;
            }
            Vector3 target = player.transform.position + new Vector3(0, yPosition, zPosition);
            transform.position = target;
        }
    }
}