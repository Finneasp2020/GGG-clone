using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using charset = 'UTF-8';

public class cylinderScript : MonoBehaviour

{
    public GameObject cylinder;
    private Vector3 scaleChange;

    // Start is called before the first frame update
    public GameObject sphere;

    public Vector3 startScaling = new Vector3(-2, 0, 0);
    void Start()
    {
    sphere = GameObject.Find("Sphere");
    scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
}

// Update is called once per frame
void Update()
    {
        if (sphere.transform.position.x >= startScaling.x)
        {
            transform.localScale += scaleChange;
        }
            
        if (transform.localScale.y < 0.1f || transform.localScale.y > 1.0f)
        {
            scaleChange = -scaleChange;
        }
    }
}
