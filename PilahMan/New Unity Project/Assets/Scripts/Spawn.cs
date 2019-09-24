using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] rubish;
    public Vector3 spawnpos;
    public float nextspawn = 0f;
    public float spawnrate = 2f;
    public bool stop;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(nextspawn);

        while (!stop)
        {
            Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), 1));
            Instantiate(rubish[0], screenPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnrate);
        }

    }
}
