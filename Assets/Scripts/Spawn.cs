using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [Header("Blocks")]

    public GameObject[] Block;
    public Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        SpawnBlocks();
    }

    // Function: Spawning Blocks
    public void SpawnBlocks()
    {
        int randomBlock = Random.Range(0, Block.Length);
        GameObject block = Instantiate(Block[randomBlock], spawnPos, Quaternion.identity) as GameObject;
    }
}
