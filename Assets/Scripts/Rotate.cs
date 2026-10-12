using UnityEngine;

public class Rotate : MonoBehaviour
{

    public bool halfTurn = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (halfTurn)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * 5);
        }
        else
        {
            transform.Rotate(Vector3.up, Time.deltaTime * 10);
        }
    }
}
