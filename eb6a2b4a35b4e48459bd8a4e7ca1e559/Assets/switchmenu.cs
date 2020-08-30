using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 必须要引入

public class switchmenu : MonoBehaviour
{
    // Start is called before the first frame update
    private string sceneName;
    public void ChangeScene()
    {
        // 切换场景
        SceneManager.LoadScene("SampleScene"); // 参数是场景编号或场景名字
        // 获取当前场景的名字
        sceneName = SceneManager.GetActiveScene().name;
    }


}

