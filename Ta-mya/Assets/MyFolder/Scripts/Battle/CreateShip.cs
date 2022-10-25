using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShip : MonoBehaviour
{
    [SerializeField] private Vector3[] CreatePos;
    [SerializeField] private List<GameObject> CreateShips = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < SelectShip.SelectShipNum.Length; i++)
        {
            Instantiate(CreateShips[int.Parse(SelectShip.SelectShipNum[i])], CreatePos[i], Quaternion.identity); 
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
