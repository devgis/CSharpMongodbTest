using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MongoDB;
using System.Collections;

namespace MongoTest
{
    public partial class MainForm : Form
    {
        private Mongo mongo;
        private IMongoDatabase GameData;

        public MainForm()
        {
            InitializeComponent();
            Setup();
        }

        private void btGGroup_Click(object sender, EventArgs e)
        {
            var ggrouptable = GameData.GetCollection<Document>("GGroup");
            var ggroups = ggrouptable.FindAll();

            foreach (Document d in ggroups.Documents)
            {
                //key
                var selector = new Document { { "key", d["key"] } };
                var ggroupsamed = ggrouptable.Find(selector);
                if (ggroupsamed.Documents.Count<Document>() > 1)
                {
                    int i = 1;
                    foreach (Document redit in ggroupsamed.Documents)
                    {
                        var editselector = new Document { { "_id", redit["_id"] } };
                        redit["key"] = d["key"].ToString() +"("+ i+")";
                        ggrouptable.Update(redit, selector);
                        i++;
                        //更新
                    }
                }

                //name
                var selectornamed = new Document { { "name", d["name"] } };
                var ggroupsamedname = ggrouptable.Find(selectornamed);
                if (ggroupsamedname.Documents.Count<Document>() > 1)
                {
                    int i = 1;
                    foreach (Document redit in ggroupsamedname.Documents)
                    {
                        var editselector = new Document { { "_id", redit["_id"] } };
                        redit["name"] = d["name"].ToString() + "(" + i + ")";
                        ggrouptable.Update(redit, editselector);
                        i++;
                        //更新
                    }
                }

                //admin
                var selectoradmin = new Document { { "admin", d["admin"] } };
                var ggroupsamedadmin = ggrouptable.Find(selectoradmin);
                if (ggroupsamedadmin.Documents.Count<Document>() > 1)
                {
                    int i = 1;
                    foreach (Document redit in ggroupsamedadmin.Documents)
                    {
                        var editselector = new Document { { "_id", redit["_id"] } };
                        redit["name"] = d["name"].ToString() + "(" + i + ")";
                        ggrouptable.Update(redit, editselector);
                        i++;
                        //更新
                    }
                }
                
            }
            MessageBox.Show("执行成功");
        }


        private void btRoleTable_Click(object sender, EventArgs e)
        {
            var roletable = GameData.GetCollection<Document>("RoleTable");
            var roles = roletable.FindAll();

            foreach (Document d in roles.Documents)
            {
                var selector = new Document { { "name", d["name"] } };
                var rolesamed = roletable.Find(selector);
                if (rolesamed.Documents.Count<Document>() > 1)
                {
                    int i = 1;
                    foreach (Document redit in rolesamed.Documents)
                    {
                        var editselector = new Document { { "_id", redit["_id"] } };
                        redit["name"] = d["name"].ToString() +"(" + i + ")";
                        roletable.Update(redit, editselector);
                        i++;
                        //更新
                    }
                }
            }
            MessageBox.Show("执行成功");
        }

