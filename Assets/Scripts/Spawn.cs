using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [Header("Blocks")]
    public GameObject[] Block;
    public GameObject[] shadows;
    public Vector3 spawnPos;
    public Vector3 shadowPos;

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
        GameObject shadowBlock = Instantiate(shadows[randomBlock], shadowPos, Quaternion.identity) as GameObject;
    }
}
