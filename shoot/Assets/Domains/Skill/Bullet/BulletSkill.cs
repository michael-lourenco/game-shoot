using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BulletSkill : SkillBlueprint
{

    public Transform rotationPointTransform;

    public override void Activate(GameObject parent) {
        Debug.Log("BULLET SKILL");


         Instantiate(parent, rotationPointTransform.position, Quaternion.identity);
    }

    public override void BeginCooldown(GameObject parent) {
        return;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int DoDamage() {
        return this.attack;
    }
}
