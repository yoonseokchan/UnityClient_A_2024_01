using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharacterUp : ExCharacter
{
    //override Ű���带 ����Ͽ� �Լ� �ٽ� ����
    protected override void Move()
    {
        base.Move();        //base Ű���� ����Ͽ� ���� �Լ� ���� ����
        transform.Translate(
            Vector3.up * speed * 2
            * Time.deltaTime);
    }
}
