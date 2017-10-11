using System;
using System.Reflection;
using System.Resources;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Microsoft.EntityFrameworkCore.Internal
{
    /// <summary>
    ///		This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public static class DesignStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Properties.DesignStrings", typeof(DesignStrings).GetTypeInfo().Assembly);


        /// <summary>
        ///     The name '{migrationName}' is used by an existing migration.
        /// </summary>
        public static string DuplicateMigrationName([CanBeNull] object migrationName)
            => string.Format(
                GetString("DuplicateMigrationName", nameof(migrationName)),
                migrationName);


        /// <summary>
        ///     More than one DbContext was found. Specify which one to use. Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands.
        /// </summary>
        public static string MultipleContexts
            => GetString("MultipleContexts");


        /// <summary>
        ///     More than one DbContext named '{name}' was found. Specify which one to use by providing its fully qualified name.
        /// </summary>
        public static string MultipleContextsWithName([CanBeNull] object name)
            => string.Format(
                GetString("MultipleContextsWithName", nameof(name)),
                name);


        /// <summary>
        ///     More than one DbContext named '{name}' was found. Specify which one to use by providing its fully qualified name using its exact case.
        /// </summary>
        public static string MultipleContextsWithQualifiedName([CanBeNull] object name)
            => string.Format(
                GetString("MultipleContextsWithQualifiedName", nameof(name)),
                name);


        /// <summary>
        ///     No DbContext was found in assembly '{assembly}'. Ensure that you're using the correct assembly and that the type is neither abstract nor generic.
        /// </summary>
        public static string NoContext([CanBeNull] object assembly)
            => string.Format(
                GetString("NoContext", nameof(assembly)),
                assembly);


        /// <summary>
        ///     No DbContext named '{name}' was found.
        /// </summary>
        public static string NoContextWithName([CanBeNull] object name)
            => string.Format(
                GetString("NoContextWithName", nameof(name)),
                name);


        /// <summary>
        ///     Using context '{name}'.
        /// </summary>
        public static string UseContext([CanBeNull] object name)
            => string.Format(
                GetString("UseContext", nameof(name)),
                name);


        /// <summary>
        ///     Dropping database '{name}'.
        /// </summary>
        public static string DroppingDatabase([CanBeNull] object name)
            => string.Format(
                GetString("DroppingDatabase", nameof(name)),
                name);


        /// <summary>
        ///     Successfully dropped database '{name}'.
        /// </summary>
        public static string DatabaseDropped([CanBeNull] object name)
            => string.Format(
                GetString("DatabaseDropped", nameof(name)),
                name);


        /// <summary>
        ///     A manual migration deletion was detected.
        /// </summary>
        public static string ManuallyDeleted
            => GetString("ManuallyDeleted");


        /// <summary>
        ///     No file named '{file}' was found. You must manually remove the migration class '{migrationClass}'.
        /// </summary>
        public static string NoMigrationFile([CanBeNull] object file, [CanBeNull] object migrationClass)
            => string.Format(
                GetString("NoMigrationFile", nameof(file), nameof(migrationClass)),
                file, migrationClass);


        /// <summary>
        ///     No file named '{file}' was found.
        /// </summary>
        public static string NoMigrationMetadataFile([CanBeNull] object file)
            => string.Format(
                GetString("NoMigrationMetadataFile", nameof(file)),
                file);


        /// <summary>
        ///     No ModelSnapshot was found.
        /// </summary>
        public static string NoSnapshot
            => GetString("NoSnapshot");


        /// <summary>
        ///     No file named '{file}' was found. You must manually remove the model snapshot class '{snapshotClass}'.
        /// </summary>
        public static string NoSnapshotFile([CanBeNull] object file, [CanBeNull] object snapshotClass)
            => string.Format(
                GetString("NoSnapshotFile", nameof(file), nameof(snapshotClass)),
                file, snapshotClass);


        /// <summary>
        ///     Removing migration '{name}'.
        /// </summary>
        public static string RemovingMigration([CanBeNull] object name)
            => string.Format(
                GetString("RemovingMigration", nameof(name)),
                name);


        /// <summary>
        ///     Removing model snapshot.
        /// </summary>
        public static string RemovingSnapshot
            => GetString("RemovingSnapshot");


        /// <summary>
        ///     Reverting model snapshot.
        /// </summary>
        public static string RevertingSnapshot
            => GetString("RevertingSnapshot");


        /// <summary>
        ///     The migration '{name}' has already been applied to the database. Revert it and try again. If the migration has been applied to other databases, consider reverting its changes using a new migration.
        /// </summary>
        public static string RevertMigration([CanBeNull] object name)
            => string.Format(
                GetString("RevertMigration", nameof(name)),
                name);


        /// <summary>
        ///     The current CSharpMigrationOperationGenerator cannot scaffold operations of type '{operationType}'. Configure your services to use one that can.
        /// </summary>
        public static string UnknownOperation([CanBeNull] object operationType)
            => string.Format(
                GetString("UnknownOperation", nameof(operationType)),
                operationType);


        /// <summary>
        ///     The current CSharpHelper cannot scaffold literals of type '{literalType}'. Configure your services to use one that can.
        /// </summary>
        public static string UnknownLiteral([CanBeNull] object literalType)
            => string.Format(
                GetString("UnknownLiteral", nameof(literalType)),
                literalType);


        /// <summary>
        ///     Unable to find provider assembly with name {assemblyName}. Ensure the specified name is correct and is referenced by the project.
        /// </summary>
        public static string CannotFindRuntimeProviderAssembly([CanBeNull] object assemblyName)
            => string.Format(
                GetString("CannotFindRuntimeProviderAssembly", nameof(assemblyName)),
                assemblyName);


        /// <summary>
        ///     An operation was scaffolded that may result in the loss of data. Please review the migration for accuracy.
        /// </summary>
        public static string DestructiveOperation
            => GetString("DestructiveOperation");


        /// <summary>
        ///     Writing migration to '{file}'.
        /// </summary>
        public static string WritingMigration([CanBeNull] object file)
            => string.Format(
                GetString("WritingMigration", nameof(file)),
                file);


        /// <summary>
        ///     Writing model snapshot to '{file}'.
        /// </summary>
        public static string WritingSnapshot([CanBeNull] object file)
            => string.Format(
                GetString("WritingSnapshot", nameof(file)),
                file);


        /// <summary>
        ///     Done.
        /// </summary>
        public static string Done
            => GetString("Done");


        /// <summary>
        ///     Reusing namespace of type '{type}'.
        /// </summary>
        public static string ReusingNamespace([CanBeNull] object type)
            => string.Format(
                GetString("ReusingNamespace", nameof(type)),
                type);


        /// <summary>
        ///     Reusing model snapshot name '{name}'.
        /// </summary>
        public static string ReusingSnapshotName([CanBeNull] object name)
            => string.Format(
                GetString("ReusingSnapshotName", nameof(name)),
                name);


        /// <summary>
        ///     Unable to find expected assembly attribute named {attributeName} in provider assembly {runtimeProviderAssemblyName}. This attribute is required to identify the class which acts as the design-time service provider factory.
        /// </summary>
        public static string CannotFindDesignTimeProviderAssemblyAttribute([CanBeNull] object attributeName, [CanBeNull] object runtimeProviderAssemblyName)
            => string.Format(
                GetString("CannotFindDesignTimeProviderAssemblyAttribute", nameof(attributeName), nameof(runtimeProviderAssemblyName)),
                attributeName, runtimeProviderAssemblyName);


        /// <summary>
        ///     {provider} is not a Relational provider and therefore cannot be use with Migrations.
        /// </summary>
        public static string NonRelationalProvider([CanBeNull] object provider)
            => string.Format(
                GetString("NonRelationalProvider", nameof(provider)),
                provider);


        /// <summary>
        ///     Could not load assembly '{assembly}'. Ensure it is referenced by the startup project '{startupProject}'.
        /// </summary>
        public static string UnreferencedAssembly([CanBeNull] object assembly, [CanBeNull] object startupProject)
            => string.Format(
                GetString("UnreferencedAssembly", nameof(assembly), nameof(startupProject)),
                assembly, startupProject);


        /// <summary>
        ///     Finding DbContext classes...
        /// </summary>
        public static string FindingContexts
            => GetString("FindingContexts");


        /// <summary>
        ///     The namespace '{migrationsNamespace}' contains migrations for a different DbContext. This can result in conflicting migration names. It's recommend to put migrations for different DbContext classes into different namespaces.
        /// </summary>
        public static string ForeignMigrations([CanBeNull] object migrationsNamespace)
            => string.Format(
                GetString("ForeignMigrations", nameof(migrationsNamespace)),
                migrationsNamespace);


        /// <summary>
        ///     The context class name passed in, {contextClassName}, is not a valid C# identifier.
        /// </summary>
        public static string ContextClassNotValidCSharpIdentifier([CanBeNull] object contextClassName)
            => string.Format(
                GetString("ContextClassNotValidCSharpIdentifier", nameof(contextClassName)),
                contextClassName);


        /// <summary>
        ///     Your target project '{assembly}' doesn't match your migrations assembly '{migrationsAssembly}'. Either change your target project or change your migrations assembly.
        ///     Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b =&gt; b.MigrationsAssembly("{assembly}")). By default, the migrations assembly is the assembly containing the DbContext.
        ///     Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.
        /// </summary>
        public static string MigrationsAssemblyMismatch([CanBeNull] object assembly, [CanBeNull] object migrationsAssembly)
            => string.Format(
                GetString("MigrationsAssemblyMismatch", nameof(assembly), nameof(migrationsAssembly)),
                assembly, migrationsAssembly);


        /// <summary>
        ///     To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        /// </summary>
        public static string SensitiveInformationWarning
            => GetString("SensitiveInformationWarning");


        /// <summary>
        ///     Removing migration '{name}' without checking the database. If this migration has been applied to the database, you will need to manually reverse the changes it made.
        /// </summary>
        public static string ForceRemoveMigration([CanBeNull] object name)
            => string.Format(
                GetString("ForceRemoveMigration", nameof(name)),
                name);


        /// <summary>
        ///     Unable to create an object of type '{contextType}'. Add an implementation of 'IDesignTimeDbContextFactory&lt;{contextType}&gt;' to the project, or see https://go.microsoft.com/fwlink/?linkid=851728 for additional patterns supported at design time.
        /// </summary>
        public static string NoParameterlessConstructor([CanBeNull] object contextType)
            => string.Format(
                GetString("NoParameterlessConstructor", nameof(contextType)),
                contextType);


        /// <summary>
        ///     Database '{name}' did not exist, no action was taken.
        /// </summary>
        public static string NotExistDatabase([CanBeNull] object name)
            => string.Format(
                GetString("NotExistDatabase", nameof(name)),
                name);


        /// <summary>
        ///     Using environment '{environment}'.
        /// </summary>
        public static string UsingEnvironment([CanBeNull] object environment)
            => string.Format(
                GetString("UsingEnvironment", nameof(environment)),
                environment);


        /// <summary>
        ///     Finding BuildWebHost method...
        /// </summary>
        public static string FindingBuildWebHost
            => GetString("FindingBuildWebHost");


        /// <summary>
        ///     Finding application service provider...
        /// </summary>
        public static string FindingServiceProvider
            => GetString("FindingServiceProvider");


        /// <summary>
        ///     No BuildWebHost method was found on type '{programClass}'.
        /// </summary>
        public static string NoBuildWebHost([CanBeNull] object programClass)
            => string.Format(
                GetString("NoBuildWebHost", nameof(programClass)),
                programClass);


        /// <summary>
        ///     No entry point was found for assembly '{startupAssembly}'.
        /// </summary>
        public static string NoEntryPoint([CanBeNull] object startupAssembly)
            => string.Format(
                GetString("NoEntryPoint", nameof(startupAssembly)),
                startupAssembly);


        /// <summary>
        ///     No application service provider was found.
        /// </summary>
        public static string NoServiceProvider
            => GetString("NoServiceProvider");


        /// <summary>
        ///     Using application service provider from BuildWebHost method on '{programClass}'.
        /// </summary>
        public static string UsingBuildWebHost([CanBeNull] object programClass)
            => string.Format(
                GetString("UsingBuildWebHost", nameof(programClass)),
                programClass);


        /// <summary>
        ///     Found DbContext '{contextType}'.
        /// </summary>
        public static string FoundDbContext([CanBeNull] object contextType)
            => string.Format(
                GetString("FoundDbContext", nameof(contextType)),
                contextType);


        /// <summary>
        ///     Using DbContext factory '{factory}'.
        /// </summary>
        public static string UsingDbContextFactory([CanBeNull] object factory)
            => string.Format(
                GetString("UsingDbContextFactory", nameof(factory)),
                factory);


        /// <summary>
        ///     Finding IDesignTimeServices implementations in assembly '{startupAssembly}'...
        /// </summary>
        public static string FindingDesignTimeServices([CanBeNull] object startupAssembly)
            => string.Format(
                GetString("FindingDesignTimeServices", nameof(startupAssembly)),
                startupAssembly);


        /// <summary>
        ///     Finding design-time services for provider '{provider}'...
        /// </summary>
        public static string FindingProviderServices([CanBeNull] object provider)
            => string.Format(
                GetString("FindingProviderServices", nameof(provider)),
                provider);


        /// <summary>
        ///     No design-time services were found.
        /// </summary>
        public static string NoDesignTimeServices
            => GetString("NoDesignTimeServices");


        /// <summary>
        ///     Using design-time services from class '{designTimeServices}'.
        /// </summary>
        public static string UsingDesignTimeServices([CanBeNull] object designTimeServices)
            => string.Format(
                GetString("UsingDesignTimeServices", nameof(designTimeServices)),
                designTimeServices);


        /// <summary>
        ///     Using design-time services from provider '{provider}'.
        /// </summary>
        public static string UsingProviderServices([CanBeNull] object provider)
            => string.Format(
                GetString("UsingProviderServices", nameof(provider)),
                provider);


        /// <summary>
        ///     Finding IDesignTimeDbContextFactory implementations...
        /// </summary>
        public static string FindingContextFactories
            => GetString("FindingContextFactories");


        /// <summary>
        ///     Finding DbContext classes in the project...
        /// </summary>
        public static string FindingReferencedContexts
            => GetString("FindingReferencedContexts");


        /// <summary>
        ///     Found IDesignTimeDbContextFactory implementation '{factory}'.
        /// </summary>
        public static string FoundContextFactory([CanBeNull] object factory)
            => string.Format(
                GetString("FoundContextFactory", nameof(factory)),
                factory);


        /// <summary>
        ///     Metadata model returned should not be null. Provider: {providerTypeName}.
        /// </summary>
        public static string ProviderReturnedNullModel([CanBeNull] object providerTypeName)
            => string.Format(
                GetString("ProviderReturnedNullModel", nameof(providerTypeName)),
                providerTypeName);


        /// <summary>
        ///     No files generated in directory {outputDirectoryName}. The following file(s) already exist and must be made writeable to continue: {readOnlyFiles}.
        /// </summary>
        public static string ReadOnlyFiles([CanBeNull] object outputDirectoryName, [CanBeNull] object readOnlyFiles)
            => string.Format(
                GetString("ReadOnlyFiles", nameof(outputDirectoryName), nameof(readOnlyFiles)),
                outputDirectoryName, readOnlyFiles);


        /// <summary>
        ///     The following file(s) already exist in directory {outputDirectoryName}: {existingFiles}. Use the Force flag to overwrite these files.
        /// </summary>
        public static string ExistingFiles([CanBeNull] object outputDirectoryName, [CanBeNull] object existingFiles)
            => string.Format(
                GetString("ExistingFiles", nameof(outputDirectoryName), nameof(existingFiles)),
                outputDirectoryName, existingFiles);


        /// <summary>
        ///     Could not find type mapping for column '{columnName}' with data type '{dateType}'. Skipping column.
        /// </summary>
        public static string CannotFindTypeMappingForColumn([CanBeNull] object columnName, [CanBeNull] object dateType)
            => string.Format(
                GetString("CannotFindTypeMappingForColumn", nameof(columnName), nameof(dateType)),
                columnName, dateType);


        /// <summary>
        ///     Could not scaffold the foreign key '{foreignKeyName}'. A key for '{columnsList}' was not found in the principal entity type '{principalEntityType}'.
        /// </summary>
        public static string ForeignKeyScaffoldErrorPrincipalKeyNotFound([CanBeNull] object foreignKeyName, [CanBeNull] object columnsList, [CanBeNull] object principalEntityType)
            => string.Format(
                GetString("ForeignKeyScaffoldErrorPrincipalKeyNotFound", nameof(foreignKeyName), nameof(columnsList), nameof(principalEntityType)),
                foreignKeyName, columnsList, principalEntityType);


        /// <summary>
        ///     Could not scaffold the foreign key '{foreignKeyName}'. The referenced table '{principaltableName}' could not be scaffolded.
        /// </summary>
        public static string ForeignKeyScaffoldErrorPrincipalTableScaffoldingError([CanBeNull] object foreignKeyName, [CanBeNull] object principaltableName)
            => string.Format(
                GetString("ForeignKeyScaffoldErrorPrincipalTableScaffoldingError", nameof(foreignKeyName), nameof(principaltableName)),
                foreignKeyName, principaltableName);


        /// <summary>
        ///     Could not scaffold the primary key for '{tableName}'. The following columns in the primary key could not be scaffolded: {columnNames}.
        /// </summary>
        public static string PrimaryKeyErrorPropertyNotFound([CanBeNull] object tableName, [CanBeNull] object columnNames)
            => string.Format(
                GetString("PrimaryKeyErrorPropertyNotFound", nameof(tableName), nameof(columnNames)),
                tableName, columnNames);


        /// <summary>
        ///     Unable to identify the primary key for table '{tableName}'.
        /// </summary>
        public static string MissingPrimaryKey([CanBeNull] object tableName)
            => string.Format(
                GetString("MissingPrimaryKey", nameof(tableName)),
                tableName);


        /// <summary>
        ///     Unable to generate entity type for table '{tableName}'.
        /// </summary>
        public static string UnableToGenerateEntityType([CanBeNull] object tableName)
            => string.Format(
                GetString("UnableToGenerateEntityType", nameof(tableName)),
                tableName);


        /// <summary>
        ///     For sequence '{sequenceName}'. Unable to scaffold because it uses an unsupported type: '{typeName}'.
        /// </summary>
        public static string BadSequenceType([CanBeNull] object sequenceName, [CanBeNull] object typeName)
            => string.Format(
                GetString("BadSequenceType", nameof(sequenceName), nameof(typeName)),
                sequenceName, typeName);


        /// <summary>
        ///     The principal end of the foreign key '{foreignKeyName}' is supported by the unique index '{indexName}' and contains the following nullable columns '{columnNames}'. Entity Framework requires the properties representing those columns to be non-nullable.
        /// </summary>
        public static string ForeignKeyPrincipalEndContainsNullableColumns([CanBeNull] object foreignKeyName, [CanBeNull] object indexName, [CanBeNull] object columnNames)
            => string.Format(
                GetString("ForeignKeyPrincipalEndContainsNullableColumns", nameof(foreignKeyName), nameof(indexName), nameof(columnNames)),
                foreignKeyName, indexName, columnNames);


        /// <summary>
        ///     The column '{columnName}' would normally be mapped to a non-nullable bool property, but it has a default constraint. Such a column is mapped to a nullable bool property to allow a difference between setting the property to false and invoking the default constraint. See https://go.microsoft.com/fwlink/?linkid=851278 for details.
        /// </summary>
        public static string NonNullableBoooleanColumnHasDefaultConstraint([CanBeNull] object columnName)
            => string.Format(
                GetString("NonNullableBoooleanColumnHasDefaultConstraint", nameof(columnName)),
                columnName);


        /// <summary>
        ///     Could not scaffold the foreign key '{foreignKeyName}'. The referenced table could not be found. This most likely occurred because the referenced table was excluded from scaffolding.
        /// </summary>
        public static string ForeignKeyScaffoldErrorPrincipalTableNotFound([CanBeNull] object foreignKeyName)
            => string.Format(
                GetString("ForeignKeyScaffoldErrorPrincipalTableNotFound", nameof(foreignKeyName)),
                foreignKeyName);


        /// <summary>
        ///     Could not scaffold the foreign key '{foreignKeyName}'.  The following columns in the foreign key could not be scaffolded: {columnNames}.
        /// </summary>
        public static string ForeignKeyScaffoldErrorPropertyNotFound([CanBeNull] object foreignKeyName, [CanBeNull] object columnNames)
            => string.Format(
                GetString("ForeignKeyScaffoldErrorPropertyNotFound", nameof(foreignKeyName), nameof(columnNames)),
                foreignKeyName, columnNames);


        /// <summary>
        ///     Unable to scaffold the index '{indexName}'. The following columns could not be scaffolded: {columnNames}.
        /// </summary>
        public static string UnableToScaffoldIndexMissingProperty([CanBeNull] object indexName, [CanBeNull] object columnNames)
            => string.Format(
                GetString("UnableToScaffoldIndexMissingProperty", nameof(indexName), nameof(columnNames)),
                indexName, columnNames);


        /// <summary>
        ///     The annotation '{annotationName}' was specified twice with potentially different values. Specifying the same annotation multiple times for different providers is no longer supported. Review the generated Migration to ensure it is correct and, if necessary, edit the Migration to fix any issues.
        /// </summary>
        public static string MultipleAnnotationConflict([CanBeNull] object annotationName)
            => string.Format(
                GetString("MultipleAnnotationConflict", nameof(annotationName)),
                annotationName);


        /// <summary>
        ///     Sequence name cannot be null or empty. Entity Framework cannot model a sequence that does not have a name.
        /// </summary>
        public static string SequencesRequireName
            => GetString("SequencesRequireName");


        /// <summary>
        ///     An error occurred while calling method 'BuildWebHost' on class '{startupClass}'. Continuing without the application service provider. Error: {error}
        /// </summary>
        public static string InvokeBuildWebHostFailed([CanBeNull] object startupClass, [CanBeNull] object error)
            => string.Format(
                GetString("InvokeBuildWebHostFailed", nameof(startupClass), nameof(error)),
                startupClass, error);


        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}
