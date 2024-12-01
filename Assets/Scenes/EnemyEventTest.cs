using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class EnemyEventTest : MonoBehaviour
{
    private void onEnable()
    {
        //�̺�Ʈ ����
        PlayerEventTest.OnGameover += RespondToGameOver;

    }

    private void OnDisable()
    {
        //�̺�Ʈ ��������
        PlayerEventTest.OnGameOver -= RespondToGameOver;
    }

    void RespondToGameover()
    {
        Debug.Log("�÷��̰Ű� �׾���? ���� �ٽ� ���� �Ϸ� ������� ����ؾ���");
    }
}
