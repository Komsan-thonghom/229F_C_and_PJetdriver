using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ore : MonoBehaviour
{
    private int Ores = 0;
    public TextMeshProUGUI Oretext;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Ore")
        {
            Ores++;
            Oretext.text = "Ores: " + Ores.ToString();
            Debug.Log(Ores);
            Destroy(other.gameObject);
        }
    }
}
