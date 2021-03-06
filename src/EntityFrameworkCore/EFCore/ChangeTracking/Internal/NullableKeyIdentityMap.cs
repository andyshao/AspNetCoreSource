// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Microsoft.EntityFrameworkCore.ChangeTracking.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public class NullableKeyIdentityMap<TKey> : IdentityMap<TKey>
    {
        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public NullableKeyIdentityMap(
            [NotNull] IKey key,
            [NotNull] IPrincipalKeyValueFactory<TKey> principalKeyValueFactory,
            bool sensitiveLoggingEnabled)
            : base(key, principalKeyValueFactory, sensitiveLoggingEnabled)
        {
        }

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public override void Add(InternalEntityEntry entry)
        {
            var key = PrincipalKeyValueFactory.CreateFromCurrentValues(entry);

            if (key == null)
            {
                if (Key.IsPrimaryKey())
                {
                    throw new InvalidOperationException(
                        CoreStrings.InvalidKeyValue(
                            entry.EntityType.DisplayName(),
                            PrincipalKeyValueFactory.FindNullPropertyInCurrentValues(entry).Name));
                }

                throw new InvalidOperationException(
                    CoreStrings.InvalidAlternateKeyValue(
                        entry.EntityType.DisplayName(),
                        PrincipalKeyValueFactory.FindNullPropertyInCurrentValues(entry).Name));
            }

            Add(key, entry);
        }

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public override void RemoveUsingRelationshipSnapshot(InternalEntityEntry entry)
        {
            var key = PrincipalKeyValueFactory.CreateFromRelationshipSnapshot(entry);

            if (key != null)
            {
                Remove(key, entry);
            }
        }
    }
}
