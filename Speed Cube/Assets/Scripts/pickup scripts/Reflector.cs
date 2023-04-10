using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Reflector : Pickups
{
    [SerializeField]
    private bool Xreflect;
    [SerializeField]
    private bool Yreflect;

    // POLYMORPHISM
    public override void PickupEffect(GameObject playerObject)
    {
        //change player direction
        Vector2 playerMomentum = playerObject.GetComponent<Square>().momentum;
        if (Xreflect)
        {
            playerMomentum.x *= -1f;
        }
        if (Yreflect)
        {
            playerMomentum.y *= -1f;
        }

        playerObject.GetComponent<Square>().momentum = playerMomentum;


        base.PickupEffect(playerObject);
    }
}
