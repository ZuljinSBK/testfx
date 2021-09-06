﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    using System;

    /// <summary>
    /// Specification for when to run class cleanup methods.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class ClassCleanupSequencingAttribute : Attribute
    {
        private const ClassCleanupLifecycle DefaultClassCleanupLifecycle = ClassCleanupLifecycle.EndOfAssembly;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassCleanupSequencingAttribute"/> class.
        /// </summary>
        public ClassCleanupSequencingAttribute()
        {
            this.LifecyclePosition = DefaultClassCleanupLifecycle;
        }

        /// <summary>
        /// Gets or sets when to run class cleanup methods.
        /// </summary>
        public ClassCleanupLifecycle LifecyclePosition
        {
            get;
            set;
        }
    }
}