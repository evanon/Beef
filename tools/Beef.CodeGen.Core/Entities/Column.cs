﻿// Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

using Beef.Data.Database;
using System;
using System.Xml.Linq;

namespace Beef.CodeGen.Entities
{
    /// <summary>
    /// Represents the SQL Server Database <b>Column</b> schema definition.
    /// </summary>
    public class Column
    {
        /// <summary>
        /// Indicates whether the database type maps to a <see cref="string"/>.
        /// </summary>
        /// <param name="dbType">The database type.</param>
        public static bool TypeIsString(string dbType)
        {
            if (dbType == null)
                return false;

            switch (dbType.ToUpperInvariant())
            {
                case "NCHAR":
                case "CHAR":
                case "NVARCHAR":
                case "VARCHAR":
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Indicates whether the database type maps to a <see cref="decimal"/>.
        /// </summary>
        /// <param name="dbType">The database type.</param>
        public static bool TypeIsDecimal(string dbType)
        {
            if (dbType == null)
                return false;

            switch (dbType.ToUpperInvariant())
            {
                case "DECIMAL":
                case "MONEY":
                case "NUMERIC":
                case "SMALLMONEY":
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Indicates whether the database type maps to a <see cref="DateTime"/>.
        /// </summary>
        /// <param name="dbType">The database type.</param>
        public static bool TypeIsDateTime(string dbType)
        {
            if (dbType == null)
                return false;

            switch (dbType.ToUpperInvariant())
            {
                case "DATE":
                case "DATETIME":
                case "DATETIME2":
                case "DATETIMEOFFSET":
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Indicates whether the database type maps to an integer.
        /// </summary>
        /// <param name="dbType">The database type.</param>
        public static bool TypeIsInteger(string dbType)
        {
            if (dbType == null)
                return false;

            switch (dbType.ToUpperInvariant())
            {
                case "INT":
                case "BIGINT":
                case "SMALLINT":
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Gets the corresponding .NET <see cref="System.Type"/> name for the database type.
        /// </summary>
        /// <param name="dbType">The database type.</param>
        /// <returns>The .NET <see cref="System.Type"/> name.</returns>
        public static string GetDotNetTypeName(string dbType)
        {
            // https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings

            if (string.IsNullOrEmpty(dbType))
                throw new ArgumentNullException(nameof(dbType));

            if (TypeIsString(dbType))
                return "string";
            else if (TypeIsDecimal(dbType))
                return "decimal";
            else if (TypeIsDateTime(dbType))
                return "DateTime";

            switch (dbType.ToUpperInvariant())
            {
                case "ROWVERSION":
                case "TIMESTAMP":
                case "VARBINARY": return "byte[]";
                case "BIT": return "bool";
                case "DATETIMEOFFSET": return "DateTimeOffset";
                case "FLOAT": return "double";
                case "INT": return "int";
                case "BIGINT": return "long";
                case "SMALLINT": return "short";
                case "TINYINT": return "byte";
                case "REAL": return "float";
                case "TIME": return "TimeSpan";
                case "UNIQUEIDENTIFIER": return "Guid";

                default:
                    throw new InvalidOperationException($"Database data type '{dbType}' does not have corresponding .NET type mapping defined.");
            }
        }

        /// <summary>
        /// Gets the corresponding .NET <see cref="System.Type"/> for the database type.
        /// </summary>
        /// <param name="dbType">The database type.</param>
        /// <returns>The .NET <see cref="System.Type"/> name.</returns>
        public static Type GetDotNetType(string dbType)
        {
            return (GetDotNetTypeName(dbType).ToUpperInvariant()) switch
            {
                "STRING" => typeof(string),
                "DECIMAL" => typeof(decimal),
                "DATETIME" => typeof(DateTime),
                "BYTE[]" => typeof(byte[]),
                "BOOL" => typeof(bool),
                "DATETIMEOFFSET" => typeof(DateTimeOffset),
                "DOUBLE" => typeof(double),
                "INT" => typeof(int),
                "LONG" => typeof(long),
                "SHORT" => typeof(short),
                "BYTE" => typeof(byte),
                "FLOAT" => typeof(float),
                "TIMESPAN" => typeof(TimeSpan),
                "GUID" => typeof(Guid),
                _ => throw new InvalidOperationException($"Database data type '{dbType}' does not have corresponding .NET type mapping defined."),
            };
        }

        /// <summary>
        /// Gets the column name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets the SQL Server data type.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Indicates whether the column is nullable.
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public int? Length { get; set; }

        /// <summary>
        /// Gets or sets the precision.
        /// </summary>
        public int? Precision { get; set; }

        /// <summary>
        /// Gets or sets the scale.
        /// </summary>
        public int? Scale { get; set; }

        /// <summary>
        /// Indicates whether the column is an auto-generated identity.
        /// </summary>
        public bool IsIdentity { get; set; }

        /// <summary>
        /// Gets or sets the identity seed value.
        /// </summary>
        public int? IdentitySeed { get; set; }

        /// <summary>
        /// Gets or sets the identity increment value;
        /// </summary>
        public int? IdentityIncrement { get; set; }

        /// <summary>
        /// Indicates whether the column is computed.
        /// </summary>
        public bool IsComputed { get; set; }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        public string? DefaultValue { get; set; }

        /// <summary>
        /// Indicates whether the column is the primary key.
        /// </summary>
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// Indicates whether the column has a unique constraint.
        /// </summary>
        public bool IsUnique { get; set; }

        /// <summary>
        /// Gets or sets the foreign key table.
        /// </summary>
        public string? ForeignTable { get; set; }

        /// <summary>
        /// Gets or sets the foreign key schema.
        /// </summary>
        public string? ForeignSchema { get; set; }

        /// <summary>
        /// Gets or sets the foreign key column name.
        /// </summary>
        public string? ForeignColumn { get; set; }

        /// <summary>
        /// Indicates whether the foreign key is references a reference data table/entity.
        /// </summary>
        public bool IsForeignRefData { get; set; }

        /// <summary>
        /// Gets the corresponding .NET <see cref="System.Type"/> name.
        /// </summary>
        public string DotNetType
        {
            get => string.IsNullOrEmpty(Type) ? "string" : GetDotNetTypeName(Type);
        }

        /// <summary>
        /// Creates (and adds) the <see cref="Table"/> element for code generation.
        /// </summary>
        /// <param name="xml">The <see cref="XElement"/> to add to.</param>
        public void CreateXml(XElement xml)
        {
            if (xml == null)
                throw new ArgumentNullException(nameof(xml));

            var xc = new XElement("Column",
                new XAttribute("Name", Name),
                new XAttribute("Type", Type),
                new XAttribute("DotNetType", DotNetType),
                new XAttribute("IsNullable", IsNullable));

            if (Length.HasValue)
                xc.Add(new XAttribute("Length", Length.Value));

            if (Precision.HasValue)
                xc.Add(new XAttribute("Precision", Precision.Value));

            if (Scale.HasValue)
                xc.Add(new XAttribute("Scale", Scale.Value));

            if (IsIdentity)
            {
                xc.Add(new XAttribute("IsIdentity", true));
                if (!IsComputed && DefaultValue == null)
                {
                    xc.Add(new XAttribute("IdentitySeed", IdentitySeed ?? 1));
                    xc.Add(new XAttribute("IdentityIncrement", IdentityIncrement ?? 1));
                }
            }

            if (IsComputed)
                xc.Add(new XAttribute("IsComputed", true));

            if (!string.IsNullOrEmpty(DefaultValue))
                xc.Add(new XAttribute("DefaultValue", DefaultValue));

            if (IsPrimaryKey)
                xc.Add(new XAttribute("IsPrimaryKey", true));

            if (IsUnique)
                xc.Add(new XAttribute("IsUnique", true));

            if (ForeignTable != null)
            {
                xc.Add(new XAttribute("ForeignTable", ForeignTable));
                xc.Add(new XAttribute("ForeignSchema", ForeignSchema));
                xc.Add(new XAttribute("ForeignColumn", ForeignColumn));
                if (IsForeignRefData)
                    xc.Add(new XAttribute("IsForeignRefData", true));
            }

            xml.Add(xc);
        }
    }

    /// <summary>
    /// Represents the <see cref="Column"/> database mapper.
    /// </summary>
#pragma warning disable CA1812 // Apparently never instantiated; by-design - it is!
    internal class ColumnMapper : DatabaseMapper<Column, ColumnMapper>
#pragma warning restore CA1812
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnMapper"/> class.
        /// </summary>
        public ColumnMapper()
        {
            Property(x => x.Name, "COLUMN_NAME");
            Property(x => x.Type, "DATA_TYPE");
            Property(x => x.IsNullable).MapFromDb((dr, c, ot) => dr.GetValue<string>("IS_NULLABLE").ToUpperInvariant() == "YES");
            Property(x => x.Length, "CHARACTER_MAXIMUM_LENGTH");
            Property(x => x.Precision).MapFromDb((dr, c, ot) => dr.GetValue<int?>("NUMERIC_PRECISION") ?? dr.GetValue<int?>("DATETIME_PRECISION"));
            Property(x => x.Scale, "NUMERIC_SCALE");
            Property(x => x.DefaultValue, "COLUMN_DEFAULT");
        }
    }
}
