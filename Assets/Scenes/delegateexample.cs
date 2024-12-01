using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class delegateexample : MonoBehaviour
{
    //��������Ʈ ����
    public delegate void MyDelegate(string message);

    //��������Ʈ�� ������ �޼���

    void PrintMessage(string message)
    {
        Debug.Log("����Ʈ �޽��� �Լ� ���:" + message);

    }
    void LogMessage(string message)
    {
        Debug.Log("�α� �޽��� �Լ� ���" + message);
    }





    // Start is called before the first frame update
    void Start()
    {
        //��������Ʈ �ν��Ͻ� ����
        MyDelegate myDelegate = null;

        //�޼��� �߰�
        myDelegate += PrintMessage; // ����Ʈ�޽����� ��������Ʈ�� ���̴°�
        myDelegate += LogMessage;   // �α׸޽����� ��������Ʈ�� ���̴� �� ��, ��Ƽ ĳ��Ʈ

       // ��������Ʈ�� ����Ͽ� �޼��带 ȣ��

        myDelegate("�ȳ�, ��Ƽĳ��Ʈ ��������Ʈ��� ��");
        
        //�޼��� ���� �� ȣ��
        myDelegate -= LogMessage;
        myDelegate("�α� �޽��� �Լ� �����ϰ� ȣ���߾�");

        myDelegate("������, ����Ƽ���� ��������Ʈ ����߾��?!");
        myDelegate("�� ������ó�� ���ϸ� : ���� ����?");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
