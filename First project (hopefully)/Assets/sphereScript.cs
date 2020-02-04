using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereScript : MonoBehaviour
{
    public Vector3 startPosition = new Vector3(-4, 0, 0);
    public Vector3 endPosition = new Vector3(3, 0, 0);
    public float movementSpeed = 5;
    public Vector3 currentPosition = new Vector3(0, 0, 0);
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;
        if (transform.position != endPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, movementSpeed * Time.deltaTime);
        }else
        {
            transform.position = startPosition;
        }
        Debug.Log(transform.position);
    }
}
