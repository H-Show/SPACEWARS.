using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    public float MoveSpeed = 2.0f;
    public GameObject BulletObj;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        // íeÇÃà⁄ìÆ
        rb.velocity = transform.forward * MoveSpeed;
    }

    public void shot()
    {
        // íeÇÃê∂ê¨
        //Instantiate(BulletObj, transform.position, transform.rotation);
        GameObject prefab = (GameObject)Resources.Load("Prefabs/Bullet");
        GameObject cloneObject = Instantiate(prefab, this.transform.position, Quaternion.identity);
    }
}
