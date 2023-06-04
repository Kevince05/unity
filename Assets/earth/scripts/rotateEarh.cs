using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateEarh : MonoBehaviour
{
    [SerializeField] public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * speed, 0);
    }
}
