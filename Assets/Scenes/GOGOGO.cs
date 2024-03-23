using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOGOGO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { }
    public float moveSpeed = 5f; // ความเร็วในการเคลื่อนที่

    void Update()
    {
        // เคลื่อนที่ไปข้างหน้า (ลำดับการทำงานคือ W ถ้ากด A หรือ D จะเลื่อนไปข้างหน้าได้เช่นกัน)
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);

        // เคลื่อนที่ไปด้านข้าง (ซ้าย-ขวา)
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}