using System;
using UnityEngine;
using Unity.VisualScripting;
using System.Collections.Generic;

public enum CardType
{
    Boost,
    Tower,
    Spell
}

[Inspectable]
public class Card
{
    [Inspectable]
    public string Name {get; set;}

    [Inspectable]
    public string Description { get; set;}

    [Inspectable]
    public Sprite Image { get; set;}

    [Inspectable]
    public List<int> Costs { get; set; }

    [Inspectable]
    public CardType CardType { get; set; }
}


