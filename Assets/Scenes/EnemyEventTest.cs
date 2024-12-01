using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class EnemyEventTest : MonoBehaviour
{
    private void onEnable()
    {
        //이벤트 구독
        PlayerEventTest.OnGameOver += RespondToGameover;

    }

    private void OnDisable()
    {
        //이벤트 구독해제
        PlayerEventTest.OnGameOver -= RespondToGameover;
    }

    void RespondToGameover()
    {
        Debug.Log("플레이거가 죽었네? 나는 다시 할일 하러 흩어져서 대기해야지");
    }
}
