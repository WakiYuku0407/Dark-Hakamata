using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HItVanish : MonoBehaviour
{
    public string playertag;
    public AudioClip sound1;
    //AudioSource audioSource;


    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == playertag)
        {
            AudioSource.PlayClipAtPoint(sound1,transform.position,0.3f);
            Destroy(this.gameObject);
        }
    }

   
}
