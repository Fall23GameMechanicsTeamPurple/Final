using System;
using UnityEngine;
using Unity.VisualScripting;
using System.Collections.Generic;

[Inspectable]
public class Tower 
{
    [Inspectable]
    public int Damage { get; set; }

    [Inspectable]
    public int Range { get; set; }

    [Inspectable]
    public List<Unit> OnFireModifier { get; set; }
}
