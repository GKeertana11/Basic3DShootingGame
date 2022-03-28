using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Stack<GameObject> bulletStack = new Stack<GameObject>();
    private GameObject bulletLaunched;

    public float speed;
    private static BulletLauncher instance;
    public static BulletLauncher Instance
    {
        get
        {
            if(instance==null)
            {
                instance = GameObject.FindObjectOfType<BulletLauncher>();
            }
            return instance;
        }
        
    }
    Rigidbody rb;
    void Start()
    {
        CreateBullet(); 
    }

    private void CreateBullet()
    {
        for (int i=0;i<20;i++)
        {
            bulletStack.Push(Instantiate(bulletPrefab));
            bulletPrefab.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBullet(10);
           //bulletLaunched= Instantiate(bulletPrefab,transform.position,Quaternion.identity);
            //
           
        }
    }

    private void SpawnBullet(int value)
    {
       for(int i=0;i<value;i++)
        {
           GameObject temp= bulletStack.Pop();
            temp.SetActive(true);
            temp.transform.position = transform.position;
            temp.GetComponent<Rigidbody>().velocity = Camera.main.transform.rotation * Vector3.forward * speed;
        }
    }
    public void BackToPool(GameObject obj)
        {
        bulletStack.Push(obj);
        obj.SetActive(false);
    }
}
