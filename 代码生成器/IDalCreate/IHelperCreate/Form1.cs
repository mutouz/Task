using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace IDalCreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            SqlCommand Com = new SqlCommand("SELECT Name FROM " + DataBaseName + "..SysObjects Where XType='U'  or XType='V' ORDER BY Name  ", Conn);
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
                NameSpace = "Hengyun.Areas.IDAL";
            }
            StringBuilder Str_Text = new StringBuilder();
            Str_Text.Append("//=============================================================\r\n");
            Str_Text.Append("/*\r\n");
            Str_Text.Append("   类名称:I" + TableName + "Dal\r\n");
            Str_Text.Append("   类描述：\r\n");
            Str_Text.Append("   生成日期：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n");
            Str_Text.Append("*/              \r\n");
            Str_Text.Append("//=============================================================\r\n");
            Str_Text.Append("using System;\r\n");
            Str_Text.Append("using System.Collections.Generic;\r\n");
            Str_Text.Append("using System.Linq;\r\n");
            Str_Text.Append("using System.Text;\r\n");
            Str_Text.Append("using Hengyun.Areas.IDAL;\r\n\r\n");
            Str_Text.Append("using System.Threading.Tasks;\r\n\r\n");
            Str_Text.Append("using Hengyun.Areas.MODEL;\r\n");
            Str_Text.Append("namespace " + NameSpace + "\r\n");
            Str_Text.Append("{\r\n\r\n");
            Str_Text.Append(" public interface I" + TableName + "Dal:IBaseDal<"+ TableName + ">\r\n");
            Str_Text.Append("   {\r\n\r\n");
            //Str_Text.Append("        new void Dispose();\r\n\r\n");
            //Str_Text.Append("        int Add(Hengyun.Model." + TableName + " Model);\r\n\r\n");
            //Str_Text.Append("        int Update(Hengyun.Model." + TableName + " Model, Hengyun.Querys." + TableName + "Query query);\r\n\r\n");
            //Str_Text.Append("        int Delete(Hengyun.Querys." + TableName + "Query query);\r\n\r\n");
            //Str_Text.Append("        Hengyun.Model." + TableName + " Get(Hengyun.Querys." + TableName + "Query query, bool cache = true);\r\n\r\n");
            //Str_Text.Append("        List<Hengyun.Model." + TableName + "> GetItems(Hengyun.Querys." + TableName + "Query query, bool cache = true);\r\n\r\n");
            //Str_Text.Append("        WoniuT.Framework.Model.PaginationList<Hengyun.Model." + TableName + "> GetPager(WoniuT.Framework.Model.SP_Pagination pagination, bool cache = true);\r\n\r\n");
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
                NameSpace = "Hengyun.Areas.IDAL";
            }

            foreach (DataRowView item in CB_TableList.Items)
            {
                string TableName = item.Row.ItemArray[0].ToString();
                if (!File.Exists(Path + "I" + TableName + "Dal.cs"))
                {
                    FileInfo FilePath = new FileInfo(Path + "I" + TableName + "Dal.cs");
                    FilePath.Create().Close();

                }
                StringBuilder Str_Text = new StringBuilder();
                Str_Text.Append("//=============================================================\r\n");
                Str_Text.Append("/*\r\n");
                Str_Text.Append("   类名称:I" + TableName + "Dal\r\n");
                Str_Text.Append("   类描述：\r\n");
                Str_Text.Append("   生成日期：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n");
                Str_Text.Append("*/              \r\n");
                Str_Text.Append("//=============================================================\r\n");
                Str_Text.Append("using System;\r\n");
                Str_Text.Append("using System.Collections.Generic;\r\n");
                Str_Text.Append("using System.Linq;\r\n");
                Str_Text.Append("using System.Text;\r\n");
                Str_Text.Append("using Hengyun.Areas.MODEL;\r\n");
                Str_Text.Append("using System.Threading.Tasks;\r\n\r\n");
                Str_Text.Append("namespace " + NameSpace + "\r\n");
                Str_Text.Append("{\r\n\r\n");
                Str_Text.Append(" public interface I" + TableName + "Dal:IBaseDal<" + TableName + ">\r\n");
                Str_Text.Append("   {\r\n\r\n");
                //Str_Text.Append("        new void Dispose();\r\n\r\n");
                //Str_Text.Append("        int Add(Hengyun.Model." + TableName + " Model);\r\n\r\n");
                //Str_Text.Append("        int Update(Hengyun.Model." + TableName + " Model, Hengyun.Querys." + TableName + "Query query);\r\n\r\n");
                //Str_Text.Append("        int Delete(Hengyun.Querys." + TableName + "Query query);\r\n\r\n");
                //Str_Text.Append("        Hengyun.Model." + TableName + " Get(Hengyun.Querys." + TableName + "Query query, bool cache = true);\r\n\r\n");
                //Str_Text.Append("        List<Hengyun.Model." + TableName + "> GetItems(Hengyun.Querys." + TableName + "Query query, bool cache = true);\r\n\r\n");
                //Str_Text.Append("        WoniuT.Framework.Model.PaginationList<Hengyun.Model." + TableName + "> GetPager(WoniuT.Framework.Model.SP_Pagination pagination, bool cache = true);\r\n\r\n");
                Str_Text.Append("   }\r\n\r\n");
                Str_Text.Append("}\r\n\r\n");
                TB_Result.Text = Str_Text.ToString();


                StreamWriter SW = new StreamWriter(Path + "I" + TableName + "Dal.cs");
                SW.WriteLine(Str_Text);
                SW.Close();
            }



        }

        private void TB_IP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
