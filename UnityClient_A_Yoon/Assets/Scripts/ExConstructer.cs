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
        Debug.Log("객체가 생성되었습니다.초기값:"+ value);
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
        Debug.Log("객체가 파괴되었습니다");
    }
}
