using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("Building");
        GameObject newObj = Instantiate(obj);
        newObj.transform.position = new Vector3(8, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
