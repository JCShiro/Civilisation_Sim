using Unity.Mathematics;
using UnityEngine;

public class ModelManager : MonoBehaviour
{
    public GameObject[] gameObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 position = new Vector3(0, 0, 0);
        Quaternion rotation = Quaternion.AngleAxis(0, transform.up);
        GameObject myObject = Instantiate(gameObjects[0], position, rotation);
        print("myObject = " +myObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
