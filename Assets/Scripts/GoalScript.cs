using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class GoalScript : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")) //Looks for game object with tag "Player".
            {
                SceneManager.LoadScene("WinScene");
            }
        }
    }
}