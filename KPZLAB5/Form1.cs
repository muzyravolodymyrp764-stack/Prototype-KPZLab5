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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace KPZLAB5
{
    public partial class Form1 : Form
    {
        private House currentHouse;
        private Image currentImage;
        //private List<PictureBox> cloneImages = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWooden_Click(object sender, EventArgs e)
        {
            BuildHouse(new WoodenHouseBuilder(), Properties.Resources.wooden);
        }

        private void btnBrick_Click(object sender, EventArgs e)
        {
            BuildHouse(new BrickHouseBuilder(), Properties.Resources.brick);
        }

        private void btnModern_Click(object sender, EventArgs e)
        {
            BuildHouse(new ModernHouseBuilder(), Properties.Resources.modern);
        }

        private void BuildHouse(HouseBuilder builder, Image image)
        {
            Director director = new Director();
            director.Construct(builder);
            currentHouse = builder.GetHouse();
            currentImage = image;

            pictureBox1.Image = image;
            // об'єкт привязується до пропертігрід
            propertyGridOriginal.SelectedObject = currentHouse;

            flowLayoutPanelClones.Controls.Clear();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            if (currentHouse == null)
            {
                MessageBox.Show("Спочатку побудуйте будинок!");
                return;
            }

            //1 створ клон об’єкта будинку
            House cloneHouse = (House)currentHouse.Clone();

            //2 створ візуальні елементи 

            int cloneCount = flowLayoutPanelClones.Controls.Count + 1;

            // заголовок для картки
            Label lblTitle = new Label
            {
                Text = $"Клон {cloneCount}",
                Font = new Font(this.Font, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(3)
            };

            // картинка клона
            PictureBox clonePic = new PictureBox
            {
                //створюється новий бітмап щоб клон був незалежний
                Image = new Bitmap(currentImage),
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 150,
                Height = 150,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3)
            };

            PropertyGrid cloneGrid = new PropertyGrid
            {
                //привязка сітки до об'єкта-клону
                SelectedObject = cloneHouse,
                Width = 200,
                Height = 180,
                ToolbarVisible = false, // - зайві кнопки
                HelpVisible = false,    // - опис внизу
                Margin = new Padding(3)
            };

            // 3 створ картку яка об'єднує ці елементи
            FlowLayoutPanel cloneCard = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown, //згори донизу
                WrapContents = false, //не переносити
                AutoSize = true,      //автоматична висота
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            // 4 + всі елементи на картку
            cloneCard.Controls.Add(lblTitle);
            cloneCard.Controls.Add(clonePic);
            cloneCard.Controls.Add(cloneGrid);

            // 5 + готову картку на головну панель клонів
            flowLayoutPanelClones.Controls.Add(cloneCard);

            MessageBox.Show($"Клон {cloneCount} створено!");
        }
    }
}
