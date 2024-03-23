using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        // ตรวจตัวละครชนกับประตูชนะ
        if (other.CompareTag("WinDoor") || other.CompareTag("CoinCounter"))
        {
            
        }
        // ตรวจสอบว่าตัวละครชนกับอุปสรรคหรือไม่
        else if (other.CompareTag("Obstacle"))
        {
            // โหลดซีนหน้าเกมแพ้
            SceneManager.LoadScene("LoseScene");
        }
    }
}
