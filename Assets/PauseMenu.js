#pragma strict

var showGUI : boolean = false;
var canvas : GameObject;

function Start () {
canvas = GameObject.Find("Canvas");

}

function Update () {

if (Input.GetKeyDown(KeyCode.Escape)){
showGUI = !showGUI;
}

if(showGUI == true) {
canvas.SetActive(true);
Time.timeScale = 0;
}else {
canvas.SetActive(false);
Time.timeScale = 1 ;
}
}