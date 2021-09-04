using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using static Afinity;

public class Ingredient 
{
    [XmlAttribute("name")]
    public string name;
    [XmlArray("afinities"), XmlArrayItem("afinity")]
    public Afinity[] afinities;
    
    public int GetAfinity(string up)
    {
        foreach(Afinity a in afinities)
        {
            if(a.upName == up)
            {
                return a.value;
            }
        }
        return 0;
    }
    public Afinity[] GetAfinities()
    {
        return afinities;
    }
    public string GetName()
    {
        return name;
    }
}
