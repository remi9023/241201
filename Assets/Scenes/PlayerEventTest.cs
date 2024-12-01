using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerEventTest : MonoBehaviour
{
    //��������Ʈ�� �̺�Ʈ ����
        public delegate void GameOverEvent();
        public static event GameOverEvent OnGameOver;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�÷��̾�� 'G' ��ư�� ������ ���� ������ �˴ϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            TriggerGameover();

        }
    }
    void TriggerGameover()
    {
        Debug.Log("���� ������ �Ǿ����ϴ�.");
        if (OnGameOver != null)
        {
            OnGameOver();   //�̺�Ʈ ȣ��
        }
    }
}