using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawner : MonoBehaviour
{
    public List<GameObject> objectPrefabs = new List<GameObject>();
    [Header ("Audio")]
    public AudioClip soundEffect;
    [Header ("Spawn Info")]
    public float timeToSpawn;
    private float currentTimeToSpawn;
    public bool isRandomized;
    [Header ("X Spawn Range")]
      public float xMin;
      public float xMax;
  
      // the range of y
    [Header ("Y Spawn Range")]
      public float yMin;
      public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        //currentTimeToSpawn = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
            //SpawnObject();
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }
    
    public void SpawnObject(){
        int index = isRandomized ? Random.Range(0,objectPrefabs.Count) : 0; //if true set to random range
        if (objectPrefabs.Count > 0)
        {
            Vector2 pos = new Vector2 (Random.Range (xMin, xMax), Random.Range (yMin, yMax));
            Instantiate(objectPrefabs[index], pos, transform.rotation);
        }
    }
}
