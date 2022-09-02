using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviourPunCallbacks
{
    // 自機の移動速度を格納する変数（初期値 1）
    public float speed = 1;
    [SerializeField] private float RoteSpeed = 1;
    [SerializeField] private float MaxRotate = 10f;
    //public Bullet script;
    public GameObject bullet;
    public float minangle = -10f;
    public float maxangle = 10f;
    Vector3 rotEuler;

    Vector3 bulletPoint;

    // ゲームのスタート時の処理
    void Start()
    {
        //rotEuler = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0f);
        //bulletPoint = transform.Find("BulletPoint").localPosition;
        //Bullet = GameObject.Find("Bullet");
    }

    // ゲーム実行中の繰り返し処理
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
            // 弾の生成
            //Bullet.instance.shot();
            //Instantiate(Bullet, transform.position + bulletPoint, Quaternion.identity);

            //弾を出現させる位置を取得
            Vector3 placePosition = this.transform.position;
            //出現させる位置をずらす値
            Vector3 offsetGun = new Vector3(0, 0, 2);

            //武器の向きに合わせて弾の向きも調整
            Quaternion q1 = this.transform.rotation;
            //弾を90度回転させる処理
            Quaternion q2 = Quaternion.AngleAxis(90, new Vector3(1, 0, 0));
            Quaternion q = q1 * q2;

            //弾を出現させる位置を調整
            placePosition = q1 * offsetGun + placePosition;
            //弾生成！
            Instantiate(bullet, placePosition, Quaternion.identity);

        }
    }
}

