// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.Metadata
{
    /// <summary>
    ///     Represents a check constraint in the <see cref="IEntityType" />.
    /// </summary>
    public interface ICheckConstraint
    {
        /// <summary>
        ///     Gets the name of the check constraint in the database.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     The <see cref="IEntityType" /> in which this check constraint is defined.
        /// </summary>
        IEntityType EntityType { get; }

        /// <summary>
        ///     Gets the constraint sql used in a check constraint in the database.
        /// </summary>
        string Sql { get; }
    }
}
