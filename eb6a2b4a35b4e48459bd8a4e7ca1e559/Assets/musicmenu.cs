using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class musicmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer audioMixer;    // 进行控制的Mixer变量

    public void SetMasterVolum(float volume)    // 控制主音量的函数
    {
        audioMixer.SetFloat("MasterVolum", volume);
        // MasterVolume为我们暴露出来的Master的参数
    }
    public void SetBGmVolum(float volume)    // 控制主音量的函数
    {
        audioMixer.SetFloat("BGmVolum", volume);
        // MasterVolume为我们暴露出来的Master的参数
    }
}
