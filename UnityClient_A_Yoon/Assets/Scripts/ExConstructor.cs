using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExConstructor : MonoBehaviour          //������ ����
{
    private int value;          //����� ���� ���� 
   
    //������
    public ExConstructor(int _value)
    {
        value = _value;     //�����ڸ� ȣ�� �Ҷ� ���� ������ ���� ������ �Է�
        Debug.Log("��ü�� ���� �Ǿ����ϴ� . �ʱⰪ : " + value); //��ü�� �����Ǿ����� ����α׷� ���� �� ���
    }

    void Start()
    {
        //������ ȣ�� 
        ExConstructor ex = new ExConstructor(10);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //�����̽�Ű�� �������� �� ��ü �ı�
        {
            Destroy(this.gameObject);
        }
    }
    //Unity ������ ��������� �Ҹ��ڸ� ȣ�� �ϴ°��� �ƴ϶� OnDestroy()�޼��带 Ȱ���Ͽ� ��ü �ı� �ɶ� �ʿ��� �۾� ����
    void OnDestroy()
    {
        Debug.Log("��ü�� �ı��Ǿ����ϴ�");
    }

}
