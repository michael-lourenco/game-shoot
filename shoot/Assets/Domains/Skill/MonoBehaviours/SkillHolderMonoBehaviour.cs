using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillHolderMonoBehaviour : MonoBehaviour
{

    public GameObject targetGameObject;
    public SkillBlueprint skill;
    private Vector3 mousePos;
    private Camera mainCamera;
    private Rigidbody2D rb;
    private float force;
    private float cooldownTime;
    private float activeTime;
    private int attack;

    enum SkillState {
        READY,
        ACTIVE,
        COOLDOWN
    }

    SkillState state = SkillState.READY;

    public KeyCode key;

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case  SkillState.READY:
                if (Input.GetKeyDown(key)) {    
                    skill.Activate(targetGameObject);
                    state = SkillState.ACTIVE;
                    activeTime = skill.activeTime;
                }
            break;
            case  SkillState.ACTIVE:
                if(activeTime > 0) {
                    activeTime -= Time.deltaTime;
                } 
                else{
                    skill.BeginCooldown(targetGameObject);
                    state = SkillState.COOLDOWN;
                    cooldownTime = skill.cooldownTime;
                }
            break;
            case  SkillState.COOLDOWN:
                if(cooldownTime > 0) {
                    cooldownTime -= Time.deltaTime;
                } 
                else{
                    state = SkillState.READY;
                }
            break;
        }

    }
}
