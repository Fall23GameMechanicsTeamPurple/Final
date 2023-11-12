using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using System;

public class CreateCard : Unit
{
    [DoNotSerialize]
    public ControlInput inputTrigger;

    [DoNotSerialize]
    public ControlOutput outputTrigger;

    [DoNotSerialize]
    public ValueInput name;

    [DoNotSerialize]
    public ValueInput description;

    [DoNotSerialize]
    public ValueInput image;

    [DoNotSerialize]
    public ValueInput costs;

    [DoNotSerialize]
    public ValueInput cardType;

    [DoNotSerialize]
    public ValueOutput card;

    private Card result;

    protected override void Definition()
    {
        inputTrigger = ControlInput("CreateCard", (flow) => {
            result = new Card();
            result.Name = flow.GetValue<string>(name);
            result.Description = flow.GetValue<string>(description);
            result.Image = flow.GetValue<Sprite>(image);
            result.Costs = flow.GetValue<List<int>>(costs);
            result.CardType = flow.GetValue<CardType>(cardType);
          
            return outputTrigger;
        
        });
        outputTrigger = ControlOutput("Output");

        name = ValueInput<string>("Name", "Default Name");
        description = ValueInput<string>("Description", "Default Description");
        image = ValueInput<Sprite>("Image", null);
        costs = ValueInput<List<int>>("Costs", new List<int>());
        cardType = ValueInput<CardType>("CardType", CardType.Tower);

        card = ValueOutput<Card>("Card", (flow) =>
        {
            return result;
        });
    }

}
