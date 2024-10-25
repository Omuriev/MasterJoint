using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private Rigidbody _projectile;
    [SerializeField] private Transform _launchPoint;
    [SerializeField] private SpringJoint _springJoint;
    private float _springForce = 300f;

    private void Start()
    {
        Rigidbody newProjectile = Instantiate(_projectile, _launchPoint.position, _launchPoint.rotation);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchProjectile();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetCatapult();
        }
    }

    private void LaunchProjectile()
    {
        _springJoint.spring = _springForce;
    }

    private void ResetCatapult()
    {
        Rigidbody newProjectile = Instantiate(_projectile, _launchPoint.position, _launchPoint.rotation);
        _springJoint.spring = 0;
    }
}
