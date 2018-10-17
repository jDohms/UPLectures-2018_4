using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]

public class RootObject
{
    public string by { get; set; }
    public bool valid_key { get; set; }
    public Results results { get; set; }
    public double execution_time { get; set; }
    public bool from_cache { get; set; }
}
