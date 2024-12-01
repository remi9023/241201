using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class EnemyEventTest : MonoBehaviour
{
    private void onEnable()
    {
        //�̺�Ʈ ����
        PlayerEventTest.OnGameOver += RespondToGameover;

    }

    private void OnDisable()
    {
        //�̺�Ʈ ��������
        PlayerEventTest.OnGameOver -= RespondToGameover;
    }

    void RespondToGameover()
    {
        Debug.Log("�÷��̰Ű� �׾���? ���� �ٽ� ���� �Ϸ� ������� ����ؾ���");
    }
}
