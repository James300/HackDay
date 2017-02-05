using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : Selectable, IEntity
{
    public abstract void Attack(IEntity target);
	
}
