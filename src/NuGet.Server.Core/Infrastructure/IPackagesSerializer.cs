// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 
using System.Collections.Generic;
using System.IO;

namespace NuGet.Server.Core.Infrastructure
{
    public interface IPackagesSerializer
    {
        void Serialize(IEnumerable<ServerPackage> packages, Stream stream);
        IEnumerable<ServerPackage> Deserialize(Stream stream);
    }
}