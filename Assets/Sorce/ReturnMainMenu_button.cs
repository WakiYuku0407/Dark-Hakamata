using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMainMenu : MonoBehaviour
{
    public string sceneNmae = "";
    // Start is called before the first frame update
    public void SwitchMainMenu()
    {
        if(sceneNmae != ""){
            SceneManager.LoadScene(sceneNmae);
            Debug.Log("bbb");
        }
        else{
            Debug.Log("aaa");
            int nextIndex = SceneManager.GetActiveScene().buildIndex+1;
            if(nextIndex<SceneManager.sceneCountInBuildSettings){
                SceneManager.LoadScene(nextIndex);
            }else{
                SceneManager.LoadScene(0);
            }
        }
    }
}
