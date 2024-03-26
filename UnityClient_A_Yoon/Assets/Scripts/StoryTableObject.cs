using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace STORYGAME
{
    [CreateAssetMenu(fileName = "NewStory" ,menuName = "ScriptableObjects/StoryTableObjet")]
    public class StoryTableObject : ScriptableObject
    {
        public int storyNymber;
        public Enums.StoryType storyType;
        public bool storyDone;

        [TextArea(10, 10)]
        public string storyText;
        public List<Option> options = new List<Option>();

        [System.Serializable]

        public class Option
        {
            public string optionText;
            public string buttonText;
            public EventCheck eventCheck;
        }
        public class EventCheck
        {
            public int checkValue;
            public Enums.EvenType evenyType;
            public List<Result> successResult = new List<Result>();
        }
        [System.Serializable]

        public class Result
        {
            public Enums.ResultType resultType;
            public int cvalue;
            public Stats stats;
        }
    }

    
}

