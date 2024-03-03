using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_sensivity : MonoBehaviour
{
    Slider sensivitySlider;
    Player_FPS Player_FPS_script;
    private void Start() {
        sensivitySlider = GetComponent<Slider>();
        sensivitySlider.maxValue = 15f;
        sensivitySlider.minValue = 1f;
        sensivitySlider.value = 3f;
    }

    public void GetSensivitySlider(){
        Player_FPS_script = GameObject.Find("Player").GetComponent<Player_FPS>();
        Player_FPS_script.Xsensityvity = sensivitySlider.value;
        Player_FPS_script.Ysensityvity = sensivitySlider.value;
    }
}
