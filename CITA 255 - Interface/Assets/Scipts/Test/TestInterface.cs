using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInterface : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //polyymorphism
        //Player newPlayer = new Player();
        //IAttack player = new Player();
        ////Player doSomething = new Attack(); -> cannot be done.
        //player.Attack();

        AttackObject(new Player());
        AttackObject(new Enemy());
    }
    void AttackObject(IAttack iAttack)
    {
        iAttack.Attack();
    }
}
