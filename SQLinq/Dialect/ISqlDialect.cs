﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLinq
{
    public interface ISqlDialect
    {
        object ConvertParameterValue(object value);
        string ParameterPrefix { get; }
        string ParseTableName(string tableName);
        string ParseColumnName(string columnName);
        void AssertSkip<T>(SQLinq<T> sqLinq);
        string ToQuery(SQLinqSelectResult selectResult);
    }
}