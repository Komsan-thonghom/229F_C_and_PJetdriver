using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOGOGO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { }
    public float moveSpeed = 5f; // ��������㹡������͹���

    void Update()
    {
        // ����͹���仢�ҧ˹�� (�ӴѺ��÷ӧҹ��� W ��ҡ� A ���� D ������͹仢�ҧ˹�����蹡ѹ)
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);

        // ����͹���仴�ҹ��ҧ (����-���)
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}