using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharacter : MonoBehaviour
{
    public float speed = 5f; // ĳ���� �̵��ӵ�

    
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    protected virtual void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void DestroyCharacter()
    {
        Destroy(gameObject);
    }
}
