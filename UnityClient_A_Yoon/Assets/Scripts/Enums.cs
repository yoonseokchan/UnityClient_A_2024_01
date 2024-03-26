using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STORYGAME
{
    public class Enums
    {
        public enum StoryType : byte
        {
            MAIN,
            SUB,
            SERIAL
        }


        public enum EvenType
        {
            NONE,
            GoToBattle = 100,
            CheckSTR = 1000,
            CheckDEX,
            CheckCon,
            CheckInt,
            CheckWIS,
            CheckCHA
        }

        public enum ResultType
        {
            ChangeHp,
            ChangeSp,
            AddExoerIence,
            GoToShop,
            GoToNextStory,
            GoToRandeomStory,
            GoToEnding
        }
    }

    [System.Serializable]

    public class Stats
    {
        public int hpPoint;
        public int spPoint;

        public int currentHpPoint;
        public int currentSpPoint;
        public int currentXpPoint;

        public int strength;
        public int dexterity;
        public int consitiuation;
        public int Intelligence;
        public int wisdom;
        public int charisma;
    }
}
