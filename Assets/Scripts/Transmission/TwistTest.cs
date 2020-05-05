﻿using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class TwistTest : Subscriber<Messages.Geometry.Twist>
    {
        public float CommandGain;
        public string WheelType;
        public float WheelRadius;
        public float WheelSeparation;
        private Vector3 linearVelocity;
        private Vector3 angularVelocity;
        private bool isMessageReceived;

        private HingeJoint hinge;
        private JointMotor motor;

        protected override void Start()
        {
            base.Start();
            hinge = GetComponent<HingeJoint>();
        }

        protected override void ReceiveMessage(Messages.Geometry.Twist message)
        {
            linearVelocity = ToVector3(message.linear).Ros2Unity();
            angularVelocity = -ToVector3(message.angular).Ros2Unity();
            isMessageReceived = true;
        }

        private static Vector3 ToVector3(Messages.Geometry.Vector3 geometryVector3)
        {
            return new Vector3(geometryVector3.x, geometryVector3.y, geometryVector3.z);
        }

        private void Update()
        {
            if (isMessageReceived)
                ProcessMessage();
        }
        private void ProcessMessage()
        {
            // Debug.Log(linearVelocity);
            // Debug.Log(angularVelocity);
            motor = hinge.motor;
            if (WheelType == "Left")
            {
                motor.targetVelocity = (2*linearVelocity[2]*CommandGain + WheelSeparation*angularVelocity[1]*CommandGain)/2;
            }
            else if (WheelType == "Right")
            {
                motor.targetVelocity = (2*linearVelocity[2]*CommandGain - WheelSeparation*angularVelocity[1]*CommandGain)/2;
            }
            else{
                motor.targetVelocity = 0;
            }
            motor.force = 10000000000000;
            motor.freeSpin = false;
            hinge.motor = motor;
            hinge.useMotor = true;

            isMessageReceived = false;
        }
    }
}