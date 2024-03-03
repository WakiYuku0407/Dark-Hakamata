using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_HItCheck : MonoBehaviour
{
    public string tagName;
    public string sceneNmae = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == tagName)
        {
            if (sceneNmae != "")
            {
                SceneManager.LoadScene(sceneNmae);
            }
            else
            {
                int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
                if (nextIndex < SceneManager.sceneCountInBuildSettings)
                {
                    SceneManager.LoadScene(nextIndex);
                }
                else
                {
                    SceneManager.LoadScene(0);
                }
            }
        }    
    }

    
   
}
