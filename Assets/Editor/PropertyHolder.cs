using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(levelManager)), CanEditMultipleObjects]
public class LevelManagerEditor : Editor

{

    public SerializedProperty
        state_Prop,
        block_Prop;

    void OnEnable()
    {
        // Setup the SerializedProperties
        state_Prop = serializedObject.FindProperty("stage");
        block_Prop = serializedObject.FindProperty("block");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(state_Prop);

        levelManager.Stage st = (levelManager.Stage)state_Prop.enumValueIndex;

        switch (st)
        {
            case levelManager.Stage.hill:
                break;

            case levelManager.Stage.blockFort:
                EditorGUILayout.TextField("Level Name: ", "Block Fort");
                EditorGUILayout.PropertyField(block_Prop);
                //EditorGUILayout.ObjectField("Block:", null, typeof(GameObject), true);
                break;

        }


        serializedObject.ApplyModifiedProperties();
    }
}