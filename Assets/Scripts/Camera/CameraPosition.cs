using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public static float distance;
    Vector3 previousPosition;
    Vector3 currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        distance = 0;
        previousPosition = this.transform.position;
        StartCoroutine(ExampleCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = this.transform.position;
    }

    IEnumerator ExampleCoroutine()
    {
        for(; ; )
        {
            yield return new WaitForSeconds(2);
            //Debug.Log("xxxx " + currentPosition + " " + previousPosition + );
            distance = distance + Vector3.Distance(currentPosition, previousPosition);
            Debug.Log("xxxx " + distance);
            previousPosition = currentPosition;
           /* if(distance>20)
            {
                distance = 0;
            }*/
        }
    }
}
