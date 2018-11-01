using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour {
    public GameObject Prefab;
    public int        ToSpawn;

    private void Start() {
        SpawnN(ToSpawn);
    }

    private GameObject Spawn() {
        var obj = Instantiate(Prefab, GetSpawner().position, Quaternion.identity);
        obj.transform.name = "Coin";
        return obj;
    }

    private GameObject[] SpawnN(int n) {
        List<GameObject> spawned = new List<GameObject>();
        for (int i = 0; i < n; i++) {
            spawned.Add(Spawn());
        }
        return spawned.ToArray();
    }

    private Transform GetSpawner() {
        return transform.GetChild(Random.Range(0,transform.childCount));
    }
    
}