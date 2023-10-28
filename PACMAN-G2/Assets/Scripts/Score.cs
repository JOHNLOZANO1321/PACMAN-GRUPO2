using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int Puntaje = 9;
    public TMP_Text scoreT;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Puntos"))
        {
            Destroy(other.gameObject);
            Puntaje++;
            scoreT.text = "Score: " + Puntaje;
        }
    }


}
