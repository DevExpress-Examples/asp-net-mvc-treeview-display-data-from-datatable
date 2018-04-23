using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Example.Models {
    public static class MyModel {
        private static DataTable _MyDataTable;
        public static DataTable MyDataTable {
            get {
                if (_MyDataTable == null) {
                    _MyDataTable = new DataTable();

                    _MyDataTable.Columns.Add("ID", typeof(System.Int32));
                    _MyDataTable.Columns.Add("Title", typeof(System.String));
                    _MyDataTable.Columns.Add("ParentID", typeof(System.Int32));

                    _MyDataTable.PrimaryKey = new DataColumn[] { _MyDataTable.Columns["ID"] };

                    _MyDataTable.Rows.Add(1, "Nokia", 0);
                    _MyDataTable.Rows.Add(2, "N8", 1);
                    _MyDataTable.Rows.Add(3, "N91", 1);
                    _MyDataTable.Rows.Add(4, "Samsung", 0);
                    _MyDataTable.Rows.Add(5, "Corby9", 4);
                    _MyDataTable.Rows.Add(6, "Star", 0);
                }

                return _MyDataTable;
            }
        }
    }
}