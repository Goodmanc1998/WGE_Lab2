using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Adds a MeshFilter and MeshRendered component
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]

public class MeshGenerator : MonoBehaviour {

    Mesh mesh;

    List<Vector3> vertexList;
    List<int> triIndexList;
    List<Vector2> UVList;

	// Use this for initialization
	void Start () {

        //RequireComponent declaration earlier should guarantee a MeshFilter component
        mesh = GetComponent<MeshFilter>().mesh;

        vertexList = new List<Vector3>();
        triIndexList = new List<int>();
        UVList = new List<Vector2>();

        CreateQuad(1,1);

        //Convert lists to arrays and store in mesh
        mesh.vertices = vertexList.ToArray();
        mesh.triangles = triIndexList.ToArray();

        //Convert UV list to array and store in mesh
        mesh.uv = UVList.ToArray();

        //Recalculating Normals to avoid Errors
        mesh.RecalculateNormals();

    }

    // Update is called once per frame
    void Update () {
		
	}

    void CreateQuad(int x, int y)
    {
        //List of Vertices
        vertexList.Add(new Vector3(x, y + 1, 0));
        vertexList.Add(new Vector3(x + 1, y + 1, 0));
        vertexList.Add(new Vector3(x + 1, y, 0));
        vertexList.Add(new Vector3(x, y, 0));

        //List of Triangle Indices
        triIndexList.Add(0);
        triIndexList.Add(1);
        triIndexList.Add(3);
        triIndexList.Add(1);
        triIndexList.Add(2);
        triIndexList.Add(3);

        //Storing the grass texture
        UVList.Add(new Vector2(0, 0.5f));
        UVList.Add(new Vector2(0.5f, 0.5f));
        UVList.Add(new Vector2(0.5f, 0));
        UVList.Add(new Vector2(0, 0));




    }
}
