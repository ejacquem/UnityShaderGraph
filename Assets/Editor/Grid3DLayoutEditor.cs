using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Grid3DLayout))]
public class Grid3DLayoutEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Grid3DLayout grid = (Grid3DLayout)target;

        GUILayout.Space(10);
        if (GUILayout.Button("Generate Grid"))
        {
            grid.GenerateGrid();
        }

        if (GUILayout.Button("Clear Grid"))
        {
            grid.ClearGrid();
        }
    }
}
