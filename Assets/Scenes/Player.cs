using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        // ��Ǩ����Фê��Ѻ��е٪��
        if (other.CompareTag("WinDoor") || other.CompareTag("CoinCounter"))
        {
            
        }
        // ��Ǩ�ͺ��ҵ���Фê��Ѻ�ػ��ä�������
        else if (other.CompareTag("Obstacle"))
        {
            // ��Ŵ�չ˹������
            SceneManager.LoadScene("LoseScene");
        }
    }
}
