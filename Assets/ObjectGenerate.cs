using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerate : MonoBehaviour
{
    
    private float positionX;
    private float positionY;
    private float positionZ;
    
    private void ObjectGenerate() //Targetの生成
    {
        positionX = Random.Range(-8.0f, 8.0f);
        positionY = 2.0f;
        positionZ = 0.0f;
        Vector3 targetPosition = new Vector3(positionX,positionY,positionZ);
    }

    private void ObjectMove()
    {
        transform.Translate(0.01f, 0, 0);
        if (transform.position.x >= 8.0f)
        {
            transform.position = new Vector3(-8.0f, 2.0f, 0.0f);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        ObjectGenerate();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
