using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerate : MonoBehaviour
{
    
    private float positionX;
    private float positionY;
    private float positionZ;
    
    private void TargetGenerate() //Targetの生成
    {
        positionX = Random.Range(-8.0f, 8.0f);
        positionY = 2.0f;
        positionZ = 0.0f;
        Vector3 targetPosition = new Vector3(positionX,positionY,positionZ);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        TargetGenerate();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
