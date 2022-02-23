using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_ANDROID || UNITY_IOS
        if (Input.touchCount == 0) { return; }
        if (Input.GetTouch(0).phase == TouchPhase.Began)
#else
        if (Input.GetKeyDown(KeyCode.Space))
#endif
        {
            if (!GameManager.instance.CanShoot)
            {
                return;
            }

            Instantiate(projectilePrefab, transform.position, Quaternion.LookRotation(transform.forward, Vector3.up));
        }
    }
}
