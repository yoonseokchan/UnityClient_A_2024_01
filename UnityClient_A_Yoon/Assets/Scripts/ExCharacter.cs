using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharacter : MonoBehaviour
{
    public float speed = 5f; // ĳ���� �̵� �ӵ�     
   
    void Update()
    {
        Move();                 //�����Ӹ��� Move �Լ� ȣ��
    }
    protected virtual void Move()       //virtual Ű���带 �ۼ��Ͽ� ��� ���� Ŭ������ �� ���� �� �� �ְ� �Ѵ�. 
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);      //ĳ���͸� ������ �̵�
    }
    public void DestoryCharacter()      ///ĳ���� �ı� 
    {
        Destroy(gameObject);
    }
}
