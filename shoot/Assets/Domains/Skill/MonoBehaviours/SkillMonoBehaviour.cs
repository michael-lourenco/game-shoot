using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillMonoBehaviour : MonoBehaviour
{
    public SkillBlueprint skill;
    private Vector3 mousePos;
    private Camera mainCamera;
    private Rigidbody2D rb;
    private float force;

    private int attack;
    // Start is called before the first frame update
    void Start()
    {
        attack = skill.attack;
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public int DoDamage() {
        return this.attack;
    }
    
}
