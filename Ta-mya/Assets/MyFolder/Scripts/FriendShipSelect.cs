using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendShipSelect : MonoBehaviour
{
    #region ����
    // csv�œǂݍ���ł����f�[�^���i�[����ϐ��̍쐬 �Z
    // �ǂ̋@�̂��I�����ꂽ�̂��𒲂ׂ�ϐ��쐬 �Z
    // �ǂ̋@�̂��I�����ꂽ�̂��𒲂ׂ�
    // �ǂݍ���ł����f�[�^��Start�֐����Ŋi�[ �Z
    // �I�����ꂽ�@�̂̃f�[�^���i�[
    // �I�����ꂽ�@�̂𐶐�
    // �Q�l��:https://wisteria-sophy.com/663/unity_basis9/
    #endregion

    private FriendShipInfo statusInfo;
    private int count = 0;
    [SerializeField] private int[] SelectNum = new int[3];
    public string[] Name = new string[3];
    public int[] HP = new int[3];
    public int[] DEF = new int[3];
    public int[] SPD = new int[3];


    void Start()
    {
        count = 0;
        statusInfo = new FriendShipInfo();
        statusInfo.Init();
        CreateShip();
    }


    private void CreateShip()
    {
        //while(count < 3)
        //{
            Name[count] = statusInfo.Name[SelectNum[count]];
            HP[count] = statusInfo.HP[SelectNum[count]];
            DEF[count] = statusInfo.DEF[SelectNum[count]];
            SPD[count] = statusInfo.SPD[SelectNum[count]];

            Debug.Log("�@��1:" + Name[count]);
            Debug.Log("�@��1:" + HP[count]);
            Debug.Log("�@��1:" + DEF[count]);
            Debug.Log("�@��1:" + SPD[count]);

            count++;

        //}
    }
}
