using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using System;

public class CreateTagDict : Unit
{
    [DoNotSerialize]
    public ControlInput inputTrigger;

    [DoNotSerialize]
    public ControlOutput outputTrigger;

    [DoNotSerialize]
    public ValueOutput dict;

    private Dictionary<BulletTag, bool> result;

    protected override void Definition()
    {
        inputTrigger = ControlInput("CreateTagDict", (flow) => {
            result = new Dictionary<BulletTag, bool>();
            result.Add(BulletTag.Piercing, false);
            result.Add(BulletTag.Poison, false);
            result.Add(BulletTag.Explosion, false);


            return outputTrigger;

        });
        outputTrigger = ControlOutput("Output");

        dict = ValueOutput<Dictionary<BulletTag, bool>>("Dict", (flow) =>
        {
            return result;
        });
    }

}
