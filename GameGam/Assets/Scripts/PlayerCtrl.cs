using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

    [SerializeField] private float maxSpeed;
    [SerializeField] private float Accelerate;
    [SerializeField] private float Decelerate;

    private float speed = 0;

    private bool IsBraking = false;

    void Start () {
	}
	
	void Update () {

        this.transform.Rotate(new Vector3(0.0f, -Input.gyro.rotationRateUnbiased.z, 0.0f));

        if (this.IsBraking)
        {
            this.speed -= Decelerate;
            if (this.speed < 0) this.speed = 0;
        }
        else
        {
            this.speed += Accelerate;
            if (this.speed > this.maxSpeed) this.speed = this.maxSpeed;
        }

        this.transform.Translate(this.transform.forward * speed * Time.deltaTime);
    }


    public void ApplyTheBrake()
    {
        IsBraking = true;
    }

    public void ReleaseTheBrake()
    {
        IsBraking = false;
    }
}
