using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J : MonoBehaviour
{

    private Rigidbody rb;

    [SerializeField] private float forwardSpeed;
    [SerializeField] private float leftRightSpeed;
    [SerializeField] private Vector2 minMaxX;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minMaxX.x, minMaxX.y), transform.position.y, transform.position.z);
    }
}


