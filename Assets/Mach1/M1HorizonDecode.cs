﻿//  Mach1 SDK
//  Copyright © 2017 Mach1. All rights reserved.
//

//#define LEGACY_POSITIONAL

using UnityEngine;
using System.Collections;
using System.IO;

public class M1HorizonDecode : M1Base
{
    public M1HorizonDecode()
    {
        InitComponents(4);
        m1Positional.setDecodeAlgoType(Mach1.Mach1DecodeAlgoType.Mach1DecodeAlgoHorizon_4);
    }
}
