using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

namespace STORYGAME
{
#if UNITY_EDITOR
    [CustomEditor(typeof(GameSystem))]

    public class GameSystemEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GameSystem gameSystem = (GameSystem)target;

            if(GUILayout.Button("Reset Story Models"))
            {
                gameSystem.ResetStoryModels();
            }
        }
    }
    public class GameSystem : MonoBehaviour
    {
        // Start is called before the first frame update
        public static GameSystem instance;

        private void Awake()
        {
            instance = this;
        }

        public StoryTableObject[] storyModels;

#if UNITY_EDITOR
        [ContextMenu("Reset Story Models")]

        public void ResetStoryModels()
        {
            storyModels = Resources.LoadAll<StoryTableObject>("");
        }
#endif
    }
}
#endif