using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("ChallengeObj Game Object")]
    public GameObject challengeObject;
    [Header("Default spawn delay time")]
    public float spawnDelay = 1f;
    [Header("Default spawn time")]
    public float spawnTime = 2f;

    [SerializeField]
    private float height;
    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(15, height, 0);
    }
    void InstantiateObjects()
    {
        Instantiate(challengeObject, transform.position, transform.rotation);
    }
}
