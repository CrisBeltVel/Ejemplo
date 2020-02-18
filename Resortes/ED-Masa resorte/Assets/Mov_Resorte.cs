using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Euler

public class Mov_Resorte : MonoBehaviour
{
    public Vector3 pos;
    public float v=-10;
    public float miu = 0.4f;
    public float k = 1200;
    public float m = 15;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.deltaTime;
        pos = gameObject.GetComponent<Transform>().position;
        pos.x = pos.x + t*(v);
        v = v + t*((-miu * v - k * pos.x) / m);
       gameObject.GetComponent<Transform>().position=pos;
    }
}
