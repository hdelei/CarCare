using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare.Controller
{
    class DynamicButton
    {
        List<Button> buttonList = new List<Button>();
        Control[] controls;
        Label formLabel;
        Form VForm;

        public List<Button> ButtonList { get => buttonList; }
        public Control[] Controls { get => controls; }

        public DynamicButton(Label formLabel, Form VForm)
        {
            this.formLabel = formLabel;            
            this.VForm = VForm;
        }

        /// <summary>
        /// Create a button list
        /// </summary>
        /// <param name="dt">Vehicle DataTable</param>
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

        /// <summary>
        /// Generate one new button
        /// </summary>
        /// <param name="btData">String List containing the new Vehicle data</param>
        public void CreateOneButton(List<string> vehicleData)
        {
            DataTable dt = new DataTable();            
            dt.Columns.Add("id");
            dt.Columns.Add("type");
            dt.Columns.Add("model");
            dt.Columns.Add("manufacturer");
            dt.Columns.Add("plate");
            dt.Columns.Add("year");

            dt.Rows.Add(vehicleData.ToArray());                       

            CreateButtons(dt);
        }

        /// <summary>
        /// Build a button with all required parameters
        /// </summary>
        /// <param name="vehicle">String List with Vehicle data</param>
        /// <returns>a single formatted button</returns>
        private Button BuildButton(List<string> vehicle)
        {
            Icon.SetIcon(vehicle[1]);
            Dictionary<string, object> dict = Icon.GetIcon();
            Image img = BuildImage((Image)dict["icon"]);

            Color textColor = Color.White;
            Color backColor = (Color)dict["backColor"];
            
            string btText = vehicle[2] + "\r\n" + vehicle[4];

            Button bt = new Button
            {
                Name = vehicle[0],
                FlatStyle = FlatStyle.Flat,
                Image = img,
                Text = btText,
                ForeColor = textColor,
                TextAlign = ContentAlignment.MiddleCenter,
                TextImageRelation = TextImageRelation.ImageAboveText,
                Width = img.Width + 20,
                Height = img.Height,
                BackColor = backColor
            };

            bt.FlatAppearance.BorderSize = 0;

            bt.Margin = new Padding(2, 2, 0, 0);

            bt.AccessibleName = vehicle[2] + vehicle[0];

            bt.Click += (s, e) => {
                UpdateButton(bt, vehicle[0]);

                //Just close the form when button is clicked
                if (Context.VehicleFormContext == "open")
                {
                    VForm.Close();
                }
            };            

            return bt;
        }

        /// <summary>
        /// Format the image for button
        /// </summary>
        /// <param name="img">Image type PNG</param>
        /// <returns>returns a new resized image</returns>
        private Image BuildImage(Image img)
        {   
            Bitmap newImage = new Bitmap(img.Width / 2, img.Height / 2);
            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(img, 0, 0, newImage.Width / 2, newImage.Height / 2);

            return newImage;
        }   
        
        private void UpdateButton(Button bt, string id)
        {
            //formLabel.Text = bt.AccessibleName;
            LastDynamicButton.Button = bt;
            LastDynamicButton.DbId = id;
        }
    }
}
