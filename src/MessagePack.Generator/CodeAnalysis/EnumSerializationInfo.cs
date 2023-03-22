﻿// Copyright (c) All contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MessagePack.Generator.CodeAnalysis;

public sealed record EnumSerializationInfo(string? Namespace, string Name, string FullName, string UnderlyingType) : IResolverRegisterInfo
{
    public string FormatterName => (this.Namespace == null ? this.Name : this.Namespace + "." + this.Name) + "Formatter";
}
