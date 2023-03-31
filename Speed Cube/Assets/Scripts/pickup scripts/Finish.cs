using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : Pickups
{
    public override void PickupEffect(GameObject playerObject)
    {
        //go to next level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
        base.PickupEffect(playerObject);
    }
}
