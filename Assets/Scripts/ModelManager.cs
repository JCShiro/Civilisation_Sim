using Unity.Mathematics;
using UnityEngine;
using System;

public class ModelManager : MonoBehaviour
{
    static Transform ManagerTransform; 
    public GameObject myObject;
    int modelIndex = 0;
    public GameObject[] gameObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ManagerTransform = transform;
        myObject = Instantiate(gameObjects[modelIndex], transform);
        myObject.name = "clone";
        print("myObject initiate = " + myObject.name);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateModel()
    {
        // print("myObject = " + myObject.name);
        GameObject clone = GameObject.Find("clone");
        try
        {
            print("myObject to be destroyed = " + clone.name);
            Destroy(clone);
        }
        catch (Exception e)
        {
            print(e);
        }
        modelIndex++;
        if (modelIndex >= gameObjects.Length)
        {
            modelIndex = 0;
        }
        myObject = Instantiate(gameObjects[modelIndex], ModelManager.ManagerTransform);
        myObject.name = "clone";
        print("myObject re-initiate = " + myObject.name);
        print("current object = " + gameObjects[modelIndex]);
    }
}
