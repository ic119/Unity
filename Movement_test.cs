using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_test : MonoBehaviour
{
    Vector3 target = new Vector3(0, 1.3f, 0);
    
    void Update()
    {
        // 1. MoveTowards() : 등속이동의미, (현재위치, 목표위치, 속도)
        //transform.position = Vector3.MoveTowards(transform.position, target, 2f);

        Vector3 velo = Vector3.zero;
        // 2. SmoothDamp() : 부드러운 감속이동, (현재위치, 목표위치, 참조속도 ,속도)
        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        // 3. Lerp() : 선형 보간, SmootDamp()보다 긴 감속시간
        //transform.position = Vector3.Lerp(transform.position, target, 0.05f);

        // 4. Slerp() : 구면 선형보간, 호를 그리며 이동
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
