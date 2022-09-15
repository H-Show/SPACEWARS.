using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendShipSelect : MonoBehaviour
{
    #region メモ
    // csvで読み込んできたデータを格納する変数の作成 〇
    // どの機体が選択されたのかを調べる変数作成 〇
    // どの機体が選択されたのかを調べる
    // 読み込んできたデータをStart関数内で格納 〇
    // 選択された機体のデータを格納
    // 選択された機体を生成
    // 参考元:https://wisteria-sophy.com/663/unity_basis9/
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

            Debug.Log("機体1:" + Name[count]);
            Debug.Log("機体1:" + HP[count]);
            Debug.Log("機体1:" + DEF[count]);
            Debug.Log("機体1:" + SPD[count]);

            count++;

        //}
    }
}
