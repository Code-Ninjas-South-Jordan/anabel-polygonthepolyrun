using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Destruction Timer")]
    public float timeToDestruction;
    void Start()
    {
        Invoke("DestroyObject", timeToDestruction);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void DestroyObject()
    {
        Destroy(gameObject);
    }
}