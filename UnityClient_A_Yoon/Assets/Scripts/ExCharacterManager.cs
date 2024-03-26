using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharacterManager : MonoBehaviour
{
    public List<ExCharacter> characterList = new List<ExCharacter>();

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for(int i= 0; i < characterList.Count; i++)
            {
                characterList[i].DestroyCharacter();
            }
        }
    }
}
