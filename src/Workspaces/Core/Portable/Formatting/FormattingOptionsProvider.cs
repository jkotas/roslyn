﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Immutable;
using System.Composition;
using Microsoft.CodeAnalysis.Options;
using Microsoft.CodeAnalysis.Options.Providers;

namespace Microsoft.CodeAnalysis.Formatting
{
    [ExportOptionProvider, Shared]
    internal class FormattingOptionsProvider : IOptionProvider
    {
        public ImmutableArray<IOption> Options { get; } = ImmutableArray.Create<IOption>(
            FormattingOptions.UseTabs,
            FormattingOptions.TabSize,
            FormattingOptions.IndentationSize,
            FormattingOptions.SmartIndent);
    }
}
