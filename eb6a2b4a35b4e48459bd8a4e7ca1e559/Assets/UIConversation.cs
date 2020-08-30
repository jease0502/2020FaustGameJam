using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class UIConversation : MonoBehaviour
{
    // Start is called before the first frame update
    private int count = 0;
    void OnTriggerEnter()
    {
        if (count == 0)
        {
            Flowchart.BroadcastFungusMessage("對話1");
            count++;
        }
        else if (count == 1)
        {
            Flowchart.BroadcastFungusMessage("對話2");
            count++;
        }


    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
