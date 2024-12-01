using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    //델리게이트와 이벤트 선언
    public delegate void GameOverEvent()
        public static event GameOverEvent GameOver;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("플레이어는 'G' 버튼을 누르면 게임 오버가 됩니다.");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Keycode.G))
        {
            TriggerGameOver();

        }
    }
    void TriggerGameover()
    {
        Debug.Log("게임 오버가 되었습니다.");
        if (GameOver != null)
        {
            OnGameOver();   //이벤트 호출
        }
    }
}