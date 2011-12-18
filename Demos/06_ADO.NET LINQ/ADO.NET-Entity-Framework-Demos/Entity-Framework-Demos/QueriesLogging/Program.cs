using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsingEntityFrameworkModel;
using System.Data.Objects;
using System.Configuration;
using System.Diagnostics;

namespace QueriesLogging
{
    class Program
    {
        private const string debugSeperator =
        "-------------------------------------------------------------------------------";

        public static IQueryable<T> TraceQuery<T>(IQueryable<T> query)
        {
            if (query != null)
            {
                ObjectQuery<T> objectQuery = query as ObjectQuery<T>;
                if (objectQuery != null && Boolean.Parse(ConfigurationManager.AppSettings["Debugging"]))
                {
                    StringBuilder queryString = new StringBuilder();
                    queryString.Append(Environment.NewLine)
                    .AppendLine(debugSeperator)
                    .AppendLine("QUERY GENERATED...")
                    .AppendLine(debugSeperator)
                    .AppendLine(objectQuery.ToTraceString())
                    .AppendLine(debugSeperator)
                    .AppendLine(debugSeperator)
                    .AppendLine("PARAMETERS...")
                    .AppendLine(debugSeperator);
                    foreach (ObjectParameter parameter in objectQuery.Parameters)
                    {
                        queryString.Append(String.Format("{0}({1}) \t- {2}", parameter.Name, parameter.ParameterType, parameter.Value)).Append(Environment.NewLine);
                    }
                    queryString.AppendLine(debugSeperator).Append(Environment.NewLine);
                    Console.WriteLine(queryString);
                    Trace.WriteLine(queryString);
                }
            }
            return query;
        }

        static void Main()
        {
            NorthwindEntities context = new NorthwindEntities();
            var query = from product in context.Products
                        select new { ProductName = product.ProductName, CategoryName = product.Category.CategoryName };
            Logger.PrintQueries(query);

        }
    }
}
