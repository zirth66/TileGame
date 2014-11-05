using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TileMapGenerator))]
public class TileMapMouse : MonoBehaviour 
{
	TileMapGenerator _tileMapGenerator;

	Vector3 currentTileCoord;

	public Transform selectionCube;

	void Start()
	{
		_tileMapGenerator = GetComponent<TileMapGenerator> ();
	}
	// Update is called once per frame
	void Update () 
	{
		Ray ray = Camera.mainCamera.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitInfo;

		if (collider.Raycast (ray, out hitInfo, Mathf.Infinity)) 
		{
			int x = Mathf.FloorToInt(hitInfo.point.x / _tileMapGenerator.tileSize);
			int z = Mathf.FloorToInt(hitInfo.point.z / _tileMapGenerator.tileSize);
			Debug.Log("Tile: " +x+", " +z);

			currentTileCoord.x = x;
			currentTileCoord.z = z;

			selectionCube.transform.position = currentTileCoord * 5f;
		} 
		else 
		{

		}

	}
}
