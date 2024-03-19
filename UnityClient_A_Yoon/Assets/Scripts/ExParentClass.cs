using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExParentClass : MonoBehaviour
{
    // Start is called before the first frame update
    protected int protectedValue;

    public class ExChildClass : ExParentClass
    {
        void Start()
        {
            Debug.Log("protected Value from Child Class:" + protectedValue);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
