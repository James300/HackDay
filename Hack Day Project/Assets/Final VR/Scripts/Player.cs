using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    public override void Attack(IEntity target)
    {
        GameController.SelectEnemy(() =>
        {
            PerformAttack();
        });
    }

    private void PerformAttack()
    {
        Debug.Log("I attacked you!");
    }

    public override void Select()
    {
        base.Select();
    }

    public override void Unselect()
    {
        base.Unselect();
    }
}
