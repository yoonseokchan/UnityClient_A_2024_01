using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExConstructer : MonoBehaviour
{
    private int value;

    // Start is called before the first frame update
    public ExConstructer(int _value)
    {
        value = _value;
        Debug.Log("��ü�� �����Ǿ����ϴ�.�ʱⰪ:"+ value);
    }
    void Start()
    {
        ExConstructer ex = new ExConstructer(10); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);
        }
    }
    void OnDestroy()
    {
        Debug.Log("��ü�� �ı��Ǿ����ϴ�");
    }
}
