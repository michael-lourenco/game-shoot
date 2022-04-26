using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMonoBehaviour : MonoBehaviour
{
    public BulletSkill skill;
    private Vector3 mousePos;
    private Camera mainCamera;
    private Rigidbody2D rb;
    private float force;

    // Start is called before the first frame update
    void Start()
    {
        force = skill.force;

        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0, rot + 90);
    }
    
    public int DoDamage() {
        return skill.attack;
    }
    
}
