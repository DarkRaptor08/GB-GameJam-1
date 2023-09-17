using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject prefab;
    private int i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        i++;
        if(i > 55)
        {
            Instantiate(prefab, new Vector3(10, Random.Range(-6.0f, 6.0f), 0), Quaternion.identity);
            i = 0;
        }
        
    }
}
