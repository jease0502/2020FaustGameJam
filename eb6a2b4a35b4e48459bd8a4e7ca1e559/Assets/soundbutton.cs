using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MenuCanvas; // Assign in inspector
    private bool isShowing;

    // Update is called once per frame
    public void open()
    {
        isShowing = !isShowing;
        MenuCanvas.SetActive(isShowing);
    }
}
