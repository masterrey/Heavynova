using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public CharacterController characterController;
   
    void Start()
    {
        
    }

    // Update is called once per frames
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),
                                    0,
                                    Input.GetAxis("Vertical"));
        characterController.SimpleMove(move);
    }
}
