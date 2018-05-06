using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare.Controller
{
    class DynamicButton
    {
        List<Button> buttonList = new List<Button>();
        Control[] controls;
        Random random = new Random();

        public List<Button> ButtonList { get => buttonList; }
        public Control[] Controls { get => controls; }

        public void CreateButtons(DataTable dt)
        {
            List<string> fields = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                fields = row.ItemArray.Select(i => "" + i).ToList();
                buttonList.Add(BuildButton(fields));                
            }

            controls = ButtonList.ToArray();           
        }

        public void CreateOneButton(List<string> btData)
        {
            DataTable dt = new DataTable();            
            dt.Columns.Add("id");
            dt.Columns.Add("type");
            dt.Columns.Add("model");
            dt.Columns.Add("manufacturer");
            dt.Columns.Add("plate");
            dt.Columns.Add("year");

            dt.Rows.Add(btData.ToArray());                       

            CreateButtons(dt);
        }


        private Button BuildButton(List<string> vehicle)
        {
            Image img = BuildImage();
            string btText = vehicle[2] + "\r\n" + vehicle[4];

            Color brown = Color.FromArgb(28,26,26);
            Color green = Color.FromArgb(59, 221, 162);


            Button bt = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Image = img,
                Text = btText,
                ForeColor = brown,
                TextAlign = ContentAlignment.MiddleCenter,
                TextImageRelation = TextImageRelation.ImageAboveText,
                Width = img.Width + 20,
                Height = img.Height,
                BackColor = green

            };

            bt.FlatAppearance.BorderSize = 0;

            bt.Margin = new Padding(2, 2, 0, 0);

            bt.AccessibleName = vehicle[2] + vehicle[0];
            bt.Click += (s, e) =>
            {
                MessageBox.Show(bt.Name, bt.AccessibleName);

            };

            return bt;
        }

        private Image BuildImage()
        {
            Image[] ima = { Properties.Resources.car, Properties.Resources.moto };

            Image img = ima[random.Next(0, 2)];
            Bitmap newImage = new Bitmap(img.Width / 2, img.Height / 2);
            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(img, 0, 0, newImage.Width / 2, newImage.Height / 2);

            return newImage;
        }

        private List<object> CustomizeButton()
        {

            //TODO: Criar a lista de cores, figuras e metodos do botão
            return new List<object>();
        }
    }
}
