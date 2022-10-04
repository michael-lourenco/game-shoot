using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkillHolderMonoBehaviour : MonoBehaviour
{
    public Image skillImage;
    public TextMeshProUGUI skillCooldownText;
    //public SkillBlueprint skill;

    public GameObject skillPrefab;

    public Transform transformLocationToInstantiate;
    private Vector3 mousePos;
    private Camera mainCamera;
    private Rigidbody2D rb;
    private float force;
    private float cooldownTime;
    private float activeTime;
    private int attack;
    public SkillMonoBehaviour skillMonoBehaviour;
    enum SkillState {
        READY,
        ACTIVE,
        COOLDOWN
    }

    SkillState state = SkillState.READY;

    public KeyCode key;

    void Start() {
        skillCooldownText.text = "";
        skillMonoBehaviour = skillPrefab.GetComponent<SkillMonoBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case  SkillState.READY:
                UpdateReadyState();
            break;
            case  SkillState.ACTIVE:
                UpdateActiveState();
            break;
            case  SkillState.COOLDOWN:
                UpdateCoolDown();
            break;
        }

    }

    void UpdateReadyState() {
        if (Input.GetKeyDown(key)) {    
            skillMonoBehaviour.skill.Activate(skillPrefab.gameObject, transformLocationToInstantiate);
            state = SkillState.ACTIVE;
            activeTime = skillMonoBehaviour.skill.activeTime;
            skillImage.GetComponent<Image>().color = new Color32(255,255,255,255);                    
        }
    }

    void UpdateActiveState() {
        if(activeTime >= 0f) {
            activeTime -= Time.deltaTime; 
            skillImage.GetComponent<Image>().color = new Color32(255,255,255,0);
        } 
        else {
            skillMonoBehaviour.skill.BeginCooldown(skillPrefab.gameObject);
            state = SkillState.COOLDOWN;
            cooldownTime = skillMonoBehaviour.skill.cooldownTime;
            skillImage.fillAmount = 0f;
            activeTime = 0f;
        }
    }

    void UpdateCoolDown() {
        if(cooldownTime >= 0f) {
            cooldownTime -= Time.deltaTime;
            skillCooldownText.text = Math.Ceiling(cooldownTime).ToString();
            skillImage.fillAmount += 1 / cooldownTime * Time.deltaTime;
            skillImage.GetComponent<Image>().color = new Color32(255,255,255,20);
        } 
        else {
            skillImage.fillAmount = 1f;
            cooldownTime = 0f;
            skillCooldownText.text = "";
            skillImage.GetComponent<Image>().color = new Color32(255,255,255,255); 
            state = SkillState.READY;
        }
    }

}
