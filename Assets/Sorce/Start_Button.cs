using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{
    public string sceneNmae = "";
    // Start is called before the first frame update
    public void Start()
    {
        //Screen.SetResolution(0, 0, FullScreenMode.MaximizedWindow);
    }
    
    public void SwitchScene()
    {
        if(sceneNmae != ""){
            SceneManager.LoadScene(sceneNmae);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;
        }else{
            int nextIndex = SceneManager.GetActiveScene().buildIndex+1;
            if(nextIndex<SceneManager.sceneCountInBuildSettings){
                SceneManager.LoadScene(nextIndex);
            }else{
                SceneManager.LoadScene(0);
            }
        }
    }
}
