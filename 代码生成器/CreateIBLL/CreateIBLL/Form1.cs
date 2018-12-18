using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateIBLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet DS_Database = GetDatabaseList(GetConnection(TB_IP.Text, TB_User.Text, TB_Pwd.Text));
            CB_DataList.DataSource = DS_Database.Tables[0];
            CB_DataList.DisplayMember = "Name";
            CB_DataList.ValueMember = "Name";

            DataSet DS_Table = GetTableList(GetConnection(TB_IP.Text, TB_User.Text, TB_Pwd.Text), CB_DataList.SelectedText);

            CB_TableList.DataSource = DS_Table.Tables[0];
            CB_TableList.DisplayMember = "Name";
            CB_TableList.ValueMember = "Name";

        }

        private SqlConnection GetConnection(string IP, string User, string Pwd)
        {
            string ConnectionString = "server=" + IP + ";uid=" + User + ";pwd=" + Pwd + ";database=Master;Max Pool Size=1000;";
            SqlConnection Conn = new SqlConnection(ConnectionString);
            return Conn;
        }
        /// <summary>
        /// 查询所有数据库名
        /// </summary>
        /// <param name="Conn"></param>
        /// <returns></returns>
        private DataSet GetDatabaseList(SqlConnection Conn)
        {
            DataSet ds = new DataSet();
            SqlCommand Com = new SqlCommand("SELECT Name FROM Master..SysDatabases ORDER BY Name ", Conn);
            if (Conn.State != ConnectionState.Open)
                Conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = Com;
            adapter.Fill(ds);

            return ds;



        }
        /// <summary>
        /// 获取所有表名
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="DataBaseName"></param>
        /// <returns></returns>
        private DataSet GetTableList(SqlConnection Conn, string DataBaseName)
        {
            DataSet ds = new DataSet();
            SqlCommand Com = new SqlCommand("SELECT Name FROM " + DataBaseName + "..SysObjects Where XType='U' or XType='V' ORDER BY Name  ", Conn);
            if (Conn.State != ConnectionState.Open)
                Conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = Com;
            adapter.Fill(ds);

            return ds;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string TableName = CB_TableList.SelectedValue.ToString();
            string NameSpace = TB_NameSpace.Text;
            if (string.IsNullOrEmpty(NameSpace))
            {
                NameSpace = " Hengyun.Areas.IBLL";
            }
            StringBuilder Str_Text = new StringBuilder();
            Str_Text.Append("//=============================================================\r\n");
            Str_Text.Append("/*\r\n");
            Str_Text.Append("   类名称:I" + TableName + "Bll\r\n");
            Str_Text.Append("   类描述：\r\n");
            Str_Text.Append("   生成日期：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n");
            Str_Text.Append("*/              \r\n");
            Str_Text.Append("//=============================================================\r\n");
            Str_Text.Append("using System;\r\n");
            Str_Text.Append("using System.Collections.Generic;\r\n");
            Str_Text.Append("using System.Linq;\r\n");
            Str_Text.Append("using System.Text;\r\n");
            Str_Text.Append("using System.Threading.Tasks;\r\n");
            Str_Text.Append("using Hengyun.Areas.IBLL;\r\n");
            Str_Text.Append("using Hengyun.Areas.MODEL;\r\n");
            Str_Text.Append("namespace " + NameSpace + "\r\n");
            Str_Text.Append("{\r\n\r\n");
            Str_Text.Append(" public interface I" + TableName + "Bll: IBaseBll<" + TableName + ">\r\n");
            Str_Text.Append("   {\r\n\r\n");
            //Str_Text.Append("       public " + TableName + "IBLL()\r\n");
            //Str_Text.Append("       {\r\n");
            //Str_Text.Append("           base._tableName = \"" + TableName + "\";\r\n");
            //Str_Text.Append("       }\r\n\r\n");


            //Str_Text.Append("        int I" + TableName + "IBLL.Add(" + TableName + " Model)\r\n");
            //Str_Text.Append("       {\r\n");
            //Str_Text.Append("           return base.Insert(Model);\r\n");
            //Str_Text.Append("       }\r\n\r\n");

            //Str_Text.Append("        int I" + TableName + "IBLL.Delete(" + TableName + "Query query)\r\n");
            //Str_Text.Append("       {\r\n");
            //Str_Text.Append("           return base.Delete(query);\r\n");
            //Str_Text.Append("       }\r\n\r\n");

            //Str_Text.Append("         " + TableName + " I" + TableName + "IBLL.Get(" + TableName + "Query query, bool cache)\r\n");
            //Str_Text.Append("       {\r\n");
            //Str_Text.Append("           if (query != null)\r\n");
            //Str_Text.Append("                return base.GetModel(query, cache);\r\n");
            //Str_Text.Append("           else\r\n");
            //Str_Text.Append("               return null;\r\n");
            //Str_Text.Append("       }\r\n\r\n");

            //Str_Text.Append("         List<" + TableName + "> I" + TableName + "IBLL.GetItems(" + TableName + "Query query, bool cache)\r\n");
            //Str_Text.Append("       {\r\n");
            //Str_Text.Append("           return base.GetList(query, cache).ToList();\r\n");
            //Str_Text.Append("       }\r\n\r\n");

            //Str_Text.Append("         PaginationList<" + TableName + "> I" + TableName + "IBLL.GetPager(SP_Pagination pagination, bool cache)\r\n");
            //Str_Text.Append("       {\r\n");
            //Str_Text.Append("           if (pagination != null)\r\n");
            //Str_Text.Append("                return base.GetListBySp_Pag(pagination, cache);\r\n");
            //Str_Text.Append("           else\r\n");
            //Str_Text.Append("               return null;\r\n");
            //Str_Text.Append("       }\r\n\r\n");

            //Str_Text.Append("        int I" + TableName + "IBLL.Update(" + TableName + " Model, " + TableName + "Query query)\r\n");
            //Str_Text.Append("       {\r\n");
            //Str_Text.Append("            return base.Update(Model, query);\r\n");
            //Str_Text.Append("       }\r\n\r\n");

            Str_Text.Append("   }\r\n\r\n");
            Str_Text.Append("}\r\n\r\n");
            TB_Result.Text = Str_Text.ToString();

        }

        private void CB_DataList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CB_DataList.SelectedValue == null)
                return;
            string DataBase = CB_DataList.SelectedValue.ToString();
            DataSet DS_Table = GetTableList(GetConnection(TB_IP.Text, TB_User.Text, TB_Pwd.Text), DataBase);
            CB_TableList.DataSource = DS_Table.Tables[0];
            CB_TableList.DisplayMember = "Name";
            CB_TableList.ValueMember = "Name";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Path = System.AppDomain.CurrentDomain.BaseDirectory + CB_DataList.SelectedValue.ToString() + "\\";
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            string NameSpace = TB_NameSpace.Text;
            if (string.IsNullOrEmpty(NameSpace))
            {
                NameSpace = " Hengyun.Areas.IBLL";
            }

            foreach (DataRowView item in CB_TableList.Items)
            {
                string TableName = item.Row.ItemArray[0].ToString();
                if (!File.Exists(Path + "I"+TableName + "Bll.cs"))
                {
                    FileInfo FilePath = new FileInfo(Path +"I"+TableName + "Bll.cs");
                    FilePath.Create().Close();

                }
                StringBuilder Str_Text = new StringBuilder();
                Str_Text.Append("//=============================================================\r\n");
                Str_Text.Append("/*\r\n");
                Str_Text.Append("   类名称:I" + TableName + "Bll\r\n");
                Str_Text.Append("   类描述：\r\n");
                Str_Text.Append("   生成日期：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n");
                Str_Text.Append("*/              \r\n");
                Str_Text.Append("//=============================================================\r\n");
                Str_Text.Append("using System;\r\n");
                Str_Text.Append("using System.Collections.Generic;\r\n");
                Str_Text.Append("using System.Linq;\r\n");
                Str_Text.Append("using System.Text;\r\n");
                Str_Text.Append("using System.Threading.Tasks;\r\n");
                Str_Text.Append("using Hengyun.Areas.IBLL;\r\n");
                Str_Text.Append("using Hengyun.Areas.MODEL;\r\n");


                Str_Text.Append("namespace " + NameSpace + "\r\n");
                Str_Text.Append("{\r\n\r\n");
                Str_Text.Append(" public interface I" + TableName + "Bll: IBaseBll<" + TableName + ">\r\n");
                Str_Text.Append("   {\r\n\r\n");
                //Str_Text.Append("       public " + TableName + "IBLL()\r\n");
                //Str_Text.Append("       {\r\n");
                //Str_Text.Append("           base._tableName = \"" + TableName + "\";\r\n");
                //Str_Text.Append("       }\r\n\r\n");


                //Str_Text.Append("        int I" + TableName + "IBLL.Add(" + TableName + " Model)\r\n");
                //Str_Text.Append("       {\r\n");
                //Str_Text.Append("           return base.Insert(Model);\r\n");
                //Str_Text.Append("       }\r\n\r\n");

                //Str_Text.Append("        int I" + TableName + "IBLL.Delete(" + TableName + "Query query)\r\n");
                //Str_Text.Append("       {\r\n");
                //Str_Text.Append("           return base.Delete(query);\r\n");
                //Str_Text.Append("       }\r\n\r\n");

                //Str_Text.Append("         " + TableName + " I" + TableName + "IBLL.Get(" + TableName + "Query query, bool cache)\r\n");
                //Str_Text.Append("       {\r\n");
                //Str_Text.Append("           if (query != null)\r\n");
                //Str_Text.Append("                return base.GetModel(query, cache);\r\n");
                //Str_Text.Append("           else\r\n");
                //Str_Text.Append("               return null;\r\n");
                //Str_Text.Append("       }\r\n\r\n");

                //Str_Text.Append("         List<" + TableName + "> I" + TableName + "IBLL.GetItems(" + TableName + "Query query, bool cache)\r\n");
                //Str_Text.Append("       {\r\n");
                //Str_Text.Append("           return base.GetList(query, cache).ToList();\r\n");
                //Str_Text.Append("       }\r\n\r\n");

                //Str_Text.Append("         PaginationList<" + TableName + "> I" + TableName + "IBLL.GetPager(SP_Pagination pagination, bool cache)\r\n");
                //Str_Text.Append("       {\r\n");
                //Str_Text.Append("           if (pagination != null)\r\n");
                //Str_Text.Append("                return base.GetListBySp_Pag(pagination, cache);\r\n");
                //Str_Text.Append("           else\r\n");
                //Str_Text.Append("               return null;\r\n");
                //Str_Text.Append("       }\r\n\r\n");

                //Str_Text.Append("        int I" + TableName + "Helper.Update(" + TableName + " Model, " + TableName + "Query query)\r\n");
                //Str_Text.Append("       {\r\n");
                //Str_Text.Append("            return base.Update(Model, query);\r\n");
                //Str_Text.Append("       }\r\n\r\n");

                Str_Text.Append("   }\r\n\r\n");
                Str_Text.Append("}\r\n\r\n");
                TB_Result.Text = Str_Text.ToString();


                StreamWriter SW = new StreamWriter(Path + "I"+TableName + "Bll.cs");
                SW.WriteLine(Str_Text);
                SW.Close();
            }



        }
    }
}
