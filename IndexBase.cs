﻿using Microsoft.AspNetCore.Components;

namespace TrimestralniProjektMelka
{
    public class IndexBase : LayoutComponentBase
    {
        public string GetTextFromMethodInClass()
        {
            return "This text is derived from a C# .cs file within the assembly";
        }
    }
}