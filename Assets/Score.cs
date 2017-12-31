using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour { 

 public int Coins = 0;
 public GUISkin LabelSkin;

 // Use this for initialization
 void Start () {

 }

 // Update is called once per frame
 void Update () {

 }

 void OnGUI()
 {
  GUI.skin = LabelSkin;
  GUI.Label(new Rect(10, 5, 1000, 100), "Cadeaux : " + Coins + "/5");
 }
}﻿