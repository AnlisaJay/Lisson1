using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject prefab; // ������ �������, ������� �� ����� ���������
    public Transform spawnPoint; // ����� ������ ��� ����� ��������

    void Update()
    {
        // �������� ������ ������� ��� ������� �� ������� "Space"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        }

        // ����������� ���� �������� ��� ������� �� ������� "R"
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
