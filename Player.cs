using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Actor
    // 상속관계
    // Player => 자식클래스
    // Actor => 부모클래스
{
    public string login()
    {
        return "플레이어가 접속합니다.";
    }
}
