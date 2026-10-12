using UnityEngine;

public class DestroyOnOutBoundry : MonoBehaviour
{
    public SpawnManagerController spawnManagerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 50)
        {
            Destroy(gameObject);
            spawnManagerController.InvokeSpawnPrefab();
        }
    }


}
