using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class StartGameButton : MonoBehaviour
    {
        private static readonly int EmissionColor = Shader.PropertyToID("_EmissionColor");

        private void FixedUpdate()
        {
            transform.Rotate(1,1,1);
        }

        public void StartHover()
        {
            transform.localScale = Vector3.one * 1.1f;
        }
        public void EndHover()
        {
            transform.localScale = Vector3.one;
        }

        public void ClickStart()
        {
            MeshRenderer mr =GetComponent<MeshRenderer>();
            mr.material.SetColor(EmissionColor, Color.white);
        }

        public void ClickEnd()
        {
            MeshRenderer mr =GetComponent<MeshRenderer>();
            mr.material.SetColor(EmissionColor, Color.green);
        }

        public void Click()
        {
            SceneManager.LoadScene("GameScene");
        }
    }
    
}