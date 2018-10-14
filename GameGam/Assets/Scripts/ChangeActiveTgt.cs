using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeActiveTgt : TargetScript {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    override public void Action()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
}
