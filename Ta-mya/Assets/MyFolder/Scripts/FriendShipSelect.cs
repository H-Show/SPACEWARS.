using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendShipSelect : MonoBehaviour
{
    #region ����
    // csv�œǂݍ���ł����f�[�^���i�[����ϐ��̍쐬 �Z
    // �ǂ̋@�̂��I�����ꂽ�̂��𒲂ׂ�
    // �ǂݍ���ł����f�[�^��Start�֐����Ŋi�[ �Z
    // �I�����ꂽ�@�̂̃f�[�^���i�[
    // �I�����ꂽ�@�̂𐶐�
    // �Q�l��:https://wisteria-sophy.com/663/unity_basis9/
    #endregion

    private FriendShipInfo statusInfo;
    private int SelectNum;
    
    
    void Start()
    {
        statusInfo = new FriendShipInfo();
        statusInfo.Init();
    }

    void Update()
    {
        
    }
}
