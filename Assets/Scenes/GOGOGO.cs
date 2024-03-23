using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GOGOGO : MonoBehaviour
{
    private Vector3 PlayerMovement;
    private Vector2 MouseInput;
    private float xRot;
    [SerializeField] private Rigidbody rb;

    [SerializeField] private float Speed; 

    void Update()
    {
        PlayerMovement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MovePlayer();

    }

    private void MovePlayer() 
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovement) * Speed; 
        rb.velocity = new Vector3(MoveVector.x, rb.velocity.y, MoveVector.z);

  
    }

}

