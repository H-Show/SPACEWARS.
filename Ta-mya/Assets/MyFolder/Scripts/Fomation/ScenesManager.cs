using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    // シーン遷移処理(タイトル画面)
    
    // シーン遷移処理(街)

    // シーン遷移処理(編成画面)
    public void OnClickSelectShipButton()
    {
        SceneManager.LoadScene("Formation");
    }

    public void OnClickDevelopmentButton()
    {
        SceneManager.LoadScene("Development");
    }

    public void OnClickSelectSpecialAttackButton()
    {
        SceneManager.LoadScene("SpecialAttack");
    }

    public void OnClickBackButton()
    {
//        SceneManager.LoadScene("移動先のシーン");       
    }

    // シーン遷移処理(バトル)
}
