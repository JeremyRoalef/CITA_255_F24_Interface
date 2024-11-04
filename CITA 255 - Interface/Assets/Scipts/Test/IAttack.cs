using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Not a class, so cannot act as a blueprint for stuff
//Any class inheriting from this must do what this says
public interface IAttack
{
    //only takes in properties
    public int Damage {  get; set; }

    public void Attack(); //undefined method. 
}
