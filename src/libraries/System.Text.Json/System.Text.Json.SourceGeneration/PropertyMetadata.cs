﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace System.Text.Json.SourceGeneration
{
    [DebuggerDisplay("Name={Name}, Type={TypeMetadata}")]
    internal class PropertyMetadata
    {
        public string Name { get; init; }

        public TypeMetadata TypeMetadata { get; init; }
    }
}
