using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pause_esc : MonoBehaviour
{
    //ポーズのプレハブ
    public GameObject pauseUIPrefab;
    //ポーズUIのインスタンス
    private GameObject pauseUIInstance;
    
   
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(pauseUIInstance==null){
                //メニュー画面開いたとき
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0f;
            }else{
                //メニュー画面閉じたとき
                Destroy(pauseUIInstance);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Time.timeScale=1f;
            }
        }
    }
}
