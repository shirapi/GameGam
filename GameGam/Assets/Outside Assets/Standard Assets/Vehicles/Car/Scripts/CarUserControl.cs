using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : TargetScript
    {
        private CarController m_Car; // the car controller we want to use
        private bool IsBraking = false;
        private float handle = 0.0f;
        [SerializeField] private float force;

        Rigidbody rig;
        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            Input.gyro.enabled = true;
        }

        void Start()
        {
            rig = this.GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            // pass the input to the car!
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //float v = CrossPlatformInputManager.GetAxis("Vertical");
            float footbrake = 0.0f;
            float handbrake = 0.0f;
            float v = 1.0f;

            Quaternion gy = Input.gyro.attitude;
            handle = -(new Quaternion(-gy.x, -gy.z, -gy.y, gy.w)
                * Quaternion.Euler(90f, 0f, 0f)).ToEulerAngles().z
                * 0.2f;

            if (this.IsBraking)
            {
                //footbrake = 1.0f;
                handbrake = 1.0f;
                v = -1.0f;
            }


            m_Car.Move(handle, v, footbrake, handbrake);
        }
        public void ApplyTheBrake()
        {
            IsBraking = true;
        }

        public void ReleaseTheBrake()
        {
            IsBraking = false;
        }

        public override void Action()
        {
            rig.AddForce(force * this.transform.forward);
        }
    }
}
