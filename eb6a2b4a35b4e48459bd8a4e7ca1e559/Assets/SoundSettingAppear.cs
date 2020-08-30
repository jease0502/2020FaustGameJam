using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettingAppear : MonoBehaviour
{
    public GameObject MenuCanvas; // Assign in inspector
    private bool isShowing;

    // Start is called before the first frame update
    void Start()
    {
        isShowing = false;
        MenuCanvas.SetActive(isShowing);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isShowing = !isShowing;
            MenuCanvas.SetActive(isShowing);
        }
    }
}