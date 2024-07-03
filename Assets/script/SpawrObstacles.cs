using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawrObstacles : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawr;
    private float spawrTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawrTime){
            Spawr();
            spawrTime = Time.time + timeBetweenSpawr;
        }
    }

    void Spawr(){
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }
}
