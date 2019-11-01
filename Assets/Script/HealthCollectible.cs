using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubiController controller = other.GetComponent<RubiController>();

        if (controller != null)
        {
            if(controller.Health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }
        }
    }
}
