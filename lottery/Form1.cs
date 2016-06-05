using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace lottery
{

    public partial class Form1 : Form
    {
        ListBox lb = new ListBox();

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + "\\Common Files\\Lotto\\lottery.accdb;Persist Security Info=False;");
        private StringReader myReader;

        public Form1()
        {
            InitializeComponent();
        }

        private int validateData()
        {
            int flag = 0;

            errorProvider1.Clear();

            if (draw_time.SelectedIndex == -1)
            {
                errorProvider1.SetError(draw_time, "Please select the draw time  !");
                flag = 1;
            }

            if (pick5_radbtn.Checked == true)
            {
                int z;
                max_num_txt.Text.Trim();
                col1_txt.Text.Trim();
                col2_txt.Text.Trim();
                col3_txt.Text.Trim();
                col4_txt.Text.Trim();
                col5_txt.Text.Trim();


                if (max_num_txt.Text == "")
                {
                    errorProvider1.SetError(max_num_txt, "please enter the correct value");
                    flag = 1;
                }
                else
                {
                    try
                    {
                        z = int.Parse(max_num_txt.Text);


                        if (Convert.ToInt32(max_num_txt.Text) < 20)
                        {
                            errorProvider1.SetError(max_num_txt, "minimum number should be 20");
                            flag = 1;
                        }
                    }
                    catch (Exception err)
                    {
                        errorProvider1.SetError(max_num_txt, "please enter the integer numbers");
                        flag = 1;
                        return flag; ;
                    }

                    if (col1_txt.Text == "" || col2_txt.Text == "" || col3_txt.Text == "" || col4_txt.Text == "" || col5_txt.Text == "")
                    {
                        errorProvider1.SetError(col5_txt, "please enter the numbers completely");
                        flag = 1;
                    }



                    else
                    {
                        int q, w, e, r, t, m;
                        try
                        {

                            q = int.Parse(col1_txt.Text);
                            w = int.Parse(col2_txt.Text);
                            e = int.Parse(col3_txt.Text);
                            r = int.Parse(col4_txt.Text);
                            t = int.Parse(col5_txt.Text);
                            if (q > Convert.ToInt32(max_num_txt.Text) || w > Convert.ToInt32(max_num_txt.Text) || e > Convert.ToInt32(max_num_txt.Text) || r > Convert.ToInt32(max_num_txt.Text) || t > Convert.ToInt32(max_num_txt.Text))
                            {
                                errorProvider1.SetError(col5_txt, "numbers should be within the range");
                                flag = 1;
                            }
                            int h, j, k, l, o;
                            h = Convert.ToInt32(col1_txt.Text);
                            j = Convert.ToInt32(col2_txt.Text);
                            k = Convert.ToInt32(col3_txt.Text);
                            l = Convert.ToInt32(col4_txt.Text);
                            o = Convert.ToInt32(col5_txt.Text);
                            if (h == k || h == l || h == j || h == o || j == k || j == l || j == o || k == l || k == o || l == o)
                            {
                                errorProvider1.SetError(col5_txt, "Values cannot be repeated");
                                flag = 1;
                            }
                        }
                        catch (Exception err)
                        {
                            errorProvider1.SetError(col5_txt, "please enter the integer numbers");
                            flag = 1;
                        }
                    }
                }
            }
            if (pick3_radbtn.Checked == true)
            {
                if (res_tbx.Text == "")
                {
                    errorProvider1.SetError(res_tbx, "please enter the correct value");
                    flag = 1;
                }
                else if (res_tbx.Text.Length != 3)
                {
                    errorProvider1.SetError(res_tbx, "please enter the correct digits");
                    flag = 1;
                }
                else
                {
                    int q;
                    try
                    {
                        q = int.Parse(res_tbx.Text);
                    }
                    catch (Exception err)
                    {
                        errorProvider1.SetError(res_tbx, "please enter the integer value");
                        flag = 1;
                    }

                }
            }




            if (pick4_radbtn.Checked == true)
            {
                if (res_tbx.Text == "")
                {
                    errorProvider1.SetError(res_tbx, "please enter the correct value");
                    flag = 1;
                }
                else if (res_tbx.Text.Length != 4)
                {
                    errorProvider1.SetError(res_tbx, "please enter the correct digits");
                    flag = 1;
                }
                else
                {
                    int q;
                    try
                    {
                        q = int.Parse(res_tbx.Text);
                    }
                    catch (Exception err)
                    {
                        errorProvider1.SetError(res_tbx, "please enter the integer value");
                        flag = 1;
                    }

                }
            }
            return flag;
        }
        public void IsAccess2007Installed()
        {
            RegistryKey rootKey = Registry.ClassesRoot.OpenSubKey(@"Access.Application\CurVer", false);

            if (rootKey == null)
            {
                string path = Application.StartupPath.ToString() + "" + "\\AccessRuntime.exe";
                MessageBox.Show("No access Installed in your system please install the application and try again");

                FileInfo fi = new FileInfo(path);

                System.Diagnostics.ProcessStartInfo proinfo = new System.Diagnostics.ProcessStartInfo(path);
                proinfo.WorkingDirectory = fi.DirectoryName;
                System.Diagnostics.Process pro = new System.Diagnostics.Process();
                pro.StartInfo = proinfo;
                pro.Start();
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsAccess2007Installed();

            results_lbl.Visible = false;
            conn.Close();


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                error_lbl.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        private void sav_btn_Click(object sender, EventArgs e)
        {
            conn.Close();
            try
            {

                if (validateData() == 0)
                {
                    conn.Open();

                    if (pick3_radbtn.Checked == true || pick4_radbtn.Checked == true)
                    {
                        OleDbCommand com = new OleDbCommand("select * from data_entry where (date_in=DateValue(@date) and type=@pick) and draw=@drawtime", conn);


                        OleDbCommand cmd = new OleDbCommand("insert into data_entry values(@date,@pick,@result,@drawtime)", conn);
                        OleDbParameter param = new OleDbParameter("@date", dateTimePicker1.SelectionStart.Date.ToShortDateString());
                        OleDbParameter param1 = new OleDbParameter("@date", dateTimePicker1.SelectionStart.Date.ToShortDateString());
                        cmd.Parameters.Add(param);
                        com.Parameters.Add(param1);

                        if (pick3_radbtn.Checked)
                        {
                            param = new OleDbParameter("@pick", pick3_radbtn.Text);
                            param1 = new OleDbParameter("@pick", pick3_radbtn.Text.ToString());
                            cmd.Parameters.Add(param);
                            com.Parameters.Add(param1);
                        }
                        else
                            if (pick4_radbtn.Checked)
                            {
                                param = new OleDbParameter("@pick", pick4_radbtn.Text);
                                param1 = new OleDbParameter("@pick", pick4_radbtn.Text.ToString());
                                cmd.Parameters.Add(param);
                                com.Parameters.Add(param1);
                            }
                        param = new OleDbParameter("@result", res_tbx.Text);
                        cmd.Parameters.Add(param);

                        param = new OleDbParameter("@drawtime", draw_time.Text);
                        param1 = new OleDbParameter("@drawtime", draw_time.Text.ToString());
                        cmd.Parameters.Add(param);
                        com.Parameters.Add(param1);
                        OleDbDataReader df = com.ExecuteReader();

                        int lount = 0;
                        while (df.Read())
                        {
                            lount++;
                        }
                        df.Close();

                        if (lount > 0)
                        {
                            MessageBox.Show("Data for this date is already entered.  Please check and try again");
                        }
                        else
                        {

                            int rom = cmd.ExecuteNonQuery();
                            if (rom > 0)
                            {
                                res_tbx.Text = "";
                                error_lbl.Text = "INSERTED";
                                res_tbx.Focus();
                            }

                        }
                    }
                    else
                    {
                        OleDbCommand com1 = new OleDbCommand("select * from data_entry2 where date_in=DateValue(@date)", conn);
                        OleDbCommand cmd = new OleDbCommand("insert into data_entry2 values(@date,@max_value,@draw,@col1,@col2,@col3,@col4,@col5)", conn);
                        OleDbParameter param = new OleDbParameter("@date", dateTimePicker1.SelectionStart.Date.ToShortDateString());
                        OleDbParameter param3 = new OleDbParameter("@date", dateTimePicker1.SelectionStart.Date.ToShortDateString());
                        cmd.Parameters.Add(param);
                        com1.Parameters.Add(param3);
                        param = new OleDbParameter("@max_value", Convert.ToInt32(max_num_txt.Text));
                        cmd.Parameters.Add(param);
                        param = new OleDbParameter("@draw", draw_time.Text);
                        cmd.Parameters.Add(param);
                        param = new OleDbParameter("col1", Convert.ToInt32(col1_txt.Text));
                        cmd.Parameters.Add(param);
                        param = new OleDbParameter("col2", Convert.ToInt32(col2_txt.Text));
                        cmd.Parameters.Add(param);

                        param = new OleDbParameter("col3", Convert.ToInt32(col3_txt.Text));
                        cmd.Parameters.Add(param);

                        param = new OleDbParameter("col4", Convert.ToInt32(col4_txt.Text));
                        cmd.Parameters.Add(param);

                        param = new OleDbParameter("col5", Convert.ToInt32(col5_txt.Text));
                        cmd.Parameters.Add(param);
                        OleDbDataReader dd = com1.ExecuteReader();
                        if (dd.HasRows)
                        {
                            MessageBox.Show("Data for this date is already entered.  Please check and try again");
                        }
                        else
                        {

                            int rom = cmd.ExecuteNonQuery();

                            if (rom > 0)
                            {
                                res_tbx.Text = "";
                                error_lbl.Text = "INSERTED";
                                col1_txt.Clear();
                                col2_txt.Clear();
                                col3_txt.Clear();
                                col4_txt.Clear();
                                col5_txt.Clear();
                            }
                        }
                    }
                }
            }

            finally
            {
                conn.Close();
            }
        }

        private object ToString(object p)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
            listBox1.Items.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.ClearSelection();
            listBox2.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.Columns.Clear();
            dataGridView3.ClearSelection();
            conn.Close();
            int pick3 = 0;
            int elicount = 0;
            int count = 0, retcount = 1;
            try
            {
                conn.Open();
                if (pick3radio.Checked == true || pick4radio.Checked == true)
                {
                    OleDbCommand cmd1 = new OleDbCommand("SELECT * FROM data_entry WHERE (draw=@drawtype1 or draw=@drawtype) and type=@pick  ORDER BY date_in DESC;", conn);
                    OleDbCommand cmd2 = new OleDbCommand("SELECT date_in,data,draw FROM data_entry WHERE (draw=@drawtype1 or draw=@drawtype) and type=@pick  ORDER BY date_in DESC;", conn);

                    cmd1.Parameters.Add(new OleDbParameter("@drawtype", comboBox1.Text.ToString()));
                    cmd1.Parameters.Add(new OleDbParameter("@drawtype1", comboBox2.Text.ToString()));
                    cmd2.Parameters.Add(new OleDbParameter("@drawtype", comboBox1.Text.ToString()));
                    cmd2.Parameters.Add(new OleDbParameter("@drawtype1", comboBox2.Text.ToString()));
                    if (pick3radio.Checked == true)
                    {
                        cmd1.Parameters.Add(new OleDbParameter("@pick", pick3radio.Text));
                        cmd2.Parameters.Add(new OleDbParameter("@pick", pick3radio.Text));
                        pick3 = 3;
                    }
                    else if (pick4radio.Checked == true)
                    {
                        cmd1.Parameters.Add(new OleDbParameter("@pick", pick4radio.Text));
                        cmd2.Parameters.Add(new OleDbParameter("@pick", pick4radio.Text));
                        pick3 = 4;
                    }

                    OleDbDataReader dr = cmd1.ExecuteReader();
                    OleDbDataReader dr3 = cmd2.ExecuteReader();


                    dataGridView3.Columns.Add(dr3.ToString(), dr3.GetName(0).ToString());

                    dataGridView3.Columns.Add(dr3.GetName(0).ToString(), dr3.GetName(1).ToString());
                    dataGridView3.Columns.Add(dr3.GetName(0).ToString(), dr3.GetName(2).ToString());



                    while (dr3.Read())
                    {
                        string dd = dr3[0].ToString().Substring(0, 11);
                        dataGridView3.Rows.Add(dd, dr3[1].ToString(), dr3[2].ToString());

                    }
                    dr3.Close();


                    if (dr.HasRows)
                    {
                        int[,] a = new int[9, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
                        int[,] b = new int[9, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
                        int[,] c = new int[10, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
                        int[,] eli = new int[4, 8] { { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 } };
                        int[,] ret = new int[4, 8] { { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 } };
                        int[,] neu = new int[4, 8] { { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 } };

                        String[] arr = new String[100];
                        while (dr.Read())
                        {
                            arr[count] = dr[2].ToString();
                            count++;
                        }
                        dr.Close();

                        if (count >= 18)
                        {

                            count = 8;
                            for (int ibx = 0; ibx < 9; ibx++)
                            {
                                for (int jbx = 0; jbx < pick3; jbx++)
                                {
                                    b[ibx, jbx] = Convert.ToInt32(arr[count].Substring(jbx, 1));
                                }
                                count--;
                            }
                            count = 17;
                            for (int ibx = 0; ibx < 9; ibx++)
                            {
                                for (int jbx = 0; jbx < pick3; jbx++)
                                {
                                    a[ibx, jbx] = Convert.ToInt32(arr[count].Substring(jbx, 1));
                                }
                                count--;
                            }



                            for (int j = 0; j < pick3; j++)
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    switch (a[i, j])
                                    {
                                        case 0: c[0, j]++;
                                            break;
                                        case 1: c[1, j]++;
                                            break;
                                        case 2: c[2, j]++;
                                            break;
                                        case 3: c[3, j]++;
                                            break;
                                        case 4: c[4, j]++;
                                            break;
                                        case 5: c[5, j]++;
                                            break;
                                        case 6: c[6, j]++;
                                            break;
                                        case 7: c[7, j]++;
                                            break;
                                        case 8: c[8, j] = c[8, j]++;
                                            break;
                                        case 9: c[9, j]++;
                                            break;
                                    }
                                }

                            }
                            //high value numbers

                            for (int j = 0; j < pick3; j++)
                            {
                                elicount = 0;
                                for (int i = 0; i < 10; i++)
                                {
                                    count = 0;
                                    if (c[i, j] == 0)
                                    {
                                        for (int k = 0; k < 9; k++)
                                        {
                                            if (b[k, j] == i)
                                            {
                                                count++;
                                            }
                                        }
                                        if (count == 4)
                                        {
                                            eli[j, elicount] = i;
                                            elicount++;
                                        }
                                        else if (count == 3)
                                        {
                                            count = 0;
                                            for (int k = 2; k < 9; k++)
                                            {
                                                if (b[k, j] == i)
                                                {
                                                    count++;
                                                }
                                            }
                                            if (count != 3)
                                            {
                                                count = 0;
                                                for (int k = 5; k < 9; k++)
                                                {
                                                    if (b[k, j] == i)
                                                    {
                                                        count++;
                                                    }
                                                }
                                                if (count == 2)
                                                {
                                                    eli[j, elicount] = i;
                                                    elicount++;
                                                }
                                            }
                                            else
                                            {
                                                eli[j, elicount] = i;
                                                elicount++;
                                            }
                                        }
                                        else if (count == 2)
                                        {
                                            count = 0;
                                            for (int k = 5; k < 9; k++)
                                            {
                                                if (b[k, j] == i)
                                                {
                                                    count++;
                                                }
                                            }
                                            if (count == 2)
                                            {
                                                eli[j, elicount] = i;
                                                elicount++;
                                            }
                                        }
                                    }
                                }
                            }

                            //retreating numbers

                            for (int j = 0; j < pick3; j++)
                            {
                                elicount = 0;
                                for (int i = 0; i < 9; i++)
                                {
                                    count = 0;
                                    for (int k = 0; k < 9; k++)
                                    {
                                        if (a[i, j] == a[k, j])
                                        {
                                            count++;
                                        }
                                    }
                                    if (count == 4)
                                    {
                                        for (int k = 0; k < 9; k++)
                                        {
                                            if (a[i, j] == b[k, j])
                                            {
                                                retcount = 0;
                                            }
                                        }
                                        if (retcount != 0)
                                        {
                                            ret[j, elicount] = a[i, j];
                                            elicount++;
                                        }
                                    }
                                    else if (count == 3)
                                    {
                                        count = 0;
                                        for (int k = 2; k < 9; k++)
                                        {
                                            if (a[i, j] == a[k, j])
                                            {
                                                count++;
                                            }
                                        }
                                        if (count != 3)
                                        {
                                            count = 0;
                                            for (int k = 5; k < 9; k++)
                                            {
                                                if (a[i, j] == a[k, j])
                                                {
                                                    count++;
                                                }
                                            }
                                            if (count == 2)
                                            {
                                                for (int k = 0; k < 9; k++)
                                                {
                                                    if (a[i, j] == b[k, j])
                                                    {
                                                        retcount = 0;
                                                    }
                                                }
                                                if (retcount != 0)
                                                {
                                                    ret[j, elicount] = a[i, j];
                                                    elicount++;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            for (int k = 0; k < 9; k++)
                                            {
                                                if (a[i, j] == b[k, j])
                                                {
                                                    retcount = 0;
                                                }
                                            }
                                            if (retcount != 0)
                                            {
                                                ret[j, elicount] = a[i, j];
                                                elicount++;
                                            }
                                        }
                                    }
                                    else if (count == 2)
                                    {
                                        count = 0;
                                        for (int k = 5; k < 9; k++)
                                        {
                                            if (a[i, j] == a[k, j])
                                            {
                                                count++;
                                            }
                                        }
                                        if (count == 2)
                                        {
                                            for (int k = 0; k < 9; k++)
                                            {
                                                if (a[i, j] == b[k, j])
                                                {
                                                    retcount = 0;
                                                }
                                            }
                                            if (retcount != 0)
                                            {
                                                ret[j, elicount] = a[i, j];
                                                elicount++;
                                            }
                                        }
                                    }
                                }


                            }

                            int flag = 0;
                            for (int i = 0; i < pick3; i++)
                            {
                                int j;
                                count = 0;
                                for (j = 0; eli[i, j] != -1; j++)  //checking for the HVN occurances for each coloumn
                                {
                                    count++;
                                }
                                if (count >= 2)
                                {
                                    flag++;
                                }
                                //neutral numbers
                                else
                                {

                                    elicount = 0;
                                    for (int l = 0; l < 10; l++)
                                    {
                                        count = 0;
                                        if (c[l, i] == 0)
                                        {
                                            for (int k = 0; k < 9; k++)
                                            {
                                                if (b[k, i] == l)
                                                {
                                                    count++;
                                                }
                                            }
                                            if (count == 1)
                                            {
                                                neu[i, elicount] = l;
                                                elicount++;
                                            }
                                            else if (count == 2)
                                            {
                                                count = 0;
                                                for (int k = 5; k < 9; k++)
                                                {
                                                    if (b[k, i] == l)
                                                    {
                                                        count++;
                                                    }
                                                }
                                                if (count != 2)
                                                {
                                                    neu[i, elicount] = l;
                                                    elicount++;
                                                }
                                            }
                                            else if (count == 3)
                                            {
                                                count = 0;
                                                for (int k = 2; k < 9; k++)
                                                {
                                                    if (b[k, i] == l)
                                                    {
                                                        count++;
                                                    }
                                                }
                                                if (count != 3)
                                                {
                                                    count = 0;
                                                    for (int k = 5; k < 9; k++)
                                                    {
                                                        if (b[k, i] == l)
                                                        {
                                                            count++;
                                                        }
                                                    }
                                                    if (count != 2)
                                                    {
                                                        neu[i, elicount] = l;
                                                        elicount++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            results_lbl.Visible = true;
                            int hvnkount = 0, neukount = 0;
                            listBox2.Items.Clear();
                            listBox2.Items.Add("HIGH VALUE NUMBERS");
                            for (int i = 0; i < pick3; i++)
                            {
                                string rom = "";
                                for (int j = 0; eli[i, j] != -1; j++)
                                {
                                    rom = rom + "  " + eli[i, j].ToString();
                                    hvnkount++;
                                }
                                listBox2.Items.Add(rom);
                            }
                            listBox2.Items.Add("NEUTRAL NUMBERS");
                            for (int i = 0; i < pick3; i++)
                            {
                                string rom = "";
                                for (int j = 0; neu[i, j] != -1; j++)
                                {
                                    rom = rom + "  " + neu[i, j].ToString();
                                    neukount++;
                                }
                                listBox2.Items.Add(rom);
                            }
                            int total = hvnkount + neukount;
                            if (flag != pick3)
                            {
                                if (hvnkount < (total * 50 / 100))
                                {
                                    error_lbl.Text = "";
                                }
                                else if (hvnkount < (total * 75 / 100))
                                {
                                    error_lbl.Text = "THREE CONSECUTIVE GAMES";
                                }
                                else if (hvnkount <= total)
                                {
                                    error_lbl.Text = "FOUR CONSECUTIVE GAMES";
                                }
                            }
                            else
                            {
                                error_lbl.Text = "EIGHT CONSECUTIVE GAMES";
                            }

                            if (pick4radio.Checked == true)
                            {
                                int[] array1 = new int[5] { -1, -1, -1, -1, -1 };
                                int[] array2 = new int[5] { -1, -1, -1, -1, -1 };
                                int[] array3 = new int[5] { -1, -1, -1, -1, -1 };
                                int[] array4 = new int[5] { -1, -1, -1, -1, -1 };
                                int jount = 0;
                                for (int j = 0; eli[0, j] != -1 || neu[0, j] != -1; j++)
                                {
                                    if (eli[0, j] != -1)
                                    {
                                        array1[jount++] = eli[0, j];
                                    }
                                    if (neu[0, j] != -1)
                                    {
                                        array1[jount++] = neu[0, j];
                                    }
                                }
                                jount = 0;
                                for (int j = 0; eli[1, j] != -1 || neu[1, j] != -1; j++)
                                {
                                    if (eli[1, j] != -1)
                                    {
                                        array2[jount++] = eli[1, j];
                                    }
                                    if (neu[1, j] != -1)
                                    {
                                        array2[jount++] = neu[1, j];
                                    }
                                }
                                jount = 0;
                                for (int j = 0; eli[2, j] != -1 || neu[2, j] != -1; j++)
                                {
                                    if (eli[2, j] != -1)
                                    {
                                        array3[jount++] = eli[2, j];
                                    }
                                    if (neu[2, j] != -1)
                                    {
                                        array3[jount++] = neu[2, j];
                                    }
                                }
                                jount = 0;
                                for (int j = 0; eli[3, j] != -1 || neu[3, j] != -1; j++)
                                {
                                    if (eli[3, j] != -1)
                                    {
                                        array4[jount++] = eli[3, j];
                                    }
                                    if (neu[3, j] != -1)
                                    {
                                        array4[jount++] = neu[3, j];
                                    }
                                }
                                listBox1.Items.Clear();
                                for (int i = 0; array1[i] != -1; i++)
                                {
                                    for (int j = 0; array2[j] != -1; j++)
                                    {
                                        for (int k = 0; array3[k] != -1; k++)
                                        {
                                            for (int l = 0; array4[l] != -1; l++)
                                            {
                                                String result = array1[i].ToString() + "  " + array2[j].ToString() + "  " + array3[k].ToString() + "  " + array4[l].ToString();
                                                listBox1.Items.Add(result);
                                            }
                                        }
                                    }
                                }
                            }
                            if (pick3radio.Checked == true)
                            {
                                int[] array1 = new int[5] { -1, -1, -1, -1, -1 };
                                int[] array2 = new int[5] { -1, -1, -1, -1, -1 };
                                int[] array3 = new int[5] { -1, -1, -1, -1, -1 };

                                int jount = 0;
                                for (int j = 0; eli[0, j] != -1 || neu[0, j] != -1; j++)
                                {
                                    if (eli[0, j] != -1)
                                    {
                                        array1[jount++] = eli[0, j];
                                    }
                                    if (neu[0, j] != -1)
                                    {
                                        array1[jount++] = neu[0, j];
                                    }
                                }
                                jount = 0;
                                for (int j = 0; eli[1, j] != -1 || neu[1, j] != -1; j++)
                                {
                                    if (eli[1, j] != -1)
                                    {
                                        array2[jount++] = eli[1, j];
                                    }
                                    if (neu[1, j] != -1)
                                    {
                                        array2[jount++] = neu[1, j];
                                    }
                                }
                                jount = 0;
                                for (int j = 0; eli[2, j] != -1 || neu[2, j] != -1; j++)
                                {
                                    if (eli[2, j] != -1)
                                    {
                                        array3[jount++] = eli[2, j];
                                    }
                                    if (neu[2, j] != -1)
                                    {
                                        array3[jount++] = neu[2, j];
                                    }
                                }
                                listBox1.Items.Clear();
                                for (int i = 0; array1[i] != -1; i++)
                                {
                                    for (int j = 0; array2[j] != -1; j++)
                                    {
                                        for (int k = 0; array3[k] != -1; k++)
                                        {
                                            String result = array1[i].ToString() + " " + array2[j].ToString() + " " + array3[k].ToString() + " ";
                                            listBox1.Items.Add(result);
                                        }
                                    }
                                }
                            }



                        }
                        else
                        {
                            error_lbl.Text = "minimum 18 games results required. Please input and try again";
                        }
                    }



                    else
                    {
                        error_lbl.Text = "There are no input values";
                    }


                }


                else
                {
                    count = 0;
                    int[,] array = new int[100, 5];
                    int max = 0, maxarray = 0, hvnkount = 0, neukount = 0;
                    OleDbCommand cmd1 = new OleDbCommand("Select * from  data_entry2 where draw=@draw or draw=@draw2 ORDER BY date_in DESC;", conn);
                    OleDbCommand cmd3 = new OleDbCommand("Select date_in,draw,col1,col2,col3,col4,col5 from  data_entry2 where draw=@draw or draw=@draw2 ORDER BY date_in DESC;", conn);
                    cmd1.Parameters.Add(new OleDbParameter("@draw", comboBox1.Text));
                    cmd1.Parameters.Add(new OleDbParameter("@draw2", comboBox2.Text));
                    cmd3.Parameters.Add(new OleDbParameter("@draw", comboBox1.Text));
                    cmd3.Parameters.Add(new OleDbParameter("@draw2", comboBox2.Text));
                    OleDbDataReader dr = cmd1.ExecuteReader();
                    OleDbDataReader dr4 = cmd3.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dataGridView3.Columns.Add(dr4.GetName(0), dr4.GetName(0));
                        dataGridView3.Columns.Add(dr4.GetName(1), dr4.GetName(1));
                        dataGridView3.Columns.Add(dr4.GetName(2), " NUMBERS");

                        while (dr4.Read())
                        {
                            string dd = dr4[0].ToString().Substring(0, 11);
                            string ddd = dr4[2] + " - " + dr4[3] + " - " + dr4[4] + " - " + dr4[5] + " - " + dr4[6];
                            dataGridView3.Rows.Add(dd, dr4[1], ddd);
                        }
                        dr4.Close();
                        while (dr.Read())
                        {
                            array[count, 0] = Convert.ToInt32(dr[3]);
                            array[count, 1] = Convert.ToInt32(dr[4]);
                            array[count, 2] = Convert.ToInt32(dr[5]);
                            array[count, 3] = Convert.ToInt32(dr[6]);
                            array[count, 4] = Convert.ToInt32(dr[7]);
                            int currentMaxValue = Convert.ToInt32(dr[1]);

                            count++;
                            max = (max < currentMaxValue) ? currentMaxValue : max;
                        }

                        if (count > 8)
                        {
                            maxarray = max + 1;
                            dr.Close();
                            int[] temp = new int[maxarray];
                            Array.Clear(temp, 0, maxarray);
                            int max_ele = max * 1 / 3;
                            for (int i = 3; check(temp, maxarray) > max_ele && i < count; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    temp[array[i, j]] = 1;
                                }
                            }

                            if (check(temp, maxarray) < max_ele)
                            {
                                int[] eliarray = new int[maxarray];
                                int[] hvn = new int[count];
                                int[] neutral = new int[count];
                                Array.Clear(eliarray, 0, maxarray);
                                Array.Clear(hvn, 0, count);
                                Array.Clear(neutral, 0, count);
                                int elecount = 0;
                                for (int i = 1; i < maxarray; i++)
                                {
                                    if (temp[i] == 0)
                                    {
                                        eliarray[elecount] = i;
                                        elecount++;
                                    }
                                }
                                for (int i = 0; eliarray[i] != 0; i++)
                                {
                                    int kount = 0;
                                    for (int j = 0; j < 4; j++)
                                    {
                                        for (int k = 0; k < 5; k++)
                                        {
                                            if (array[j, k] == eliarray[i])
                                            {
                                                kount++;
                                            }
                                        }
                                    }
                                    if (kount == 2)
                                    {
                                        hvn[hvnkount] = eliarray[i];
                                        hvnkount++;
                                    }
                                    else if (kount == 1)
                                    {
                                        neutral[neukount] = eliarray[i];
                                        neukount++;
                                    }
                                }

                                int[] tom = new int[20];
                                int kount2 = 0;
                                for (int i = 0; hvn[i] != 0 || neutral[i] != 0; i++)
                                {
                                    if (hvn[i] != 0)
                                    {
                                        tom[kount2++] = hvn[i];
                                    }
                                    if (neutral[i] != 0)
                                    {
                                        tom[kount2++] = neutral[i];
                                    }
                                }
                                listBox1.Items.Clear();



                                int total = hvnkount + neukount;
                                if (total < (elecount - 1) / 2)
                                {
                                    error_lbl.Text = "please try later on after some more games are entered";
                                }
                                else if (hvnkount < (total / 100) * 33)
                                {
                                    error_lbl.Text = "";
                                }
                                else if (hvnkount < ((total) * 50 / 100))
                                {

                                    error_lbl.Text = "3 consecutive games";
                                }
                                else if (hvnkount < ((total) * 75 / 100))
                                {
                                    error_lbl.Text = "4 consecutive games";
                                }
                                else if (hvnkount < ((total) * 100 / 100))
                                {
                                    error_lbl.Text = "5 consecutive games";
                                }
                                else if (hvnkount == total)
                                {
                                    error_lbl.Text = "8 CONSECUTIVE GAMES";
                                }
                                string res = "";
                                for (int i = 0; tom[i] != 0; i++)
                                {

                                    for (int j = i + 1; j <= total - 4; j++)
                                    {
                                        if (tom[j] == 0 && i != 0 && i + 1 != j)
                                        {
                                            total = total - j;
                                            j = 0;
                                        }
                                        res = tom[i].ToString() + " " + tom[j].ToString();
                                        for (int k = j + 1, pount = 0; pount < 3; k++, pount++)
                                        {
                                            if (tom[k] == 0 && i != 0)
                                            {
                                                k = 0;
                                            }
                                            res = res + " " + tom[k].ToString();
                                        }
                                        listBox1.Items.Add(res);

                                    }
                                    total++;
                                }
                                listBox2.Items.Clear();
                                listBox2.Items.Add("HIGH VALUE NUMBERS");
                                for (int i = 0; i < hvnkount; i++)
                                {
                                    listBox2.Items.Add(hvn[i].ToString());
                                }
                                listBox2.Items.Add("NEUTRAL NUMBERS");
                                for (int i = 0; i < neukount; i++)
                                {
                                    listBox2.Items.Add(neutral[i].ToString());
                                }
                            }
                            else
                            {
                                error_lbl.Text = "Not enough values to calculate please insert and try again";
                            }
                        }
                        else
                        {
                            error_lbl.Text = "Not enough values to calculate please insert and try again";
                        }
                    }
                }
            }
            catch (Exception err)
            {
                error_lbl.Text = err.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        public int check(int[] temp, int max)
        {
            int elecount1 = 0;

            for (int i = 1; i < max; i++)
            {
                if (temp[i] == 0)
                {
                    elecount1++;
                }
            }
            return elecount1;
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {
            pick3_radbtn.Checked = true;
            res_tbx.Clear();
            draw_time.SelectedIndex = -1;
            col1_txt.Clear();
            col2_txt.Clear();
            col3_txt.Clear();
            col4_txt.Clear();
            col5_txt.Clear();
            max_num_txt.Clear();
        }

        private void pick5_radbtn_CheckedChanged(object sender, EventArgs e)
        {
            max_num_txt.Enabled = true;
            col1_txt.Enabled = true;
            col2_txt.Enabled = true;
            col3_txt.Enabled = true;
            col4_txt.Enabled = true;
            col5_txt.Enabled = true;
            hide_lbl.Visible = false;
            res_tbx.Visible = false;
            res_tbx.Enabled = false;
            groupBox2.Visible = true;
            max_num_txt.Focus();
            if (draw_time.Items.Count == 2)
            {
                draw_time.Items.RemoveAt(1);
            }
        }

        private void pick4_radbtn_CheckedChanged(object sender, EventArgs e)
        {
            res_tbx.Enabled = true;
            hide_lbl.Visible = true;
            res_tbx.MaxLength = 4;
            res_tbx.Clear();
            res_tbx.Visible = true;
            res_tbx.Focus();
            groupBox2.Visible = false;
            max_num_txt.Enabled = false;
            col1_txt.Enabled = false;
            col2_txt.Enabled = false;
            col3_txt.Enabled = false;
            col4_txt.Enabled = false;
            col5_txt.Enabled = false;
            if (draw_time.Items.Count != 2)
            {
                draw_time.Items.Add("mid day");

            }
        }

        private void pick3_radbtn_CheckedChanged(object sender, EventArgs e)
        {
            res_tbx.Enabled = true;
            hide_lbl.Visible = true;
            res_tbx.MaxLength = 3;
            res_tbx.Clear();
            res_tbx.Visible = true;
            res_tbx.Focus();
            groupBox2.Visible = false;
            max_num_txt.Enabled = false;
            col1_txt.Enabled = false;
            col2_txt.Enabled = false;
            col3_txt.Enabled = false;
            col4_txt.Enabled = false;
            col5_txt.Enabled = false;
            if (draw_time.Items.Count != 2)
            {
                draw_time.Items.Add("mid day");

            }
        }

        private void Clr_btn_Click(object sender, EventArgs e)
        {
            max_num_txt.Clear();
            res_tbx.Clear();
            draw_time.Text = "---SELECT---";
            col1_txt.Clear();
            col2_txt.Clear();
            col3_txt.Clear();
            col4_txt.Clear();
            col5_txt.Clear();
            dateTimePicker1.Update(); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Close();
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("drop table data_entry", conn);
                OleDbCommand cmd1 = new OleDbCommand("create table data_entry(date_in date,type varchar,data varchar,draw varchar)", conn);
                OleDbCommand cmd2 = new OleDbCommand("drop table data_entry2", conn);
                OleDbCommand cmd3 = new OleDbCommand("create table data_entry2(date_in date,max_value number,draw varchar,col1 number,col2 number,col3 number,col4 number,col5 number)", conn);

                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                error_lbl.Text = "Cleared";
            }
            catch (Exception err)
            {
                error_lbl.Text = err.Message;
            }
            finally
            {
                conn.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            col1_txt.Clear();
            col2_txt.Clear();
            col3_txt.Clear();
            col4_txt.Clear();
            col5_txt.Clear();
        }

        private void pick3radio_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 2)
            {
                comboBox1.Items.Add("mid day");
                comboBox2.Items.Add("mid day");
            }
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.ClearSelection();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            error_lbl.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Dispose();
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {

            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = this.listBox1.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            // Work out the number of lines per page, using the MarginBounds.
            linesPerPage =
                ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            // Iterate over the string using the StringReader, printing each line.
            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                // calculate the next line position based on
                // the height of the font according to the printing device
                yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));

                // draw the next line in the rich edit control

                ev.Graphics.DrawString(line, printFont,
                                      myBrush, leftMargin,
                                       yPosition, new StringFormat());
                count++;
            }

            // If there are more lines, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

            myBrush.Dispose();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            string strText = "BEST COMBINATIONS \n";
            foreach (object x in listBox1.Items)
            {
                strText = strText + x.ToString() + "\n";
            }
            strText = strText + "\n\n";
            foreach (object x in listBox2.Items)
            {
                strText = strText + x.ToString() + "\n";
            }

            myReader = new StringReader(strText);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            error_lbl.Text = "";
            pick3radio.Checked = true;
            listBox1.Items.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.ClearSelection();
            listBox2.Items.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }

        private void pick5radio_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 2)
            {
                comboBox1.Items.RemoveAt(1);
                comboBox2.Items.RemoveAt(1);
            }
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.ClearSelection();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            error_lbl.Text = "";

        }

        private void pick4radio_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 2)
            {
                comboBox1.Items.Add("mid day");
                comboBox2.Items.Add("mid day");
            }
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.ClearSelection();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            error_lbl.Text = "";
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_DateChanged(object sender, DateRangeEventArgs e)
        {

            if (System.DateTime.Compare(dateTimePicker1.SelectionStart.Date, DateTime.Now) > 0)
            {

                MessageBox.Show("Invalid date selected");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.ClearSelection();
            listBox2.Items.Clear();
        }
    }
}