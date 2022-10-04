using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillMonoBehaviour : MonoBehaviour
{
    public SkillBlueprint skill;
    public Vector3 mousePos;
    public Camera mainCamera;
    public Rigidbody2D rb;
    public float force;

    
    // Start is called before the first frame update
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    public virtual int DoDamage() {
        return this.skill.attack;
    }
    
}
