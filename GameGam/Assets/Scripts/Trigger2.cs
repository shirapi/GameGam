using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour {

    [SerializeField] private GameObject[] targets;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (targets == null) return;
        foreach (GameObject tgt in targets)
        {
            if (other.gameObject == tgt) this.Action();
        }
    }

    protected virtual void Action() { }
}
