using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflector : Pickups
{
    public override void PickupEffect(GameObject playerObject)
    {
        //increase player max speed
        playerObject.GetComponent<Square>().momentum *= -1f;

        base.PickupEffect(playerObject);
    }
}
