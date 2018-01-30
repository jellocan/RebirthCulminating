using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    // Use this for initialization
    public GameObject target;//select game object to follow
    private Vector3 targetPos;
    public float moveSpeed;
    private static bool CameraExists;
    void Start()
    {
        if(!CameraExists)
        {
            CameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = new Vector3(target.transform.position.x, target.transform.position.y, -10);//set the postion to go to
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);//move towards target pos at the interval
    }
}
