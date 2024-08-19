﻿using System;
using System.Collections.Generic;

namespace Kiota.Builder.Refiners;
public class JavaReservedNamesProvider : IReservedNamesProvider
{
    private readonly Lazy<HashSet<string>> _reservedNames = new(() => new(StringComparer.OrdinalIgnoreCase) {
        "abstract",
        "assert",
        "boolean",
        "break",
        "byte",
        "case",
        "catch",
        "char",
        "class",
        "const",
        "continue",
        "default",
        "do",
        "double",
        "else",
        "enum",
        "equals",
        "extends",
        "false",
        "final",
        "finalize",
        "finally",
        "float",
        "for",
        "getclass",
        "goto",
        "if",
        "implements",
        "import",
        "instanceof",
        "int",
        "interface",
        "long",
        "map",
        "native",
        "new",
        "notify",
        "notifyall",
        "null",
        "object",
        "package",
        "private",
        "protected",
        "public",
        "return",
        "short",
        "static",
        "strictfp",
        "super",
        "switch",
        "synchronized",
        "this",
        "throw",
        "throws",
        "tostring",
        "transient",
        "true",
        "try",
        "void",
        "volatile",
        "wait",
        "while",
        "BaseRequestBuilder",
        "MultipartBody",
        "HashMap",
        "Collection",
        "Objects",
        "InputStream",
        "BigDecimal",
    });
    public HashSet<string> ReservedNames => _reservedNames.Value;
}
