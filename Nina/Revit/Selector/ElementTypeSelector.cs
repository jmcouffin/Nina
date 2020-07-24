﻿using Autodesk.Revit.DB;

namespace Nina.Revit
{
    public class ElementTypeSelector
    {
        public ElementType elementtype { get; set; }
        public string family { get; set; }
        public string type { get; set; }
        public string key { get; set; }
    }
}
