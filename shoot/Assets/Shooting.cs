using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 mousePos;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    private float timer;
    public float timeBetweenFiring;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;

        float rotationZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0,0, rotationZ);

        if(!canFire)
        {
            timer += Time.deltaTime;
            if(timer > timeBetweenFiring){
                canFire = true;
                timer = 0;
            }

        }

        if(Input.GetMouseButton(0) && canFire) 
        {
            Instantiate(bullet, bulletTransform.position, Quaternion.identity);
            canFire = false;
        }
    }
}
