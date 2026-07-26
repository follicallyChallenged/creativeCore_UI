using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject rot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rot.transform.Rotate(0, 1, 0);
    }
}
