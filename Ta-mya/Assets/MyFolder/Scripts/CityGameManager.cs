using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityGameManager: MonoBehaviour
{
    public GameObject obj;
    // �I�u�W�F�N�g����ׂ鐔��ێ����܂��B
    public int horizontalNum = 10;

    int block = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Cube�v���n�u��GameObject�^�Ŏ擾
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