        private void btUserTable_Click(object sender, EventArgs e)
        {
            var usertable = GameData.GetCollection<Document>("UserTable");
            var users = usertable.FindAll();

            foreach (Document d in users.Documents)
            {
                var selector = new Document { { "user", d["user"] } };
                var usersamed = usertable.Find(selector);
                if (usersamed.Documents.Count<Document>() > 1)
                {
                    int i = 1;
                    foreach (Document dedit in usersamed.Documents)
                    {
                        var editselector = new Document { { "_id", dedit["_id"] } };
                        dedit["user"] = d["user"].ToString() + "(" + i + ")";
                        usertable.Update(dedit, editselector);
                        i++;
                        //更新
                    }
                }
            }          
            MessageBox.Show("执行成功");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        ///   Setup the collection and insert some data into it.
        /// </summary>
        public void Setup()
        {
            var connstr = ConfigurationManager.AppSettings["GameData"];
            if(String.IsNullOrEmpty(connstr))
                throw new ArgumentNullException("Connection string not found.");
            mongo = new Mongo(connstr);
            mongo.Connect();
            GameData = mongo["GameData"];
        }

        private void btRoleUser_Click(object sender, EventArgs e)
        {
            var roletable = GameData.GetCollection<Document>("RoleTable");
            var usertable = GameData.GetCollection<Document>("UserTable");
            var userlist = usertable.FindAll();
            var roles = roletable.FindAll();

            Dictionary<string, int> dicCount = new Dictionary<string, int>();

            foreach (Document d in roles.Documents)
            {
                var selector = new Document { { "user", d["user"] } };

                //var entity = collection.FindOne(query);
                int icount = 0;
                foreach (Document duser in userlist.Documents)
                {
                    //if (duser["user"].ToString().StartsWith(d["user"].ToString()))
                    if (duser["user"].ToString().Split('(')[0].Equals(d["user"].ToString()))
                    {
                        icount++;
                    }
                }
                //计算数量
                if (icount <= 1)
                {
                    continue; //不存在直接退出 当前用户在用户表中不存在 或者只有一项 不进行处理
                }
                else
                {
                    //当前用户类似的名称在数据库中有多项
                    var rolesamed = roletable.Find(selector);
                    if (rolesamed.Documents.Count<Document>() > 0)
                    {
                        //查找user的数量
                        int i = 1;
                        foreach (Document redit in rolesamed.Documents)
                        {
                            //判断user不存在
                            var userlist2 = usertable.Find(new Document { { "user", redit["user"] } });
                            if (userlist2.Documents.Count<Document>() >= 0)
                            {
                                var editselector = new Document { { "_id", redit["_id"] } };
                                redit["user"] = d["user"].ToString() + "(" + i + ")";
                                roletable.Update(redit, editselector);
                                i++;
                                if (i > icount)
                                {
                                    i = 1;
                                }
                                //更新
                            }
                            //已经存在 不需要更新
                        }
                    }
                }
            }
            MessageBox.Show("执行成功");
        }

        private void btDeleteRow_Click(object sender, EventArgs e)
        {
            var roletable = GameData.GetCollection<Document>("RoleTable");
            var roles = roletable.FindAll();

            foreach (Document d in roles.Documents)
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(d["uptimer"]);
                    if (dt < dtDeleteTime.Value.Date)
                    {
                        roletable.Remove(d);
                    }
                }
                catch
                { }
            }
            MessageBox.Show("执行成功");
        }
        Document docEditRole = null;
        private void btReadRole_Click(object sender, EventArgs e)
        {
            docEditRole = null;
            if (string.IsNullOrEmpty(tbEditRole.Text.Trim()))
            {
                MessageBox.Show("请输入角色名！");
                tbEditRole.Focus();
            }
            else
            {
                //查询
                var roletable = GameData.GetCollection<Document>("RoleTable");
                var selector = new Document { { "name", tbEditRole.Text } };
                var rolesamed = roletable.Find(selector);
                if (rolesamed.Documents.Count<Document>() >= 1)
                {
                    docEditRole = rolesamed.Documents.First<Document>();
                    tbEditUserName.Text = docEditRole["user"].ToString();
                }
                else
                {
                    MessageBox.Show(string.Format("没有名称为{0}的角色，请检查输入！", tbEditRole.Text));
                    tbEditUserName.Text = string.Empty;
                    tbEditRole.Focus();
                }
            }
        }

        private void btEditUser_Click(object sender, EventArgs e)
        {
            if (docEditRole == null)
            {
                MessageBox.Show("请先查找角色！");
                tbEditRole.Focus(); 
                return;
            }
            if (string.IsNullOrEmpty(tbEditUserName.Text.Trim()))
            {
                MessageBox.Show("请输入用户名！");
                tbEditUserName.Focus();
                return;
            }
            var roletable = GameData.GetCollection<Document>("RoleTable");
            var editselector = new Document { { "_id", docEditRole["_id"] } };
            docEditRole["user"] = tbEditUserName.Text;
            roletable.Update(docEditRole, editselector);
            MessageBox.Show("保存成功！");
        }
    }
}
