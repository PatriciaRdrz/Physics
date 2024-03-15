using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstPrefab : MonoBehaviour
{
    public GameObject[] spawneable;
    //public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();
        //Instantiate(prefab, new Vector3(0, 1, 0), Quaternion.identity);
    }
    private void SpawnObjects()
    {
        for(int i =0; i < spawneable.Length; i++)
        {
            Instantiate(spawneable[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
