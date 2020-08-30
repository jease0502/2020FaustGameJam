using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManger : MonoBehaviour
{
    AudioSource BGM;
    AudioSource SE;
    // Start is called before the first frame update

    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (m_Play == true && m_ToggleChange == true)
        // {
        //     //Play the audio you attach to the AudioSource component
        //     BGM.Play();
        //     //Ensure audio doesn’t play more than once
        //     m_ToggleChange = false;
        // }
        // //Check if you just set the toggle to false
        // if (m_Play == false && m_ToggleChange == true)
        // {
        //     //Stop the audio
        //     BGM.Stop();
        //     //Ensure audio doesn’t play more than once
        //     m_ToggleChange = false;
        // }
    }
}
