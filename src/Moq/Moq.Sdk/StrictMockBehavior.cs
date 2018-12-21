﻿using System;
using Stunts;

namespace Moq.Sdk
{
    /// <summary>
    /// Throws for all invocations performed, since it means a 
    /// mock behavior could not be applied before reaching this 
    /// fallback behavior.
    /// </summary>
    public class StrictMockBehavior : IStuntBehavior
    {
        IStuntBehavior fallback = new DefaultValueBehavior();

        /// <summary>
        /// Always returns <see langword="true" />
        /// </summary>
        public bool AppliesTo(IMethodInvocation invocation) => true;

        /// <summary>
        /// Throws <see cref="StrictMockException"/>.
        /// </summary>
        public IMethodReturn Execute(IMethodInvocation invocation, GetNextBehavior next)
        {
            if (invocation == null) throw new ArgumentNullException(nameof(invocation));

            if (!SetupScope.IsActive)
                throw new StrictMockException();

            // Otherwise, fallback to returning default values so that 
            // the fluent setup API can do its work.
            return fallback.Execute(invocation, next);
        }
    }
}
