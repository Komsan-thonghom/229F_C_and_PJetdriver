using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public Transform target; // ตำแหน่งที่ต้องการดึง

    public float attractForce = 10f; // ความแรงของการดึง

    void Update()
    {
        if (target != null)
        {
            // คำนวณทิศทางที่ต้องการเคลื่อนที่ไป
            Vector3 direction = target.position - transform.position;
            direction.Normalize(); // ทำให้ความยาวเท่ากับ 1

            // คำนวณแรงดึงดูด
            Vector3 attractForceVector = direction * attractForce * Time.deltaTime;

            // เคลื่อนที่ตัวละครด้วยแรงดึงดูด
            transform.position += attractForceVector;
        }
    }
}