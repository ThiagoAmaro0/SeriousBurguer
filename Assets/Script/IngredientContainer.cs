using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("IngredientCollection")]
public class IngredientContainer
{
    [XmlArray("Ingredients"), XmlArrayItem("Ingredient")]
    public Ingredient[] data;
    public static IngredientContainer Load(string path)
    {
        var serializer = new XmlSerializer(typeof(IngredientContainer));
        using (var stream = new FileStream(path, FileMode.Open))
        {
            return serializer.Deserialize(stream) as IngredientContainer;
        }
    }
}
