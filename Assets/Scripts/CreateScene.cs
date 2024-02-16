using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScene : MonoBehaviour
{
    public int sizeOfForest;
    public int stonesRequired;
    public GameObject[] trees;
    public GameObject[] stones;
    void Start()
    {
        InitializeVariables();
        CreateGround();
        CreateRandomForest();
        CreatePyramid();
    }
    void InitializeVariables()
    {
        sizeOfForest = 15;
        stonesRequired = 55;
        trees = new GameObject[sizeOfForest];
        stones = new GameObject[stonesRequired];
    }

    void CreateGround()
    {
        //Creates a primitive plane that acts as the ground GameObject
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        
        //Sets name of GameObject to "Ground"
        ground.name = "Ground";

        //Sets position of GameObject to the origin
        ground.transform.position = new Vector3(0, 0, 0);
        
        //Sets color of GameObject to a hue similar to professor's example
        var groundRenderer = ground.GetComponent<Renderer>();
        Color groundColor = new Color(0.8f, 0.4f, 0.4f);
        groundRenderer.material.SetColor("_Color", groundColor);
    }

    void CreateRandomForest()
    {

        for(int i = 0; i < 15; i++) 
        {
        GameObject trees = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        trees.name = "Tree";
        System.Random random = new System.Random();
        int x = random.Next(-5,5);
        int y = random.Next(1,1);
        int z = random.Next(-5,5);  
        trees.transform.position = new Vector3(x,y,z);
        // set scale
        int x2 = random.Next(1,3);
        int y2 = random.Next(1,3);
        int z2 = random.Next(1,3);
        trees.transform.localScale = new Vector3(x2,y2,z2);
        var treesRenderer = trees.GetComponent<Renderer>();
        Color treesColor = new Color(0.4f, 0.8f, 0.4f);
        treesRenderer.material.SetColor("_Color", treesColor);
        }
    }
    void CreatePyramid()
    {

    }
}
