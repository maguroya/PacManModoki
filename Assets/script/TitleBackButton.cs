using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TitleBackButton : MonoBehaviour
{
   public void Retry()
   {
    SceneManager.LoadScene("TitleScene");
   }
}
