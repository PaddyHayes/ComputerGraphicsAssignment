using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model
{

    internal List<Vector3> vertices;
    List<int> index_list;
    List<Vector2> textureCoordinates;
    List<int> textureIndices;

public Model()
    {
        loadVerts();
        loadIndices();

        
    }

    private void loadIndices()
    {
        index_list = new List<int>();

        index_list.Add(1); index_list.Add(9); index_list.Add(2);   //  textureIndices.Add(?); textureIndices.Add(?); textureIndices.Add(?);
    }

    private void loadVerts()
    {
        vertices = new List<Vector3>();

        vertices.Add(new Vector3(-4, 6, 1));
        vertices.Add(new Vector3(3, 6, 1));
        vertices.Add(new Vector3(4, 5, 1));
        vertices.Add(new Vector3(4, -1, 1));
        vertices.Add(new Vector3(-1, -1, 1));
        vertices.Add(new Vector3(-1, -5, 1));
        vertices.Add(new Vector3(-4, -5, 1));
        vertices.Add(new Vector3(-2, 4, 1));
        vertices.Add(new Vector3(2, 4, 1));
        vertices.Add(new Vector3(2, 1, 1));
        vertices.Add(new Vector3(-2, 1, 1));
        vertices.Add(new Vector3(-4, 6, -1));
        vertices.Add(new Vector3(3, 6, -1));
        vertices.Add(new Vector3(4, 5, -1));
        vertices.Add(new Vector3(4, -1, -1));
        vertices.Add(new Vector3(-1, -1, -1));
        vertices.Add(new Vector3(-1, -5, -1));
        vertices.Add(new Vector3(-4, -5, -1));
        vertices.Add(new Vector3(-2, 4, -1));
        vertices.Add(new Vector3(2, 4, -1));
        vertices.Add(new Vector3(2, 1, -1));
        vertices.Add(new Vector3(-2, 1, -1));


    }
}
