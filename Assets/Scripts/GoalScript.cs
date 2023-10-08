using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class GoalScript : MonoBehaviour
    {
        private IEnumerator OnCollisionEnter(Collision other)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("WinScene");
        }
    }
}