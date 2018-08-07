using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(EZBuilder))]
public class EZBuilderGUI : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        EZBuilder Builder = (EZBuilder)target;
        if (GUILayout.Button("Build Object"))
        {
            Builder.DestroyObjects();
        }
    }
}
