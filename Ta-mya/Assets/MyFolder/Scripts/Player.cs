using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviourPunCallbacks
{
    // ���@�̈ړ����x���i�[����ϐ��i�����l 1�j
    public float speed = 1;
    [SerializeField] private float RoteSpeed = 1;
    [SerializeField] private float MaxRotate = 10f;
    public GameObject Bullet;
    public float minangle = -10f;
    public float maxangle = 10f;
    Vector3 rotEuler;

    Vector3 bulletPoint;

    // �Q�[���̃X�^�[�g���̏���
    void Start()
    {
        rotEuler = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0f);
        bulletPoint = transform.Find("BulletPoint").localPosition;
        Bullet = GameObject.Find("Bullet");
    }

    // �Q�[�����s���̌J��Ԃ�����
    void Update()
    {        

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, RoteSpeed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -RoteSpeed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        if (Input.GetMouseButtonDown(0))
        {
            // �e�̐���

            Instantiate(Bullet, transform.position + bulletPoint, Quaternion.identity);
            Bullet.GetComponent<Bullet>().OnMouseDown();
            Bullet.GetComponent<Bullet>().OnceCheck = true;
        }
    }
}

