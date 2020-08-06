using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float health = 50.0f;
    void TakeDamage(int value)
    {
        //적 체력 감소 관련 함수
        health -= value;
        // 인수로 체력을 얼마만큼 감소시킬지 매개변수 value 저장
    }

    public float GetHealth()
    {
        return health;
    }
}
