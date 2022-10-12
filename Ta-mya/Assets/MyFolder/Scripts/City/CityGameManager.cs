using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityGameManager: MonoBehaviour
{
    public GameObject obj;
    // オブジェクトを並べる数を保持します。
    public int horizontalNum = 10;

    int block = 0;

    // Start is called before the first frame update
    void Start()
    {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Building");
    }

    // Update is called once per frame
    void Update()
    {

       if (Input.GetKeyDown(KeyCode.Space))
       {
       //Instantiate;
       Instantiate(obj, new Vector3(320.0f + block * 20.0f, 10.0f, 300.0f), Quaternion.identity);
       block++;
            //if (obj = 10)
            //{
            //    Instantiate(obj, new Vector3(320.0f + block * 20.0f, 10.0f, 320.0f), Quaternion.identity);
            //    block++;
            //}

       }
       
    
    }
}
