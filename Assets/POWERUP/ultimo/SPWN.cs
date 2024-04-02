using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPWN : MonoBehaviour
{
    //quando il gioco inizia, vogliamo spawnare oggetti
    public GameObject objectToSpawn;
    public float timeToSpawn;
    private float currentTimeToSpawn;
    


    // Start is called before the first frame update
    void Start()
    {
      
     

        //all'interno delle parentesi metto l'oggetto che voglio spawnare
        //Quaternion ignora entrambi i position settings

    }


    void Update()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
        }

        public void SpawnObject()
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
        }
}
