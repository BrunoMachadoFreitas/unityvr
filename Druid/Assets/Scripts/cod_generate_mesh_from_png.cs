using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class cod_generate_mesh_from_png : MonoBehaviour
{
    [SerializeField] private Texture2D texture;
    [SerializeField] private Mesh mesh;
    [SerializeField] private MeshFilter mf;
    [ContextMenu("TEST")]
    private void Awake()
    {
        // Just in case use the mesh format that allows more vertices

        if (!mf) mf = GetComponent<MeshFilter>();

        mesh = new Mesh { indexFormat = IndexFormat.UInt32 };

        // Create these ONCE and fill them bit by bit
        var verticesList = new List<Vector3>();
        var trianglesList = new List<int>();
        var colors = new List<Color>();

        // Do this in ONE call -> more efficient
        var pixels = texture.GetPixels();

        // Place the pivot in the center of the texture
        var pivotOffset = -new Vector3(texture.width / 2f, texture.height / 2f);

        for (var i = 0; i < texture.width; i++)
        {
            for (var j = 0; j < texture.height; j++)
            {
                var color = pixels[i + j * texture.width];

                if (color.a == 0)
                {
                    continue;
                }

                // Add the pixel color for the FOUR vertices we create
                colors.Add(color);
                colors.Add(color);
                colors.Add(color);
                colors.Add(color);

                // Create the four vertices around this pixel position
                var vertex0 = pivotOffset + new Vector3(i - 0.5f, j - 0.5f, 0);
                var vertex1 = pivotOffset + new Vector3(i + 0.5f, j - 0.5f, 0);
                var vertex2 = pivotOffset + new Vector3(i - 0.5f, j + 0.5f, 0);
                var vertex3 = pivotOffset + new Vector3(i + 0.5f, j + 0.5f, 0);

                // Store the current length of so far vertices => first new vertex index
                var currentIndex = verticesList.Count;

                // Add the vertices to the list
                verticesList.Add(vertex0);
                verticesList.Add(vertex1);
                verticesList.Add(vertex2);
                verticesList.Add(vertex3);

                // Two triangles for front side
                trianglesList.Add(currentIndex);
                trianglesList.Add(currentIndex + 2);
                trianglesList.Add(currentIndex + 3);

                trianglesList.Add(currentIndex);
                trianglesList.Add(currentIndex + 3);
                trianglesList.Add(currentIndex + 1);

                // For double sided add the inverted faces for the back as well
                trianglesList.Add(currentIndex);
                trianglesList.Add(currentIndex + 3);
                trianglesList.Add(currentIndex + 2);

                trianglesList.Add(currentIndex);
                trianglesList.Add(currentIndex + 1);
                trianglesList.Add(currentIndex + 3);
            }
        }

        // Finally apply them ONCE to the mesh
        mesh.vertices = verticesList.ToArray();
        mesh.triangles = trianglesList.ToArray();
        mesh.colors = colors.ToArray();

        mf.sharedMesh = mesh;
    }
}
