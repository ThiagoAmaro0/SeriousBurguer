using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

[System.Serializable]
public class Afinity
{
    [XmlElement("upName")]
    public string upName;
    [XmlElement("value")]
    public int value;

    public int GetValue()
    {
        return value;
    }
}
