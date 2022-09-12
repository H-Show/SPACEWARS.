using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public class PlayerData
    {
        public string name;
        public int hp;
        public int attack;
        public int defense;
    }

    void Start()
    {
        PlayerData battleShip1 = new PlayerData();
        battleShip1.name = "Proto01";
        battleShip1.hp = 300;
        battleShip1.attack = 15;
        battleShip1.defense = 3;
        string jsondata = JsonUtility.ToJson(battleShip1); //JSONÉfÅ[É^ÇÕC#è„Ç≈ï∂éöóÒÇ∆ÇµÇƒàµÇ§

        Debug.Log(jsondata);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void savePlayerData(PlayerData battleShip1)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(battleShip1);

        writer = new StreamWriter(Application.dataPath + "/savedata.json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
    }
}
