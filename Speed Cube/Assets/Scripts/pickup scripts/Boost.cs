using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Boost : Pickups
{
    [SerializeField]
    private float boostMultiplier = 1.5f;

    // POLYMORPHISM
    public override void PickupEffect(GameObject playerObject)
    {
        //increase player max speed
        playerObject.GetComponent<Square>().maxSpeed *= boostMultiplier;
        
        base.PickupEffect(playerObject);
    }
}
