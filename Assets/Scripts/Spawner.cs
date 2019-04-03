using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    //groups
    public GameObject[] groups;

    public void SpawnNext()
    {
        // random index
        int i = Random.Range(0, groups.Length);

        // spawn group at current location
        Instantiate(groups[i],
            transform.position,
            Quaternion.identity);
    }

	// Use this for initialization
	void Start () {
        SpawnNext();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
