using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    // �V�[���J�ڏ���(�^�C�g�����)
    
    // �V�[���J�ڏ���(�X)

    // �V�[���J�ڏ���(�Ґ����)
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
//        SceneManager.LoadScene("�ړ���̃V�[��");       
    }

    // �V�[���J�ڏ���(�o�g��)
}
