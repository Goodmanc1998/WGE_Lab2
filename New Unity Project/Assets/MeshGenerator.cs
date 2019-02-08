using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Adds a MeshFilter and MeshRendered component
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]

public class MeshGenerator : MonoBehaviour {
    Mesh mesh;
    List<Vector3> vertexList;
    List<int> triIndexList;


	// Use this for initialization
	void Start () {

        //RequireComponent declaration earlier should guarantee a MeshFilter component
        mesh = GetComponent<MeshFilter>().mesh;

        vertexList = new List<Vector3>();
        triIndexList = new List<int>();

        CreateQuad();

        //Convert lists to arrays and store in mesh
        mesh.vertices = vertexList.ToArray();
        mesh.triangles = triIndexList.ToArray();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateQuad()
    {
        //List of Vertices
        vertexList.Add(new Vector3(0, 1, 0));
        vertexList.Add(new Vector3(1, 1, 0));
        vertexList.Add(new Vector3(1, 0, 0));
        vertexList.Add(new Vector3(0, 0, 0));

        //List of Triangle Indices
        triIndexList.Add(0);
        triIndexList.Add(1);
        triIndexList.Add(3);
        triIndexList.Add(1);
        triIndexList.Add(2);
        triIndexList.Add(3);


    }
}
