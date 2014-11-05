using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(TileMapGenerator))]
public class TileMapInspector : Editor 
{

	public override void OnInspectorGUI() 
	{
		//base.OnInspectorGUI();
		DrawDefaultInspector();

		if (GUILayout.Button ("Regenerate"))
		{
			TileMapGenerator tileMap = (TileMapGenerator)target;
			tileMap.BuildMesh();
		}
	}

}