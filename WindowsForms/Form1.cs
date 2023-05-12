using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {
      throw new System.NotImplementedException();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string username = tbUsername.Text, password = tbPassword.Text;
      string checkUser = "Admin", checkPass = "123";
      if (username == checkUser && password == checkPass)
      {
        MessageBox.Show("Đăng nhập thành công");
      }
      else
      {
        MessageBox.Show("Đang nhập thất bại");
      }
    }
  }
}
