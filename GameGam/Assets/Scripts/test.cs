using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    GameObject a;

    void Start () {
        if (SystemInfo.supportsVibration) Debug.Log("振動対応");
        else Debug.Log("振動非対応");

        Input.gyro.enabled = true;

        a = GameObject.Find("a");
    }
	
	void Update () {
        //Vibration.Vibrate();

        Quaternion q = Input.gyro.attitude;
        Quaternion qq = Quaternion.AngleAxis(-90.0f, Vector3.left);
        q.x *= -1.0f;
        q.y *= -1.0f;
        a.transform.localRotation = qq * q;
    }

    private void OnDestroy()
    {
    }
}
