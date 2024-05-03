using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject prefab; // Префаб объекта, который мы будем создавать
    public Transform spawnPoint; // Точка спауна для новых объектов

    void Update()
    {
        // Создание нового объекта при нажатии на клавишу "Space"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        }

        // Уничтожение всех объектов при нажатии на клавишу "R"
        if (Input.GetKeyDown(KeyCode.R))
        {
            DestroyAllObjects();
        }
    }

    void DestroyAllObjects()
    {
        GameObject[] spawnedObjects = GameObject.FindGameObjectsWithTag("SpawnedObject");
        foreach (GameObject obj in spawnedObjects)
        {
            Destroy(obj);
        }
    }
}
