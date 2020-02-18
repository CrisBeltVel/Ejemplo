using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Resorte_kutta : MonoBehaviour
{
    public Vector3 pos;
    public float v = -10;
    public float miu = 0.4f;
    public float k = 1200;
    float k1;
    float k2;
    float k3;
    float k4;
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

        k1 =t * ((-miu * v - k * pos.x) / m);

        k2 = t * ((-miu * (v+k1/2) - k * (pos.x+ t/2)) / m);

        k3 = t * ((-miu*(v + k2 / 2) - k*(pos.x + t / 2)) / m);

        k4 = t * ((-miu * (v + k3) - k * (pos.x + t)) / m);

        v = v + (2*k1+k2+k3+2*k4)/6;
        pos.x = pos.x + t * (v);
        
        gameObject.GetComponent<Transform>().position = pos;
    }
}
