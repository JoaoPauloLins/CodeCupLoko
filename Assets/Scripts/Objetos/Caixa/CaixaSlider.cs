﻿using UnityEngine;
using System.Collections;

public class CaixaSlider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Personagem") // || col.gameObject.tag == "Caixa"
        {
            col.gameObject.transform.parent = gameObject.transform;
            //gameObject.transform.SetParent(col.gameObject.transform);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Personagem") // || col.gameObject.tag == "Caixa"
        {
            //gameObject.transform.SetParent(null);
            col.gameObject.transform.parent = null;
        }
    }
}
