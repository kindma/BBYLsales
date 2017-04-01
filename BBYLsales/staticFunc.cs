using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Dynamic;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace BBYLsales
{
    public static class staticFunc
    {
        /// <summary>
        /// 根据货号找到库存中的产品资料
        /// </summary>
        /// <param name="huohao"></param>
        /// <returns></returns>
        public static List<productBasic> getProductByHuohao(string huohao)
        {


            DataClassLinqDataContext dl = new DataClassLinqDataContext();

            var s =
                from o in dl.F_CLASS
                from p in o.F_INCOME
                where p.货号 == huohao && p.进货数量>0
                select new productBasic
                {
                    颜色货号锁定 = (bool)o.颜色货号锁定,
                    季节 = p.季节,
                    品牌 = p.品牌,
                    类型 = p.类型,
                    颜色 = p.颜色,
                    吊牌价 = p.吊牌价,
                    进货价 = p.进货价

                };

            return s.ToList();

        }

        /// <summary>
        /// 复制两个表格行，但第一列不复制。因为一般是KEY
        /// </summary>
        /// <param name="s">源行</param>
        /// <param name="t">目标行</param>
        public static void copyDataGridViewRow(DataGridViewRow s, DataGridViewRow t)
        {

            for (int i = 1; i < s.Cells.Count; i++)
            {
                t.Cells[i].Value = s.Cells[i].Value;
            }


        }


        /// <summary>
        /// 将给定的查询表达式中的某一条件置换为指定的条件
        ///  要求源条件中无括号，无置于双引号中的“xxx and xxx"字样
        /// </summary>
        /// <param name="SubjectString">源条条,如 A>10 AND B>1 OR C="FIND"</param>
        /// <param name="condition">替换条件 如,AND A>1，如果是删除条件，只要保证列名正确就行， 如AND A>10与OR A like 1的效果是一样的</param>
        /// <param name="condition">是添加还是删除条件</param>
        /// <returns></returns>
        public static string sqlFilterChangCondition(string SubjectString, string condition, bool isAdd)
        {
            condition = condition.Trim(); // 去掉条件两边空格
            SubjectString = SubjectString.Trim();

            //定义并检查分析条件的格式
            Regex theRegex = new Regex(@"^(?<a>(and|or))\s*(?<b>\S+)\s*(?<c>([<>=]+|like))\s*(?<d>\S+)$", RegexOptions.IgnoreCase);
            Match mc = theRegex.Match(condition);

            if (!mc.Success) return SubjectString;  //如果条件不合格,直接返回原条件的原字串

            //拆分语名,本例无须如此复杂
            GroupCollection gc = mc.Groups;
            var condtionClass = new
            {
                allline = mc.Value,
                preCondition = gc["a"].Value,
                conditionName = gc["b"].Value,
                conditionType = gc["c"].Value,
                conditionValue = gc["d"].Value
            };

            //替换原始条件中的欲加条件
            theRegex = new Regex(@"((and|or)\s*)" + condtionClass.conditionName + @"\s*([<>=]+|like)\s*\S+", RegexOptions.IgnoreCase);
            SubjectString = theRegex.Replace(SubjectString, " ");

            theRegex = new Regex(@"^" + condtionClass.conditionName + @"\s*([<>=]+|like)\s*\S+", RegexOptions.IgnoreCase);
            SubjectString = theRegex.Replace(SubjectString, " ");

            //添加新条件
            if (isAdd) SubjectString += "  " + condition;

            //替换行首的AND,OR
            theRegex = new Regex(@"^\s*(and|or)\s*", RegexOptions.IgnoreCase);
            SubjectString = theRegex.Replace(SubjectString, "");

            return SubjectString;

        }

        /// <summary>
        /// 递归显示求得所有子结点
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<TreeNode> getNodsByID(int id)
        {
            //递归求出所有根节点下的子结点
            List<TreeNode> l = new List<TreeNode>();
            DataClassesSaleLinqDataContext DataContextLinq = new DataClassesSaleLinqDataContext();
            var a = DataContextLinq.F_S_CLOTHTYPE.Where(p => p.父类ID == id && p.ID != 1).Select(p => p);

            foreach (var q in a)
            {
                TreeNode tn = new TreeNode();
                tn.Name = q.ID.ToString();
                tn.Text = q.类别;
                var ll = getNodsByID(q.ID);
                foreach (TreeNode tnn in ll) tn.Nodes.Add(tnn);
                l.Add(tn);
            }
            return l;
        }

        /// <summary>
        /// 添加服装类型的树
        /// </summary>
        /// <param name="t"></param>
        public static void bindClothTypeToTreeView(TreeView t)
        {
            t.Nodes.Clear();
            TreeNode root = new TreeNode("所有类别");
            root.Name = "1";
            foreach (TreeNode tn in staticFunc.getNodsByID(1)) root.Nodes.Add(tn);
            t.Nodes.Add(root);
            t.ExpandAll(); //全部展开
        }
        
        /// <summary>
        /// 重新刷新库存
        /// </summary>
        public static void refreshStock()
        {
            string s = "stockcount";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.saleConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            con.Close();
        }

        



        /// <summary>
        /// 用SQL过程检查某款式的库存是否大于零
        /// </summary>
        /// <param name="huohao">货号</param>
        /// <param name="acolor">颜色ID</param>
        /// <param name="asize">尺寸ID</param>
        /// <returns></returns>
        public static int getMountOfCloth(string huohao, int asize, int acolor)
        {
            string s = "StockCountByHuohao";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.saleConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.Parameters.Add(new SqlParameter("@huohao", huohao));
            cmd.Parameters.Add(new SqlParameter("@acolor", acolor));
            cmd.Parameters.Add(new SqlParameter("@asize", asize));
            cmd.CommandType = CommandType.StoredProcedure;
            var mout = cmd.ExecuteScalar();
            con.Close();
            return (int)mout;


        }

        public static int CountMainTable(DataGridView grid, string colName)
        {
            int returnVal=0;
            foreach (DataGridViewRow dr in grid.Rows)
            {
                returnVal += (int)dr.Cells[colName].Value;
            }
            return returnVal;
        }


        /// <summary>
        /// 表格中的录入人员值是否是当前用户，以防随意更改别人的记录
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static bool allowModRecord(DataGridView grid)
        {
            DataGridViewRow dr = grid.CurrentRow;
            if (dr.Cells["录入人员"].Value.ToString() == staticLoinUser.loginID.ToString()) return true;
            else return false;
        }

        public static bool exeSQL(string sqlstr)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.saleConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(sqlstr, con);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return false;

            }
            finally
            {
                con.Close();

            }
        }
        /////////////====PRGORAM END
    }
}
