using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
[CreateAssetMenu]
public class CaitPlayer: PlayerBlueprint
{
    public Transform rotationPointTransform;

    public override void Activate(GameObject parent) {
        Debug.Log("CAIT PLAYER ");


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
        return this.basicAttack.attack;
    }
}
