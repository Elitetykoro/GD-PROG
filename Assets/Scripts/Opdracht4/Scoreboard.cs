using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

    public class Scoreboard : MonoBehaviour
{
    private int score = 0;
    private TMP_Text textField;
    private void Start()
    {
        textField = GetComponent<TMP_Text>();
        Pickup.OnPickup += GetPickupPoints;  
    }
    private void GetPickupPoints()
    {             
        score += 50;
        textField.text = "Score : " + score;
    }
}
