using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitGem : MonoBehaviour
{

    private TextMeshProUGUI textbox_name;
    //���̃I�u�W�F�N�g�A�^�b�`
    public GameObject textobject_name;
    public string itemTag;
    private int gemScore = 0;

    public GameObject gameCrearUIPrefab;
    private GameObject gameCrearUIInstance;

    public void Start()
    {
        //�e�L�X�g�{�b�N�X�擾
        textbox_name = textobject_name.GetComponent<TextMeshProUGUI>();
        //�e�L�X�g���f
        textbox_name.text = "Score:" + gemScore + "/10";

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == itemTag)
        {
            //�e�L�X�g�{�b�N�X�擾
            textbox_name = textobject_name.GetComponent<TextMeshProUGUI>();
            //�e�L�X�g���f
            gemScore++;
            textbox_name.text = "Score:" + gemScore + "/10";
            //�N���A����
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