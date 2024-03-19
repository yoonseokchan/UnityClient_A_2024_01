using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExAccessControl : MonoBehaviour
{
    // Start is called before the first frame update
    public int publicValue;

    private int privatevalue;

    protected int protectedValue;

    internal int internalValue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
