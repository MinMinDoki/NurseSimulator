using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnlocations;
    public GameObject[] PatientPrefab;
    public GameObject[] PatientClone;
    public GameObject GameOver;


    void Spawnsomething()
    {
        int LocationRoll = Random.Range(0, spawnlocations.Length);
        if (spawnlocations[LocationRoll].childCount == 0)
        {
            int PatientRoll = Random.Range(0, PatientPrefab.Length);
            Instantiate(PatientPrefab[PatientRoll], spawnlocations[LocationRoll].position, spawnlocations[LocationRoll].rotation, spawnlocations[LocationRoll]);
        }
        if (spawnlocations[0].childCount > 0 && spawnlocations[1].childCount > 0 && spawnlocations[2].childCount > 0 && spawnlocations[3].childCount > 0)
        {
            Debug.Log("Game Over");
            GameOver.SetActive(true);
        }
        
    }

    
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating( "Spawnsomething", 5.0f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
