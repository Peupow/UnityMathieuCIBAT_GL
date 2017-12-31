using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour {

    private Score _score;

 // Use this for initialization
 void Start () {
        //Entre parenthèse de GetComponent le nom du component (ici le script avec pour nom Score)
        _score = GameObject.FindGameObjectWithTag("Player").GetComponent("Score") as Score;
 }
 
 // Update is called once per frame
 void Update () {
  
 }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _score.Coins += 1;
            Destroy(gameObject);
        }
    }
}﻿