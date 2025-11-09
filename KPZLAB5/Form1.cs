using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KPZLAB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWooden_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            HouseBuilder builder = new WoodenHouseBuilder();
            director.Construct(builder);
            var house = builder.GetHouse();

            pictureBox1.Image = Properties.Resources.wooden;
            textBox1.Text = house.ShowInfo();
        }

        private void btnBrick_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            HouseBuilder builder = new BrickHouseBuilder();
            director.Construct(builder);
            var house = builder.GetHouse();

            pictureBox1.Image = Properties.Resources.brick;
            textBox1.Text = house.ShowInfo();
        }

        private void btnModern_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            HouseBuilder builder = new ModernHouseBuilder();
            director.Construct(builder);
            var house = builder.GetHouse();

            pictureBox1.Image = Properties.Resources.modern;
            textBox1.Text = house.ShowInfo();
        }
    }
}
