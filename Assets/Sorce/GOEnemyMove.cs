using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverEnemyMove : MonoBehaviour
{
    public GameObject gameOverUIPrefab;
    private GameObject gameOverUIInstance;

   

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(GameOverUI), 1f);
        
    }

    void GameOverUI()
    {
        gameOverUIInstance = GameObject.Instantiate(gameOverUIPrefab) as GameObject;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
    }

    void Update()
    {
        if(this.transform.position.x < 60)
        {
            Transform myTransform = this.transform;
            Vector3 pos = myTransform.position;
            pos.x += 2f;
            this.transform.position = pos;
        }
        //transform.Translate(1, 0, Time.deltaTime);
    }

    // Update is called once per frame
   
}
