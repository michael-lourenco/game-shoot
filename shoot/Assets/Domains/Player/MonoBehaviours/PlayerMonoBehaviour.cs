using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMonoBehaviour : MonoBehaviour
{
    public PlayerBlueprint playerBlueprint;
    private string playerName;
    private int currentHp;
    private int maxHp;
    // Start is called before the first frame update
    void Start()
    {
        playerName = playerBlueprint.playerName;
        maxHp = getHp();
        currentHp = maxHp;
    }

    public int getHp() {
        var hp = 0;
        playerBlueprint.stats.Find(x => x.statsName.Equals("hp"));
        foreach (StatsBlueprint status in playerBlueprint.stats)
        {
            if(status.statsName == "hp"){
                hp = (int) status.value;
            } 
        }
        return hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Die() {
        Destroy(this.gameObject);
    }

    void takeDamage(int amount) {
        this.currentHp -= amount;
        if(currentHp <= 0) {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Enemy")
        {
            Debug.Log("COLIDIU");
            this.takeDamage(other.gameObject.GetComponent<EnemyMonoBehaviour>().DoDamage());
           
            Destroy(other.gameObject);
        }
    }

}
