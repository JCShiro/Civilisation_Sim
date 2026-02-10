using Unity.Mathematics;
using UnityEngine;

public class ModelManager : MonoBehaviour
{
    public GameObject[] gameObjects;
    float timestamp;
    public float spawnRate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 position = new Vector3(0, 0, 0);
        Quaternion rotation = quaternion.AxisAngle(0, 0);
        GameObject scene = Instantiate(gameObjects[0], position, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
