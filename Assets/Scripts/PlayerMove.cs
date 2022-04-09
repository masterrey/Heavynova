using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public CharacterController characterController;
    public float speed = 2;
    Vector3 move;
    void Start()
    {
        
    }

    // Update is called once per frames
    void Update()
    {
         move = new Vector3(Input.GetAxis("Horizontal"),
                                    0,
                                    Input.GetAxis("Vertical"));
        characterController.SimpleMove(move * speed);
    }

    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
            Vector3 dir = hit.point - transform.position;
            dir = new Vector3(dir.x, 0, dir.z);
            transform.forward = dir;
        }
    }
}
