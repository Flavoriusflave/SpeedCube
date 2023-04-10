using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public abstract class Pickups : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PickupEffect(collision.gameObject);
        }
    }

    // ABSTRACTION
    public virtual void PickupEffect(GameObject playerObject)
    {
        gameObject.SetActive(false);
    }

}
