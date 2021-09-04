using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandwich 
{
    List<Ingredient> ingredients;
    
    public void AddIngredient(Ingredient ingredient)
    {
        if (ingredients == null)
            ingredients = new List<Ingredient>();
        ingredients.Add(ingredient);
    }

    public int CalculateScore()
    {
        int score = 0;
        for(int i=0; i < ingredients.Count-1; i++)
        {
            score += ingredients[i].GetAfinity(ingredients[i + 1].GetName());
        }
        return score;
    }
}
