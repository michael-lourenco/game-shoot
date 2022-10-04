using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bomb", menuName = "Skills/Bomb", order = 1)]
public class BombSkill : SkillBlueprint
{

    public override void Activate(GameObject parent, Transform transformLocationToInstantiate) {
        Debug.Log("BOMB SKILL");
        Instantiate(parent, transformLocationToInstantiate.position, Quaternion.identity);
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
