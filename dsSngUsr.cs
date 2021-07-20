﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3705.0
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace CafeManager {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dsSngUsr : DataSet {
        
        private userDataTable tableuser;
        
        public dsSngUsr() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsSngUsr(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["user"] != null)) {
                    this.Tables.Add(new userDataTable(ds.Tables["user"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public userDataTable user {
            get {
                return this.tableuser;
            }
        }
        
        public override DataSet Clone() {
            dsSngUsr cln = ((dsSngUsr)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["user"] != null)) {
                this.Tables.Add(new userDataTable(ds.Tables["user"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableuser = ((userDataTable)(this.Tables["user"]));
            if ((this.tableuser != null)) {
                this.tableuser.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsSngUsr";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/dsSngUsr.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableuser = new userDataTable();
            this.Tables.Add(this.tableuser);
        }
        
        private bool ShouldSerializeuser() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void userRowChangeEventHandler(object sender, userRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class userDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnAmount;
            
            private DataColumn columnDate;
            
            private DataColumn column_E_Mail_ID;
            
            private DataColumn columnLogin;
            
            private DataColumn columnLogout;
            
            private DataColumn columnName;
            
            private DataColumn columnTotal_Time;
            
            private DataColumn columnUser_ID;
            
            internal userDataTable() : 
                    base("user") {
                this.InitClass();
            }
            
            internal userDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn AmountColumn {
                get {
                    return this.columnAmount;
                }
            }
            
            internal DataColumn DateColumn {
                get {
                    return this.columnDate;
                }
            }
            
            internal DataColumn _E_Mail_IDColumn {
                get {
                    return this.column_E_Mail_ID;
                }
            }
            
            internal DataColumn LoginColumn {
                get {
                    return this.columnLogin;
                }
            }
            
            internal DataColumn LogoutColumn {
                get {
                    return this.columnLogout;
                }
            }
            
            internal DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            
            internal DataColumn Total_TimeColumn {
                get {
                    return this.columnTotal_Time;
                }
            }
            
            internal DataColumn User_IDColumn {
                get {
                    return this.columnUser_ID;
                }
            }
            
            public userRow this[int index] {
                get {
                    return ((userRow)(this.Rows[index]));
                }
            }
            
            public event userRowChangeEventHandler userRowChanged;
            
            public event userRowChangeEventHandler userRowChanging;
            
            public event userRowChangeEventHandler userRowDeleted;
            
            public event userRowChangeEventHandler userRowDeleting;
            
            public void AdduserRow(userRow row) {
                this.Rows.Add(row);
            }
            
            public userRow AdduserRow(System.Decimal Amount, System.DateTime Date, string _E_Mail_ID, System.DateTime Login, System.DateTime Logout, string Name, string Total_Time, string User_ID) {
                userRow rowuserRow = ((userRow)(this.NewRow()));
                rowuserRow.ItemArray = new object[] {
                        Amount,
                        Date,
                        _E_Mail_ID,
                        Login,
                        Logout,
                        Name,
                        Total_Time,
                        User_ID};
                this.Rows.Add(rowuserRow);
                return rowuserRow;
            }
            
            public userRow FindByUser_ID(string User_ID) {
                return ((userRow)(this.Rows.Find(new object[] {
                            User_ID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                userDataTable cln = ((userDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new userDataTable();
            }
            
            internal void InitVars() {
                this.columnAmount = this.Columns["Amount"];
                this.columnDate = this.Columns["Date"];
                this.column_E_Mail_ID = this.Columns["E-Mail ID"];
                this.columnLogin = this.Columns["Login"];
                this.columnLogout = this.Columns["Logout"];
                this.columnName = this.Columns["Name"];
                this.columnTotal_Time = this.Columns["Total Time"];
                this.columnUser_ID = this.Columns["User ID"];
            }
            
            private void InitClass() {
                this.columnAmount = new DataColumn("Amount", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAmount);
                this.columnDate = new DataColumn("Date", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDate);
                this.column_E_Mail_ID = new DataColumn("E-Mail ID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column_E_Mail_ID);
                this.columnLogin = new DataColumn("Login", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnLogin);
                this.columnLogout = new DataColumn("Logout", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnLogout);
                this.columnName = new DataColumn("Name", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnName);
                this.columnTotal_Time = new DataColumn("Total Time", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTotal_Time);
                this.columnUser_ID = new DataColumn("User ID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUser_ID);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnUser_ID}, true));
                this.columnUser_ID.AllowDBNull = false;
                this.columnUser_ID.Unique = true;
            }
            
            public userRow NewuserRow() {
                return ((userRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new userRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(userRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.userRowChanged != null)) {
                    this.userRowChanged(this, new userRowChangeEvent(((userRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.userRowChanging != null)) {
                    this.userRowChanging(this, new userRowChangeEvent(((userRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.userRowDeleted != null)) {
                    this.userRowDeleted(this, new userRowChangeEvent(((userRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.userRowDeleting != null)) {
                    this.userRowDeleting(this, new userRowChangeEvent(((userRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveuserRow(userRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class userRow : DataRow {
            
            private userDataTable tableuser;
            
            internal userRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableuser = ((userDataTable)(this.Table));
            }
            
            public System.Decimal Amount {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableuser.AmountColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableuser.AmountColumn] = value;
                }
            }
            
            public System.DateTime Date {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableuser.DateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableuser.DateColumn] = value;
                }
            }
            
            public string _E_Mail_ID {
                get {
                    try {
                        return ((string)(this[this.tableuser._E_Mail_IDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableuser._E_Mail_IDColumn] = value;
                }
            }
            
            public System.DateTime Login {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableuser.LoginColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableuser.LoginColumn] = value;
                }
            }
            
            public System.DateTime Logout {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableuser.LogoutColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableuser.LogoutColumn] = value;
                }
            }
            
            public string Name {
                get {
                    try {
                        return ((string)(this[this.tableuser.NameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableuser.NameColumn] = value;
                }
            }
            
            public string Total_Time {
                get {
                    try {
                        return ((string)(this[this.tableuser.Total_TimeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableuser.Total_TimeColumn] = value;
                }
            }
            
            public string User_ID {
                get {
                    return ((string)(this[this.tableuser.User_IDColumn]));
                }
                set {
                    this[this.tableuser.User_IDColumn] = value;
                }
            }
            
            public bool IsAmountNull() {
                return this.IsNull(this.tableuser.AmountColumn);
            }
            
            public void SetAmountNull() {
                this[this.tableuser.AmountColumn] = System.Convert.DBNull;
            }
            
            public bool IsDateNull() {
                return this.IsNull(this.tableuser.DateColumn);
            }
            
            public void SetDateNull() {
                this[this.tableuser.DateColumn] = System.Convert.DBNull;
            }
            
            public bool Is_E_Mail_IDNull() {
                return this.IsNull(this.tableuser._E_Mail_IDColumn);
            }
            
            public void Set_E_Mail_IDNull() {
                this[this.tableuser._E_Mail_IDColumn] = System.Convert.DBNull;
            }
            
            public bool IsLoginNull() {
                return this.IsNull(this.tableuser.LoginColumn);
            }
            
            public void SetLoginNull() {
                this[this.tableuser.LoginColumn] = System.Convert.DBNull;
            }
            
            public bool IsLogoutNull() {
                return this.IsNull(this.tableuser.LogoutColumn);
            }
            
            public void SetLogoutNull() {
                this[this.tableuser.LogoutColumn] = System.Convert.DBNull;
            }
            
            public bool IsNameNull() {
                return this.IsNull(this.tableuser.NameColumn);
            }
            
            public void SetNameNull() {
                this[this.tableuser.NameColumn] = System.Convert.DBNull;
            }
            
            public bool IsTotal_TimeNull() {
                return this.IsNull(this.tableuser.Total_TimeColumn);
            }
            
            public void SetTotal_TimeNull() {
                this[this.tableuser.Total_TimeColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class userRowChangeEvent : EventArgs {
            
            private userRow eventRow;
            
            private DataRowAction eventAction;
            
            public userRowChangeEvent(userRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public userRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
