// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Utilities;

namespace Microsoft.EntityFrameworkCore.Metadata.Builders
{
    /// <summary>
    ///     <para>
    ///         Provides a simple API for configuring an <see cref="Index" />.
    ///     </para>
    ///     <para>
    ///         Instances of this class are returned from methods when using the <see cref="ModelBuilder" /> API
    ///         and it is not designed to be directly constructed in your application code.
    ///     </para>
    /// </summary>
    public class IndexBuilder : IInfrastructure<IMutableModel>, IInfrastructure<InternalIndexBuilder>
    {
        private readonly InternalIndexBuilder _builder;

        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IndexBuilder([NotNull] InternalIndexBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            _builder = builder;
        }

        /// <summary>
        ///     The internal builder being used to configure the index.
        /// </summary>
        InternalIndexBuilder IInfrastructure<InternalIndexBuilder>.Instance => _builder;

        /// <summary>
        ///     The index being configured.
        /// </summary>
        public virtual IMutableIndex Metadata => Builder.Metadata;

        /// <summary>
        ///     The model that the index belongs to.
        /// </summary>
        IMutableModel IInfrastructure<IMutableModel>.Instance => Builder.ModelBuilder.Metadata;

        /// <summary>
        ///     Adds or updates an annotation on the index. If an annotation with the key specified in
        ///     <paramref name="annotation" />
        ///     already exists its value will be updated.
        /// </summary>
        /// <param name="annotation"> The key of the annotation to be added or updated. </param>
        /// <param name="value"> The value to be stored in the annotation. </param>
        /// <returns> The same builder instance so that multiple configuration calls can be chained. </returns>
        public virtual IndexBuilder HasAnnotation([NotNull] string annotation, [NotNull] object value)
        {
            Check.NotEmpty(annotation, nameof(annotation));
            Check.NotNull(value, nameof(value));

            Builder.HasAnnotation(annotation, value, ConfigurationSource.Explicit);

            return this;
        }

        /// <summary>
        ///     Configures whether this index is unique (i.e. the value(s) for each instance must be unique).
        /// </summary>
        /// <param name="unique"> A value indicating whether this index is unique. </param>
        /// <returns> The same builder instance so that multiple configuration calls can be chained. </returns>
        public virtual IndexBuilder IsUnique(bool unique = true)
        {
            Builder.IsUnique(unique, ConfigurationSource.Explicit);

            return this;
        }

        private InternalIndexBuilder Builder => this.GetInfrastructure<InternalIndexBuilder>();
    }
}
