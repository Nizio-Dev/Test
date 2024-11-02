using System.Data;

namespace Test;

public static class DataBuilder 
{ 
    public static IDataReader BuildDataReader()
    {
        var authorizationSetDataTable = new DataTable();
        authorizationSetDataTable.Columns.Add(FieldName.Age, typeof(int));
        authorizationSetDataTable.Columns.Add(FieldName.Name, typeof(string));

        for (int i = 0; i < Random.Shared.Next(1, 1000); i++)
        {
            var authorizationSetDataRow = authorizationSetDataTable.NewRow();
            authorizationSetDataRow[FieldName.Age] = i;
            authorizationSetDataRow[FieldName.Name] = "Damian" + i;
            authorizationSetDataTable.Rows.Add(authorizationSetDataRow);
        }
        
        return authorizationSetDataTable.CreateDataReader();
    }
    
    public class FieldName
    {
        public const String Age = "Age";
        public const String Name = "Name";
    }
}