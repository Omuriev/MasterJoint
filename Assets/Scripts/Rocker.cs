using UnityEngine;

public class Rocker : MonoBehaviour
{
    [SerializeField] private HingeJoint _joint;
    [SerializeField] private float _motorSpeed = 15f;
    [SerializeField] private float _motorForce = -15f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            JointMotor motor = _joint.motor;
            motor.force = _motorForce;
            motor.targetVelocity = _motorSpeed;
            _joint.motor = motor;

            _joint.useMotor = true;
        }
    }
}
