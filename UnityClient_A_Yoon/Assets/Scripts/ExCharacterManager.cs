using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharacterManager : MonoBehaviour
{
    public List<ExCharacter> characterList = new List<ExCharacter>();
    //���� ���� Ŭ������ ����ص� ExCharacterFast, ExCharacterUp �ڽ� Ŭ������ List�� �������. 
 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))     //Ű�� ������ �ı� �ȴ�. 
        {
            for(int i = 0; i < characterList.Count; i++) 
            {
                characterList[i].DestoryCharacter();
            }
        }
    }
}
