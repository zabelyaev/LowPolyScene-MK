using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            GetComponent<Animator>().SetTrigger("Open");
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject, 0.25f);
        }
    }
}
