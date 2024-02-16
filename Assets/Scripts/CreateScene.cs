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
        GameObject forest = new GameObject();
        forest.name = "Forest";

        for (int i = 0; i < 15; i++) 
        {
            GameObject trees = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            trees.name = "Tree";
            System.Random random = new System.Random();
            int x = random.Next(-5, 5);
            int y = random.Next(1, 1);
            int z = random.Next(-5, 5);
            trees.transform.position = new Vector3(x, y, z);
            // set scale
            int x2 = random.Next(1, 3);
            int y2 = random.Next(1, 3);
            int z2 = random.Next(1, 3);
            trees.transform.localScale = new Vector3(x2, y2, z2);
            var treesRenderer = trees.GetComponent<Renderer>();
            Color treesColor = new Color(0.4f, 0.8f, 0.4f);
            treesRenderer.material.SetColor("_Color", treesColor);

            trees.transform.parent = forest.transform;
        }
    }
    void CreatePyramid()
    {
        GameObject pyramid = new GameObject();
        pyramid.name = "Pyramid";

        //For loop that creates the 1st pyramid layer
        for (int i = 0; i < 25; i++)
        {
            float spacer = 1.1f; //Each stone should be at least this distance apart
            int iQuotient = i / 5; //This divides i's value by 5 to help determine X position
            float spacerAndIQuotientProduct = spacer * iQuotient; //This is the product of spacer and iQuotient, which returns the x value for each stone
            float multipleModuloResult = (i % 5) * spacer; //This formula returns the proper value for the z-axis

            GameObject stoneForLayer1 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            stoneForLayer1.transform.position = new Vector3(spacerAndIQuotientProduct, .5f, multipleModuloResult);

            //Sets name of GameObject to "Layer 1 Stone"
            stoneForLayer1.name = "Layer 1 Stone";

            //Sets color of GameObject to a hue similar to professor's example
            var stoneForLayer1Renderer = stoneForLayer1.GetComponent<Renderer>();
            Color stoneForLayer1Color = new Color(0.8f, 0.8f, 0.1f);
            stoneForLayer1Renderer.material.SetColor("_Color", stoneForLayer1Color);

            stoneForLayer1.transform.parent = pyramid.transform;
        }

        //For loop that creates the 2nd pyramid layer
        for (int i = 0; i < 16; i++)
        {
            float spacer = 1.1f; //Each stone should be at least this distance apart
            int iQuotient = i / 4; //This divides i's value by 4 to help determine X position
            float spacerAndIQuotientProduct = spacer * iQuotient; //This is the product of spacer and iQuotient, which returns the x value for each stone
            float multipleModuloResult = (i % 4) * spacer; //This formula returns the proper value for the z-axis

            GameObject stoneForLayer2 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            stoneForLayer2.transform.position = new Vector3(.55f + spacerAndIQuotientProduct, 1.5f, .55f + multipleModuloResult);

            //Sets name of GameObject to "Layer 2 Stone"
            stoneForLayer2.name = "Layer 2 Stone";

            //Sets color of GameObject to a hue similar to professor's example
            var stoneForLayer2Renderer = stoneForLayer2.GetComponent<Renderer>();
            Color stoneForLayer2Color = new Color(0.9f, 0.7f, 0.4f);
            stoneForLayer2Renderer.material.SetColor("_Color", stoneForLayer2Color);

            stoneForLayer2.transform.parent = pyramid.transform;
        }


        //For loop that creates the 3rd pyramid layer
        for (int i = 0; i < 9; i++)
        {
            float spacer = 1.1f; //Each stone should be at least this distance apart
            int iQuotient = i / 3; //This divides i's value by 3 to help determine X position
            float spacerAndIQuotientProduct = spacer * iQuotient; //This is the product of spacer and iQuotient, which returns the x value for each stone
            float multipleModuloResult = (i % 3) * spacer; //This formula returns the proper value for the z-axis

            GameObject stoneForLayer3 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            stoneForLayer3.transform.position = new Vector3(1.1f + spacerAndIQuotientProduct, 2.5f, 1.1f + multipleModuloResult);

            //Sets name of GameObject to "Layer 3 Stone"
            stoneForLayer3.name = "Layer 3 Stone";

            //Sets color of GameObject to a hue similar to professor's example
            var stoneForLayer3Renderer = stoneForLayer3.GetComponent<Renderer>();
            Color stoneForLayer3Color = new Color(0.9f, 0.5f, 0.5f);
            stoneForLayer3Renderer.material.SetColor("_Color", stoneForLayer3Color);

            stoneForLayer3.transform.parent = pyramid.transform;
        }

        //For loop that creates the 3rd pyramid layer
        for (int i = 0; i < 4; i++)
        {
            float spacer = 1.1f; //Each stone should be at least this distance apart
            int iQuotient = i / 2; //This divides i's value by 2 to help determine X position
            float spacerAndIQuotientProduct = spacer * iQuotient; //This is the product of spacer and iQuotient, which returns the x value for each stone
            float multipleModuloResult = (i % 2 * spacer); //This formula returns the proper value for the z-axis

            GameObject stoneForLayer4 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            stoneForLayer4.transform.position = new Vector3(1.65f + spacerAndIQuotientProduct, 3.5f, 1.65f + multipleModuloResult);

            //Sets name of GameObject to "Layer 4 Stone"
            stoneForLayer4.name = "Layer 4 Stone";

            //Sets color of GameObject to a hue similar to professor's example
            var stoneForLayer4Renderer = stoneForLayer4.GetComponent<Renderer>();
            Color stoneForLayer4Color = Color.magenta;
            stoneForLayer4Renderer.material.SetColor("_Color", stoneForLayer4Color);

            stoneForLayer4.transform.parent = pyramid.transform;
        }

        GameObject stoneForLayer5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        stoneForLayer5.transform.position = new Vector3(2.2f, 4.5f, 2.2f);

        //Sets name of GameObject to "Layer 5 Stone"
        stoneForLayer5.name = "Layer 5 Stone";

        //Sets color of GameObject to a hue similar to professor's example
        var stoneForLayer5Renderer = stoneForLayer5.GetComponent<Renderer>();
        Color stoneForLayer5Color = Color.red;
        stoneForLayer5Renderer.material.SetColor("_Color", stoneForLayer5Color);

        stoneForLayer5.transform.parent = pyramid.transform;

    }
}
