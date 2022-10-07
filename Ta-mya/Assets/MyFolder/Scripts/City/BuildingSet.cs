using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSet : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate( 生成するオブジェクト,  場所, 回転 );
            Instantiate(obj, new Vector3(320.0f, 10.0f, 300.0f), Quaternion.identity);
        }
    }
}
