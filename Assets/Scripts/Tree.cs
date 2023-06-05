using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    int hp = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Axe"))
        {
            hp = hp - 1;

            AudioSource destroySound = GetComponent<AudioSource>();
            destroySound.Play();

            if (hp == 0)
            {
                Destroy(gameObject, destroySound.clip.length);
            }
        }
    }
}
