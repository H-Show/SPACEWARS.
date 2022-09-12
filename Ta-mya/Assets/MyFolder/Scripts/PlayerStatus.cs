using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playersta : MonoBehaviour
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
}
