using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// INHERITANCE
public class Finish : Pickups
{

    // POLYMORPHISM
    public override void PickupEffect(GameObject playerObject)
    {
        //go to next level
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (SceneManager.sceneCountInBuildSettings - 1 > currentSceneIndex)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }       
    }
}
