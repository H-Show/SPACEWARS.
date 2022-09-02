using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static Bullet instance;

    public Quaternion firstRotation;
    public float speedY = 100;

    private Rigidbody rb;
    public float MoveSpeed = 2.0f;
    public GameObject BulletObj;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        firstRotation = transform.rotation;
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        Vector3 movementSpeed = new Vector3(0, speedY, 0);

        movementSpeed = firstRotation * movementSpeed;

        rigidbody.AddForce(movementSpeed);
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
