using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    public void StartBtn()
    {
         Debug.Log("押された！");

        SceneManager.LoadScene("GameScene");
    }
}
