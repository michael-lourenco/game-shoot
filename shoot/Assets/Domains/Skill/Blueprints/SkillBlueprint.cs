using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
[CreateAssetMenu(fileName = "Skill", menuName = "ScriptableObjects/Skills", order = 1)]
public class SkillBlueprint : ScriptableObject
{
    public string skillName;
    public int attack;

    public float force;

}