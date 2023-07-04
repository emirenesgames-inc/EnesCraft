using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public GameObject player;

    public int SizeX;
    public int SizeZ;

    float seed;
    public int GroundHeight;
    public float ChunkDetay;
    public float ChunkHeight;

    public GameObject[] Blok;

    void Start()
    {
        BlokChunk();
        seed = Random.Range(10, 9999999);

        Debug.Log("Seed: " + seed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BlokChunk()
    {
        for (int x = 0; x < SizeX; x++)
        {
            for (int z = 0; z < SizeZ; z++)
            {
                int maxY = (int)(Mathf.PerlinNoise((x / 2 + seed) / ChunkDetay, (z / 2 + seed) / ChunkDetay) * ChunkHeight);
                maxY += GroundHeight;

                GameObject Cimen = Instantiate(Blok[0], new Vector3(x, maxY, z), Quaternion.identity)as GameObject;
                Cimen.transform.SetParent(GameObject.FindGameObjectWithTag("Block").transform);

                for (int y = 0; y < maxY; y++)
                {
                    int ToprakLayers = Random.Range(1, 5);
                    if (y >= maxY - ToprakLayers)
                    {
                        GameObject Toprak = Instantiate(Blok[1], new Vector3(x, y, z), Quaternion.identity) as GameObject;
                        Toprak.transform.SetParent(GameObject.FindGameObjectWithTag("Block").transform);
                    }
                    else
                    {
                        GameObject Tas = Instantiate(Blok[2], new Vector3(x, y, z), Quaternion.identity) as GameObject;
                        Tas.transform.SetParent(GameObject.FindGameObjectWithTag("Block").transform);
                    }  
                }
                
                if (x == (int)(SizeX / 2) && z == (int)(SizeZ / 2))
                {
                    Instantiate(player, new Vector3(x, maxY + 3, z), Quaternion.identity); 
                }
            }
        }
    }
}
