﻿using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class AspnetSchemaVersions
    {
        public string Feature { get; set; }
        public string CompatibleSchemaVersion { get; set; }
        public bool IsCurrentVersion { get; set; }
    }
}
