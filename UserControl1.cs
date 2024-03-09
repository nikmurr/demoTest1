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
    public partial class CardElement : UserControl
    {
        public CardElement()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CardElement_Load(object sender, EventArgs e)
        {
            int parentWidth = Parent != null ? Parent.Width : 0;
            int cardWidth = parentWidth / 2 - 6;  

            Width = cardWidth;
        }
    }
}
