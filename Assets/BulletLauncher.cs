using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    private GameObject bulletLaunched;
    public float speed;
    Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           bulletLaunched= Instantiate(bulletPrefab,transform.position,Quaternion.identity);
            bulletLaunched.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
           
        }
    }
}
