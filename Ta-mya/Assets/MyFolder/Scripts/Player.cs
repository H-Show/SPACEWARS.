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
    //public Bullet script;
    public GameObject bullet;
    public float minangle = -10f;
    public float maxangle = 10f;
    Vector3 rotEuler;

    Vector3 bulletPoint;

    // �Q�[���̃X�^�[�g���̏���
    void Start()
    {
        //rotEuler = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0f);
        //bulletPoint = transform.Find("BulletPoint").localPosition;
        //Bullet = GameObject.Find("Bullet");
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
            //Bullet.instance.shot();
            //Instantiate(Bullet, transform.position + bulletPoint, Quaternion.identity);

            //�e���o��������ʒu���擾
            Vector3 placePosition = this.transform.position;
            //�o��������ʒu�����炷�l
            Vector3 offsetGun = new Vector3(0, 0, 2);

            //����̌����ɍ��킹�Ēe�̌���������
            Quaternion q1 = this.transform.rotation;
            //�e��90�x��]�����鏈��
            Quaternion q2 = Quaternion.AngleAxis(90, new Vector3(1, 0, 0));
            Quaternion q = q1 * q2;

            //�e���o��������ʒu�𒲐�
            placePosition = q1 * offsetGun + placePosition;
            //�e�����I
            Instantiate(bullet, placePosition, Quaternion.identity);

        }
    }
}

