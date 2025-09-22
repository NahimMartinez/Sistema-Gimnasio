using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Data
{
    public enum DuplicateField { Dni, Email, Telefono, Username, Unknown }

    public static class SqlExceptionUtils
    {
        public static string GetConstraintName(SqlException ex)
        {
            var m = Regex.Match(ex.Message, @"constraint '?(?<name>[^']+)'?", RegexOptions.IgnoreCase);
            if (m.Success) return m.Groups["name"].Value;
            m = Regex.Match(ex.Message, @"index '?(?<name>[^']+)'?", RegexOptions.IgnoreCase);
            if (m.Success) return m.Groups["name"].Value;
            return null;
        }

        public static DuplicateField MapConstraintToField(string name)
        {
            if (string.IsNullOrEmpty(name)) return DuplicateField.Unknown;
            var n = name.ToLowerInvariant();
            if (n.Contains("dni")) return DuplicateField.Dni;
            if (n.Contains("email")) return DuplicateField.Email;
            if (n.Contains("telefono") || n.Contains("tel")) return DuplicateField.Telefono;
            if (n.Contains("user") || n.Contains("username")) return DuplicateField.Username;
            return DuplicateField.Unknown;
        }
    }
}

