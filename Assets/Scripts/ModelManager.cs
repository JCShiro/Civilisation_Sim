using Unity.Mathematics;
using UnityEngine;

public class ModelManager : MonoBehaviour
{
    GameObject myObject;
    int modelIndex = 0;
    public GameObject[] gameObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myObject = Instantiate(gameObjects[modelIndex], transform);
        print("myObject = " + myObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateModel()
    {
        Destroy(myObject);
        modelIndex++;
        if (modelIndex >= gameObjects.Length)
        {
            modelIndex = 0;
        }
        // myObject = Instantiate(gameObjects[modelIndex], transform);
        print("model index = " + modelIndex);
    }
}
