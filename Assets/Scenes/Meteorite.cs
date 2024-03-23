using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public Transform target; // ���˹觷���ͧ��ô֧

    public float attractForce = 10f; // �����ç�ͧ��ô֧

    void Update()
    {
        if (target != null)
        {
            // �ӹǳ��ȷҧ����ͧ�������͹����
            Vector3 direction = target.position - transform.position;
            direction.Normalize(); // �������������ҡѺ 1

            // �ӹǳ�ç�֧�ٴ
            Vector3 attractForceVector = direction * attractForce * Time.deltaTime;

            // ����͹������Фô����ç�֧�ٴ
            transform.position += attractForceVector;
        }
    }
}