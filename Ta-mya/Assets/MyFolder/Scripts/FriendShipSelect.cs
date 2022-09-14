using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendShipSelect : MonoBehaviour
{
    #region メモ
    // csvで読み込んできたデータを格納する変数の作成 〇
    // どの機体が選択されたのかを調べる
    // 読み込んできたデータをStart関数内で格納 〇
    // 選択された機体のデータを格納
    // 選択された機体を生成
    // 参考元:https://wisteria-sophy.com/663/unity_basis9/
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
