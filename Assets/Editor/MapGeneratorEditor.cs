using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof (MapGenerator))]

public class MapGeneratorEditor : Editor {

	public override void OnInspectorGUI() {
		MapGenerator mapGen = (MapGenerator)target;
		//EndlessTerrain mapTerrain = (EndlessTerrain)target;

		if (DrawDefaultInspector ()) {
			Debug.Log ("DrawDefaultInspector");
			if (mapGen.autoUpdate) {
				//mapTerrain.UpdateVisibleChunks ();
				mapGen.DrawMapInEditor ();
			}
		}

		if (GUILayout.Button ("Generate")) {
			Debug.Log ("Generate");
			//mapTerrain.UpdateVisibleChunks ();
			mapGen.DrawMapInEditor ();
		}
	}
}