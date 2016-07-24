﻿using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    public bool isPressed;
    public bool isPressedByPlayer;
    public bool isPressedByBox;

	// Use this for initialization
	void Start () {
        isPressedByPlayer = false;
        isPressedByBox = false;
        isPressed = false;
	}
	
	// Update is called once per frame
	void Update () {
        isPressed = (isPressedByPlayer || isPressedByBox);
	}

    public void playerIn(){
        isPressedByPlayer = true;
    }

    public void playerOut(){
        isPressedByPlayer = false;
    }

    public void boxIn(){
        isPressedByBox = true;
    }

    public void boxOut() {
        isPressedByBox = false;
    }

    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Personagem")
            isPressedByPlayer = true;

        if (col.gameObject.tag == "Caixa")
            isPressedByBox = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Personagem")
            isPressedByPlayer = false;

        if (col.gameObject.tag == "Caixa")
            isPressedByBox = false;
    }

    public void resetButton()
    {
        isPressedByBox = false;
        isPressedByPlayer = false;
        isPressed = false;
    }
}
