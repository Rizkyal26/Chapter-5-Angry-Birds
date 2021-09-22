using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Bird;

public class YellowBird : Bird
{
    [SerializeField] public float _boostForce = 100;
    [SerializeField] public bool _hasBoost = false;


    public void Boost()
    {
        if (State == BirdState.Thrown && !_hasBoost)
        {
            RigidBody.AddForce(RigidBody.velocity * _boostForce);
            _hasBoost = true;
        }
    }

    public override void OnTap()
    {
        Boost();
    }
}
