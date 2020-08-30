using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    GameObject bg;
    GameObject StartButton;
    public string gbname;

    // Start is called before the first frame update
    void Start()
    {
        StartButton = GameObject.Find("StartButton");
        bg = GameObject.Find("008");
        StartButton.active = true;
        bg.active = true;   //設置開始可見性（此處最新修改與2017年7月8日）
    }

    public void OnClick()
    {   //控制顯示和隱藏的方法
        StartButton.SetActive(false);
        bg.SetActive(false);
    }


}