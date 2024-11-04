using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : IAttack
{

    public int Damage {  get; set; }

    public void Attack()
    {
        Damage = 2;
        Debug.Log($"Player Damage: {Damage}");
    }

    //camel case: objectName
    //pascal case: ObjectName
    //snake case: object_name

    //int hp;
    //public int Hp
    //{
    //    get { return hp; }
    //    set { hp = value; }
    //}

    //string name;
    //public string name {get; set;}
}
