﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof(MeshFilter))]
[RequireComponent (typeof(MeshRenderer))]
[RequireComponent (typeof(MeshCollider))]

public class TileMap : MonoBehaviour {
	 

	// Use this for initialization
	void Start () 
	{
		BuildMesh();
	}

	void BuildMesh()
	{
		// Generate the mesh data
		Vector3[] vertices = new Vector3[4];
		int[] triangles = new int[2 * 3];
		Vector3[] normals = new Vector3[4];
		Vector2[] uv = new Vector2[4];

		// ( X, Y, Z)
		vertices[0] = new Vector3 (0, 0, 0);
		vertices[1] = new Vector3 (1, 0, 0);
		vertices[2] = new Vector3 (0, 0, -1);
		vertices[3] = new Vector3 (1, 0, -1);
		

		/*
		 * 0	1
		 * ------
		 * |\	|
		 * | \	|
		 * |  \	|
		 * ------
		 * 2	3
		 * 
		 */
		triangles[0] = 0;
		triangles[1] = 3;
		triangles[2] = 2;

		triangles[3] = 0;
		triangles[4] = 1;
		triangles[5] = 3;

		normals[0] = Vector3.up;
		normals[0] = Vector3.up;
		normals[0] = Vector3.up;
		normals[0] = Vector3.up;

		uv[0] = new Vector2 (1, 1);
		uv[1] = new Vector2 (0, 1);
		uv[2] = new Vector2 (1, 0);
		uv[3] = new Vector2 (0, 0);




		// Create a new Mesh and populate with the data
		Mesh mesh = new Mesh ();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
		mesh.normals = normals;
		mesh.uv = uv;

		// Assign our mesh to our filter/renderer/collider
		MeshFilter mesh_filter = GetComponent<MeshFilter>();
		MeshRenderer mesh_renderer = GetComponent<MeshRenderer>();
		MeshCollider mesh_colider = GetComponent<MeshCollider> ();

		mesh_filter.mesh = mesh;
	}

}
