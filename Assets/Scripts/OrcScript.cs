using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcScript : EnemyBase
{
    void Update()
    {
        AttackPlayer();
    }
    public override void AttackPlayer()
    {
        print("Orc is attacking player");
    }
}
