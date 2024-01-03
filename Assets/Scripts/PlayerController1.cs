using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public int targetFrameRate = 60;
    
    private CharacterController controller;
    private void Start()
    {
        Application.targetFrameRate = targetFrameRate;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        
    }
}