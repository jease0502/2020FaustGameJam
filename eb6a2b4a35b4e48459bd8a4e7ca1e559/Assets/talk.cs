using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Fungus
{

    public class talk : MonoBehaviour
    {
        public Flowchart talkFlowchart;
        public string onCollision;
        // Start is called before the first frame update
        private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
        {
            Block targetBlock = talkFlowchart.FindBlock(onCollision);
            talkFlowchart.ExecuteBlock(targetBlock);
        }
    }
}


