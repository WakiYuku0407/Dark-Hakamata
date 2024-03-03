using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitGem : MonoBehaviour
{

    private TextMeshProUGUI textbox_name;
    //他のオブジェクトアタッチ
    public GameObject textobject_name;
    public string itemTag;
    private int gemScore = 0;

    public GameObject gameCrearUIPrefab;
    private GameObject gameCrearUIInstance;

    public void Start()
    {
        //テキストボックス取得
        textbox_name = textobject_name.GetComponent<TextMeshProUGUI>();
        //テキスト反映
        textbox_name.text = "Score:" + gemScore + "/10";

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == itemTag)
        {
            //テキストボックス取得
            textbox_name = textobject_name.GetComponent<TextMeshProUGUI>();
            //テキスト反映
            gemScore++;
            textbox_name.text = "Score:" + gemScore + "/10";
            //クリア判定
            if(gemScore == 10)
            {
                gameCrearUIInstance = GameObject.Instantiate(gameCrearUIPrefab) as GameObject;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
            }
        }
    }
}