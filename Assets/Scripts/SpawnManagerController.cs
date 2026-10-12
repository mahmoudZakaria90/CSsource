using UnityEngine;

public class SpawnManagerController : MonoBehaviour
{
    public GameObject prefab;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        InvokeSpawnPrefab();
    }

    void SpawnPrefab()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

    public void InvokeSpawnPrefab()
    {
        Invoke("SpawnPrefab", 5);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
