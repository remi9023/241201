using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    //��������Ʈ�� �̺�Ʈ ����
    public delegate void GameOverEvent()
        public static event GameOverEvent GameOver;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�÷��̾�� 'G' ��ư�� ������ ���� ������ �˴ϴ�.");
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
        Debug.Log("���� ������ �Ǿ����ϴ�.");
        if (GameOver != null)
        {
            OnGameOver();   //�̺�Ʈ ȣ��
        }
    }
}