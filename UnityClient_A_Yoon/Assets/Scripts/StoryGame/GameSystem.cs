using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;
using STORYGAME;

#if UNITY_EDITOR
[CustomEditor(typeof(GameSystem))]
public class GameSystemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GameSystem gameSystem = (GameSystem)target;

        if(GUILayout.Button("Reset Story Models"))      //�����Ϳ��� ��ư ���� 
        {
            gameSystem.ResetStoryModels();
        }
    }

}

#endif
public class GameSystem : MonoBehaviour
{
    public StoryModel[] storyModels;                    //����� ���丮 �𵨷� ����

    public static GameSystem instance;                  //������ �̱��� ȭ

    private void Awake()                                //Scene�� ���� �ɶ� �ڵ� �����ܿ��� GameSystem�� �̱���ȭ 
    {
        instance = this;
    }

    public enum GAMESTATE
    {
        STROYSHOW,
        WAITSELECT,
        STORYEND,
        BATTLEMODE,
        BATTLEDONE,
        SHOPMODE,
        ENDMODE
    }
    public Stats stats;
    public GAMESTATE currentState;

    public int currentStoryIndex = 1;                                   //����ǰ� �ִ� ���丮 ��ȣ 

    public void ApplyChoice(StoryModel.Result result)                           //��ư�� ���� ��� ���� �Լ�
    {
        switch (result.resultType)
        {
            case StoryModel.Result.ResultType.ChangeHp:                         //HP ���� ���� 
                //stats.currentHpPoint += result.value;                         //���� �����ϰų� 
                ChangeState(result);                                            //�Լ��� ���ؼ� ����
                break;

            case StoryModel.Result.ResultType.AddExperience:
                ChangeState(result);
                break;

            case StoryModel.Result.ResultType.GoToNextStory:                    //���� ���丮 ����
                currentStoryIndex = result.value;                               //���� ���丮 �ε��� �߰�
                StoryShow(currentStoryIndex);                                   //�Լ��� ���ؼ� ���丮 �ý��� �����Ͽ� ���丮 ���� ���� 
                break;
            case StoryModel.Result.ResultType.GoToRandomStory:                  //���� ���丮 ����
                StoryModel temp = RandomStory();
                StoryShow(temp.storyNumber);
                break;
        }
    }
    public void StoryShow(int number)                                           //���丮�� �����ִ� �Լ� 
    {
        StoryModel tempStoryModel = FindStoryModel(number);

        StorySystem.instance.currentStoryModel = tempStoryModel;
        StorySystem.instance.CoShowText();
    }


    public void ChangeState(StoryModel.Result result)                           //��� ���� ���� ���� ���� (���� 1���� ����)
    {
        if (result.stats.hpPoint > 0) stats.hpPoint += result.stats.hpPoint;
        if (result.stats.spPoint > 0) stats.spPoint += result.stats.spPoint;
        if (result.stats.currentHpPoint > 0) stats.currentHpPoint += result.stats.currentHpPoint;
        if (result.stats.currentSpPoint > 0) stats.currentSpPoint += result.stats.currentSpPoint;
        if (result.stats.currentXpPoint > 0) stats.currentXpPoint += result.stats.currentXpPoint;
        if (result.stats.strength > 0) stats.strength += result.stats.strength;
        if (result.stats.dexterity > 0) stats.dexterity += result.stats.dexterity;
        if (result.stats.consitiution > 0) stats.consitiution += result.stats.consitiution;
        if (result.stats.wisdom > 0) stats.wisdom += result.stats.wisdom;
        if (result.stats.Intelligence > 0) stats.Intelligence += result.stats.Intelligence;
        if (result.stats.charisma > 0) stats.charisma += result.stats.charisma;
    }

    StoryModel RandomStory()               
    {
        StoryModel tempStoryModels = null;
        List<StoryModel> StoryModelList = new List<StoryModel>();           //������ ������ ���� List ����

        for (int i = 0; i < storyModels.Length; i++)            // for������ �迭 �ȿ� �ִ� ������ �� �����Ϳ��� 
        {
            if (storyModels[i].storytype == StoryModel.STORYTYPE.MAIN)          //���丮 Ÿ���� Main �� ��쿡�� �ش� List�� �߰� 
            {
                StoryModelList.Add(storyModels[i]);
            }
        }

        tempStoryModels = StoryModelList[Random.Range(0, StoryModelList.Count)];    //������ ���丮�� �� List ���� ��ŭ ���� ���� ������ �����´�.
        currentStoryIndex = tempStoryModels.storyNumber;
        Debug.Log("currentStoryIndex " + currentStoryIndex);

        return tempStoryModels;                               
    }

    StoryModel FindStoryModel(int number)               //StoryModel�� �ǵ����ִ� �Լ� ��ȣ�� ã�Ƽ� ���� 
    {
        StoryModel tempStoryModels = null;

        for (int i = 0; i < storyModels.Length; i++)            // for������ �迭 �ȿ� �ִ� ������ �� �����Ϳ��� 
        {                                                       // storyNumber ���� ��ġ�� ��� ���Ƿ� ������ temp �� �־
            if (storyModels[i].storyNumber == number)
            {
                tempStoryModels = storyModels[i];
                break;
            }
        }
        return tempStoryModels;                                 //return ��Ų��. 
    }

#if UNITY_EDITOR
    [ContextMenu("Reset Story Models")]
    public void ResetStoryModels()
    {
        storyModels = Resources.LoadAll<StoryModel>(""); // Resources ���� �Ʒ� ��� StoryModel �ҷ����� 
    }
#endif
}
