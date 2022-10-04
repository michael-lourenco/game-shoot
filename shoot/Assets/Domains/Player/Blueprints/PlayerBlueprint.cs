using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
[CreateAssetMenu(fileName = "Player", menuName = "ScriptableObjects/Players", order = 1)]
public class PlayerBlueprint : ScriptableObject
{
    public string playerName;
    public string lore;
    public string blurb;
    public SkillBlueprint basicAttack;
    public float force;

    public List<SkillBlueprint> skills;

    public List<StatsBlueprint> stats;

    public virtual void Activate(GameObject parent) {}
    public virtual void BeginCooldown(GameObject parent) {}

}