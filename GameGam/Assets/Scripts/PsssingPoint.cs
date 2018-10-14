using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsssingPoint : Trigger2 {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    protected override void Action()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);
        Destroy(this.transform.GetChild(1).gameObject);
        //this.transform.GetChild(1).gameObject.SetActive(false);
        //Utility.DelayMethod(1.0f, () => Destroy(this.gameObject));
    }
}
