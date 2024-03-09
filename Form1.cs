using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDemoApp1
{
    public partial class Form1 : Form
    {
        PostgreSQLHandler dbHandler;
        public Form1()
        {
            InitializeComponent();
            dbHandler = new PostgreSQLHandler("localhost", "production_accounting", "postgres", "3409");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbHandler.ExecuteNonQuery("INSERT INTO \"Agent\" (\"Title\", \"AgentTypeID\", \"Address\", \"INN\", \"KPP\", \"DirectorName\", \"Phone\", \"Email\", \"Logo\", \"Priority\")\r\nVALUES ('Базовый агент', '1', 'г. Москва, улица Пушкина, д. Колотушкина', '123456789012', '123456789', 'Иванов И. И.', '8 (987) 654-32-10', 'email@email.ru', '\\products\\default.jpg', '1');");
            DataTable dataTable = dbHandler.ExecuteQuery("SELECT * FROM public.\"Agent\"\r\nORDER BY \"ID\" ASC ");
        }
    }
}
