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
    public class dsSecurity : DataSet {
        
        private SuperDataTable tableSuper;
        
        private SwUsersDataTable tableSwUsers;
        
        public dsSecurity() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsSecurity(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Super"] != null)) {
                    this.Tables.Add(new SuperDataTable(ds.Tables["Super"]));
                }
                if ((ds.Tables["SwUsers"] != null)) {
                    this.Tables.Add(new SwUsersDataTable(ds.Tables["SwUsers"]));
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
        public SuperDataTable Super {
            get {
                return this.tableSuper;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public SwUsersDataTable SwUsers {
            get {
                return this.tableSwUsers;
            }
        }
        
        public override DataSet Clone() {
            dsSecurity cln = ((dsSecurity)(base.Clone()));
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
            if ((ds.Tables["Super"] != null)) {
                this.Tables.Add(new SuperDataTable(ds.Tables["Super"]));
            }
            if ((ds.Tables["SwUsers"] != null)) {
                this.Tables.Add(new SwUsersDataTable(ds.Tables["SwUsers"]));
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
            this.tableSuper = ((SuperDataTable)(this.Tables["Super"]));
            if ((this.tableSuper != null)) {
                this.tableSuper.InitVars();
            }
            this.tableSwUsers = ((SwUsersDataTable)(this.Tables["SwUsers"]));
            if ((this.tableSwUsers != null)) {
                this.tableSwUsers.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsSecurity";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/dsSecurity.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableSuper = new SuperDataTable();
            this.Tables.Add(this.tableSuper);
            this.tableSwUsers = new SwUsersDataTable();
            this.Tables.Add(this.tableSwUsers);
        }
        
        private bool ShouldSerializeSuper() {
            return false;
        }
        
        private bool ShouldSerializeSwUsers() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void SuperRowChangeEventHandler(object sender, SuperRowChangeEvent e);
        
        public delegate void SwUsersRowChangeEventHandler(object sender, SwUsersRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SuperDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnPassCode;
            
            private DataColumn columnValid;
            
            internal SuperDataTable() : 
                    base("Super") {
                this.InitClass();
            }
            
            internal SuperDataTable(DataTable table) : 
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
            
            internal DataColumn PassCodeColumn {
                get {
                    return this.columnPassCode;
                }
            }
            
            internal DataColumn ValidColumn {
                get {
                    return this.columnValid;
                }
            }
            
            public SuperRow this[int index] {
                get {
                    return ((SuperRow)(this.Rows[index]));
                }
            }
            
            public event SuperRowChangeEventHandler SuperRowChanged;
            
            public event SuperRowChangeEventHandler SuperRowChanging;
            
            public event SuperRowChangeEventHandler SuperRowDeleted;
            
            public event SuperRowChangeEventHandler SuperRowDeleting;
            
            public void AddSuperRow(SuperRow row) {
                this.Rows.Add(row);
            }
            
            public SuperRow AddSuperRow(string PassCode, string Valid) {
                SuperRow rowSuperRow = ((SuperRow)(this.NewRow()));
                rowSuperRow.ItemArray = new object[] {
                        PassCode,
                        Valid};
                this.Rows.Add(rowSuperRow);
                return rowSuperRow;
            }
            
            public SuperRow FindByPassCode(string PassCode) {
                return ((SuperRow)(this.Rows.Find(new object[] {
                            PassCode})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                SuperDataTable cln = ((SuperDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new SuperDataTable();
            }
            
            internal void InitVars() {
                this.columnPassCode = this.Columns["PassCode"];
                this.columnValid = this.Columns["Valid"];
            }
            
            private void InitClass() {
                this.columnPassCode = new DataColumn("PassCode", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPassCode);
                this.columnValid = new DataColumn("Valid", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValid);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnPassCode}, true));
                this.columnPassCode.AllowDBNull = false;
                this.columnPassCode.Unique = true;
            }
            
            public SuperRow NewSuperRow() {
                return ((SuperRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new SuperRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(SuperRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.SuperRowChanged != null)) {
                    this.SuperRowChanged(this, new SuperRowChangeEvent(((SuperRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.SuperRowChanging != null)) {
                    this.SuperRowChanging(this, new SuperRowChangeEvent(((SuperRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.SuperRowDeleted != null)) {
                    this.SuperRowDeleted(this, new SuperRowChangeEvent(((SuperRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.SuperRowDeleting != null)) {
                    this.SuperRowDeleting(this, new SuperRowChangeEvent(((SuperRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveSuperRow(SuperRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SuperRow : DataRow {
            
            private SuperDataTable tableSuper;
            
            internal SuperRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableSuper = ((SuperDataTable)(this.Table));
            }
            
            public string PassCode {
                get {
                    return ((string)(this[this.tableSuper.PassCodeColumn]));
                }
                set {
                    this[this.tableSuper.PassCodeColumn] = value;
                }
            }
            
            public string Valid {
                get {
                    try {
                        return ((string)(this[this.tableSuper.ValidColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSuper.ValidColumn] = value;
                }
            }
            
            public bool IsValidNull() {
                return this.IsNull(this.tableSuper.ValidColumn);
            }
            
            public void SetValidNull() {
                this[this.tableSuper.ValidColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SuperRowChangeEvent : EventArgs {
            
            private SuperRow eventRow;
            
            private DataRowAction eventAction;
            
            public SuperRowChangeEvent(SuperRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public SuperRow Row {
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
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SwUsersDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnAccount_Type;
            
            private DataColumn columnAddress;
            
            private DataColumn columnDesignation;
            
            private DataColumn column_E_Mail;
            
            private DataColumn column_Father_s_Name;
            
            private DataColumn columnID;
            
            private DataColumn columnName;
            
            private DataColumn columnPassCode;
            
            private DataColumn columnPasswd;
            
            private DataColumn columnUser_Id;
            
            internal SwUsersDataTable() : 
                    base("SwUsers") {
                this.InitClass();
            }
            
            internal SwUsersDataTable(DataTable table) : 
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
            
            internal DataColumn Account_TypeColumn {
                get {
                    return this.columnAccount_Type;
                }
            }
            
            internal DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            
            internal DataColumn DesignationColumn {
                get {
                    return this.columnDesignation;
                }
            }
            
            internal DataColumn _E_MailColumn {
                get {
                    return this.column_E_Mail;
                }
            }
            
            internal DataColumn _Father_s_NameColumn {
                get {
                    return this.column_Father_s_Name;
                }
            }
            
            internal DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            internal DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            
            internal DataColumn PassCodeColumn {
                get {
                    return this.columnPassCode;
                }
            }
            
            internal DataColumn PasswdColumn {
                get {
                    return this.columnPasswd;
                }
            }
            
            internal DataColumn User_IdColumn {
                get {
                    return this.columnUser_Id;
                }
            }
            
            public SwUsersRow this[int index] {
                get {
                    return ((SwUsersRow)(this.Rows[index]));
                }
            }
            
            public event SwUsersRowChangeEventHandler SwUsersRowChanged;
            
            public event SwUsersRowChangeEventHandler SwUsersRowChanging;
            
            public event SwUsersRowChangeEventHandler SwUsersRowDeleted;
            
            public event SwUsersRowChangeEventHandler SwUsersRowDeleting;
            
            public void AddSwUsersRow(SwUsersRow row) {
                this.Rows.Add(row);
            }
            
            public SwUsersRow AddSwUsersRow(string Account_Type, string Address, string Designation, string _E_Mail, string _Father_s_Name, string ID, string Name, string PassCode, string Passwd, string User_Id) {
                SwUsersRow rowSwUsersRow = ((SwUsersRow)(this.NewRow()));
                rowSwUsersRow.ItemArray = new object[] {
                        Account_Type,
                        Address,
                        Designation,
                        _E_Mail,
                        _Father_s_Name,
                        ID,
                        Name,
                        PassCode,
                        Passwd,
                        User_Id};
                this.Rows.Add(rowSwUsersRow);
                return rowSwUsersRow;
            }
            
            public SwUsersRow FindByID(string ID) {
                return ((SwUsersRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                SwUsersDataTable cln = ((SwUsersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new SwUsersDataTable();
            }
            
            internal void InitVars() {
                this.columnAccount_Type = this.Columns["Account Type"];
                this.columnAddress = this.Columns["Address"];
                this.columnDesignation = this.Columns["Designation"];
                this.column_E_Mail = this.Columns["E-Mail"];
                this.column_Father_s_Name = this.Columns["Father\'s Name"];
                this.columnID = this.Columns["ID"];
                this.columnName = this.Columns["Name"];
                this.columnPassCode = this.Columns["PassCode"];
                this.columnPasswd = this.Columns["Passwd"];
                this.columnUser_Id = this.Columns["User Id"];
            }
            
            private void InitClass() {
                this.columnAccount_Type = new DataColumn("Account Type", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAccount_Type);
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnDesignation = new DataColumn("Designation", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDesignation);
                this.column_E_Mail = new DataColumn("E-Mail", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column_E_Mail);
                this.column_Father_s_Name = new DataColumn("Father\'s Name", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column_Father_s_Name);
                this.columnID = new DataColumn("ID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnID);
                this.columnName = new DataColumn("Name", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnName);
                this.columnPassCode = new DataColumn("PassCode", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPassCode);
                this.columnPasswd = new DataColumn("Passwd", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPasswd);
                this.columnUser_Id = new DataColumn("User Id", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUser_Id);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnID}, true));
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
            }
            
            public SwUsersRow NewSwUsersRow() {
                return ((SwUsersRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new SwUsersRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(SwUsersRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.SwUsersRowChanged != null)) {
                    this.SwUsersRowChanged(this, new SwUsersRowChangeEvent(((SwUsersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.SwUsersRowChanging != null)) {
                    this.SwUsersRowChanging(this, new SwUsersRowChangeEvent(((SwUsersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.SwUsersRowDeleted != null)) {
                    this.SwUsersRowDeleted(this, new SwUsersRowChangeEvent(((SwUsersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.SwUsersRowDeleting != null)) {
                    this.SwUsersRowDeleting(this, new SwUsersRowChangeEvent(((SwUsersRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveSwUsersRow(SwUsersRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SwUsersRow : DataRow {
            
            private SwUsersDataTable tableSwUsers;
            
            internal SwUsersRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableSwUsers = ((SwUsersDataTable)(this.Table));
            }
            
            public string Account_Type {
                get {
                    try {
                        return ((string)(this[this.tableSwUsers.Account_TypeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSwUsers.Account_TypeColumn] = value;
                }
            }
            
            public string Address {
                get {
                    try {
                        return ((string)(this[this.tableSwUsers.AddressColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSwUsers.AddressColumn] = value;
                }
            }
            
            public string Designation {
                get {
                    try {
                        return ((string)(this[this.tableSwUsers.DesignationColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSwUsers.DesignationColumn] = value;
                }
            }
            
            public string _E_Mail {
                get {
                    try {
                        return ((string)(this[this.tableSwUsers._E_MailColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSwUsers._E_MailColumn] = value;
                }
            }
            
            public string _Father_s_Name {
                get {
                    try {
                        return ((string)(this[this.tableSwUsers._Father_s_NameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSwUsers._Father_s_NameColumn] = value;
                }
            }
            
            public string ID {
                get {
                    return ((string)(this[this.tableSwUsers.IDColumn]));
                }
                set {
                    this[this.tableSwUsers.IDColumn] = value;
                }
            }
            
            public string Name {
                get {
                    try {
                        return ((string)(this[this.tableSwUsers.NameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSwUsers.NameColumn] = value;
                }
            }
            
            public string PassCode {
                get {
                    try {
                        return ((string)(this[this.tableSwUsers.PassCodeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSwUsers.PassCodeColumn] = value;
                }
            }
            
            public string Passwd {
                get {
                    try {
                        return ((string)(this[this.tableSwUsers.PasswdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSwUsers.PasswdColumn] = value;
                }
            }
            
            public string User_Id {
                get {
                    try {
                        return ((string)(this[this.tableSwUsers.User_IdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSwUsers.User_IdColumn] = value;
                }
            }
            
            public bool IsAccount_TypeNull() {
                return this.IsNull(this.tableSwUsers.Account_TypeColumn);
            }
            
            public void SetAccount_TypeNull() {
                this[this.tableSwUsers.Account_TypeColumn] = System.Convert.DBNull;
            }
            
            public bool IsAddressNull() {
                return this.IsNull(this.tableSwUsers.AddressColumn);
            }
            
            public void SetAddressNull() {
                this[this.tableSwUsers.AddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsDesignationNull() {
                return this.IsNull(this.tableSwUsers.DesignationColumn);
            }
            
            public void SetDesignationNull() {
                this[this.tableSwUsers.DesignationColumn] = System.Convert.DBNull;
            }
            
            public bool Is_E_MailNull() {
                return this.IsNull(this.tableSwUsers._E_MailColumn);
            }
            
            public void Set_E_MailNull() {
                this[this.tableSwUsers._E_MailColumn] = System.Convert.DBNull;
            }
            
            public bool Is_Father_s_NameNull() {
                return this.IsNull(this.tableSwUsers._Father_s_NameColumn);
            }
            
            public void Set_Father_s_NameNull() {
                this[this.tableSwUsers._Father_s_NameColumn] = System.Convert.DBNull;
            }
            
            public bool IsNameNull() {
                return this.IsNull(this.tableSwUsers.NameColumn);
            }
            
            public void SetNameNull() {
                this[this.tableSwUsers.NameColumn] = System.Convert.DBNull;
            }
            
            public bool IsPassCodeNull() {
                return this.IsNull(this.tableSwUsers.PassCodeColumn);
            }
            
            public void SetPassCodeNull() {
                this[this.tableSwUsers.PassCodeColumn] = System.Convert.DBNull;
            }
            
            public bool IsPasswdNull() {
                return this.IsNull(this.tableSwUsers.PasswdColumn);
            }
            
            public void SetPasswdNull() {
                this[this.tableSwUsers.PasswdColumn] = System.Convert.DBNull;
            }
            
            public bool IsUser_IdNull() {
                return this.IsNull(this.tableSwUsers.User_IdColumn);
            }
            
            public void SetUser_IdNull() {
                this[this.tableSwUsers.User_IdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SwUsersRowChangeEvent : EventArgs {
            
            private SwUsersRow eventRow;
            
            private DataRowAction eventAction;
            
            public SwUsersRowChangeEvent(SwUsersRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public SwUsersRow Row {
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
