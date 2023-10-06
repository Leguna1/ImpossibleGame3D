using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    IEnumerator OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player")) 
            Destroy(other.gameObject); 
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
        
    }
}