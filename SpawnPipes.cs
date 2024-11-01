using System.Collections;
using System.Collections.Generic;
using UnityEngine

public class SpawnPipes : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    [SerializeField] Transform pipeHolder;
    [SerializeField] float spawnInterval = 1f;
    [SerializeField] float spawnHeight;
    
    float spawnTimerDelta;
    public static float spawnSpeedMultiplier = 1f;


    private void Update()
    {
        if(spawnTimerDelta <= 0f)   
        {
            Vector3 pos = transform.position + new Vector3(0f, spawnHeight),0f};
            Spawn(pos);
            spawnTimerDelta = spawnInterval * (1 / spawnSpeedMultiplier);
    }

        spawnTimerDelta -= Time.deltaTime;
    }