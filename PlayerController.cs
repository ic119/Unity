using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 0.1f;
    public GameObject BulletPrefab;
    public float BulletSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        // 캐릭터 이동관련 함수
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, Speed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-Speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, -Speed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {  
            // 공격관련 함수
            for (int i = 0; i < 3; i++) { 
            GameObject Bullet = Instantiate(BulletPrefab);
                Vector3 bulletPos = transform.position;
                bulletPos.y += 0.3f * i;
            Bullet.transform.position = bulletPos;
            Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed);
            }
        }
    }
  
}
