using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float speed;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello", this);
    }

    // Update is called once per frame
    void Update()
    {
        //Move back and forth
        transform.position += 
            new Vector3(Mathf.Sin(Time.timeSinceLevelLoad * speed) * distance, 0, 0) * Time.deltaTime;
    }
}
