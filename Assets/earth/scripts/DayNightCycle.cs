using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField]
    public float speed;

    private float start_position;
    private float end_position;
    private float sun_height;

    void Start()
    {
        start_position = transform.position.x;
        end_position = -start_position;
        sun_height = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
        if (transform.position.x > end_position)
        {
            transform.position = new Vector3(start_position, 0f, sun_height);
        } 
    }
}
