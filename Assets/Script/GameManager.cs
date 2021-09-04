using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Sandwich sandwich;
    IngredientContainer ingredientContainer;
    List<GameObject> ingredients;
    [SerializeField] float ingredientDelay;
    float nextIngredientTime;
    // Start is called before the first frame update
    void Start()
    {
        nextIngredientTime = Time.time;
        ingredientContainer = IngredientContainer.Load(Path.Combine(Application.dataPath, "ingredients.xml"));
        sandwich = new Sandwich();
        Debug.Log(ingredientContainer.data.Length);
        foreach(Ingredient i in ingredientContainer.data)
        {
            Debug.Log(i.GetName());
            foreach (Afinity a in i.GetAfinities())
            {
                Debug.Log(a.upName + " | " + a.value);
            }
        }
        ingredients = new List<GameObject>();
    }

    public void AddIngredient(int index)
    {
        if (nextIngredientTime <= Time.time)
        {
            nextIngredientTime = Time.time + ingredientDelay;
            sandwich.AddIngredient(ingredientContainer.data[index]);
            Debug.Log(sandwich.CalculateScore());
            UpdateSandwich(ingredientContainer.data[index]);
        }
    }
    void UpdateSandwich(Ingredient ingredient)
    {
        ingredients.Add(Instantiate(Resources.Load<GameObject>(ingredient.name)));
    }
}
