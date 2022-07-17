using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
    protected int damage;
    protected string name;
    protected string description;

    protected abstract void Attack();

    public int GetDamage()
    {
        return damage;
    }
    public string GetName()
    {
        return name;
    }
    public string GetDescription()
    {
        return description;
    }
}
