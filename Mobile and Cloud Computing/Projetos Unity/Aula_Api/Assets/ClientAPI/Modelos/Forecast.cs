using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]

public class Forecast
{
    public string date { get; set; }
    public string weekday { get; set; }
    public string max { get; set; }
    public string min { get; set; }
    public string description { get; set; }
    public string condition { get; set; }
}
