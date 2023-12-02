using System;
using UnityEngine;
using Unity.VisualScripting;
using System.Collections.Generic;

public enum BulletTag
{
    KnockBack = 0,
    Poison = 1,
    Explosion = 2,
}

[Inspectable]
public class Bullet
{
    [Inspectable]
    public float damage { get; set; }

    [Inspectable]
    public GameObject target { get; set; }

    [Inspectable]
    public float explosionRadius { get; set; }

    [Inspectable]
    public Dictionary<BulletTag, bool> tags { get; set; }
}
