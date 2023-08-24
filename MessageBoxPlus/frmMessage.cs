using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxPlus
{
    public partial class frmMessage : Form
    {
        private Size m_Size = new Size();
        private bool m_bResize = false;
        private bool m_bReLocation = false;
        private bool m_bSetIcon = false;
        private bool m_bSetTitle = false;
        
        public frmMessage()
        {
            InitializeComponent();
        }

        public frmMessage(Form parent, string strTitle, string strContent, string strRemark = "")
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.SetContentTitle(strTitle);
            this.SetContent(strContent);
            this.SetRemark(strRemark);
            this.SetWindowLocation(this.GetProperStartPoint(parent));
        }

        public frmMessage(Form parent, string strTitle, string strContent, string strIconPath, string strRemark = "")
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.SetContentTitle(strTitle);
            this.SetContent(strContent);
            this.SetRemark(strRemark);
            this.SetIcon(Bitmap.FromFile(strIconPath));
            this.SetWindowLocation(this.GetProperStartPoint(parent));
        }

        public enum TYPE { INFO, WARNING, ERROR, QUESTION};
        public frmMessage(Form parent, string strTitle, string strContent, TYPE type, string strRemark = "")
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.SetContentTitle(strTitle);
            this.SetContent(strContent);
            this.SetRemark(strRemark);
            this.SetWindowLocation(this.GetProperStartPoint(parent));
            if (type == TYPE.INFO)
            {

            }
            else if (type == TYPE.WARNING)
            {
                this.SetIcon(Bitmap.FromFile("..\\..\\Res\\alarm.png"));
            }
            else if (type == TYPE.ERROR)
            {
                this.SetIcon(Bitmap.FromFile("..\\..\\Res\\caution.png"));
            }
            else if (type == TYPE.QUESTION)
            {

            }
        }

        public static void ShowSimpleMessage(Form parent, string strTitle, string strContent, string strRemark = "")
        {
            frmMessage frm = new frmMessage();
            frm.StartPosition = FormStartPosition.Manual;
            frm.SetWindowLocation(frm.GetProperStartPoint(parent));
            frm.SetContentTitle(strTitle);
            frm.SetContent(strContent);
            frm.SetRemark(strRemark);
            frm.ShowDialog();
        }

        private Point GetProperStartPoint(Form parent)
        {
            Point ret = new Point();
            if (parent == null || parent.Size == Size.Empty)
                throw new Exception("Parent form is not valid");
            if (parent.Size.Width <= this.Width)
                ret.X = parent.Location.X + parent.Width / 10;
            else if (parent.Size.Width < this.Width * 1.5)
                ret.X = parent.Location.X + parent.Width / 7;
            else if (parent.Size.Width >= this.Width * 1.5)
                ret.X = parent.Location.X + parent.Width / 3;
            if (parent.Size.Height < this.Height)
                ret.Y = parent.Location.Y + parent.Height / 10;
            else if (parent.Size.Height < this.Height * 1.5 )
                ret.Y = parent.Location.Y + parent.Height / 7;
            else if (parent.Size.Height >= this.Height * 1.5)
                ret.Y = parent.Location.Y + parent.Height / 3;
            return ret;
        }

        public static void ShowSimpleMessage(Form parent, string strTitle, string strContent, TYPE type, string strRemark = "")
        {
            frmMessage frm = new frmMessage();
            frm.StartPosition = FormStartPosition.Manual;
            parent.Location.Offset(29, 29);
            frm.SetWindowLocation(frm.GetProperStartPoint(parent));
            frm.SetContentTitle(strTitle);
            frm.SetContent(strContent);
            frm.SetRemark(strRemark);
            if (type == TYPE.INFO)
            {

            }
            else if (type == TYPE.WARNING)
            {
                frm.SetIcon(Bitmap.FromFile("..\\..\\Res\\alarm.png"));
            }
            else if (type == TYPE.ERROR)
            {
                frm.SetIcon(Bitmap.FromFile("..\\..\\Res\\caution.png"));
            }
            else if (type == TYPE.QUESTION)
            {

            }
            frm.ShowDialog();
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            LoadDefault();
        }

        private void LoadDefault()
        {
            this.picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            if (!m_bReLocation)
                this.Location = new Point(500, 300);
            if (!m_bSetTitle)
                this.txtTitle.Text = "Message";
            if (!m_bSetIcon)
                this.picIcon.Image = Bitmap.FromFile("..\\..\\Res\\text-message.png");

        }

        public void SetWindowLocation(Point location)
        {
            this.Location = location;
            m_bReLocation = true;
        }

        public enum WindowSize { Small, Medium, Large}
        public void SetWindowSize(WindowSize eSize)
        {
            Size size = new Size();
            if (eSize == WindowSize.Small)
                size = new Size(530, 320);
            else if (eSize == WindowSize.Medium)
                size = new Size(530, 350);
            else if (eSize == WindowSize.Large)
                size = new Size(530, 380);
            this.Size = size;
            m_bResize = true;
        }

        public void SetIcon(Image icon)
        {
            this.picIcon.Image = icon;
            m_bSetIcon = true;
        }

        public void SetContentTitle(string strTitle)
        {
            this.txtTitle.Text = strTitle;
            m_bSetTitle = true;
        }
        public void SetContent(string strContent)
        {
            this.txtContent.Text = strContent;
        }
        public void SetRemark(string strRemark)
        {
            this.txtRemark.Text = strRemark;
        }

        class buttonProp
        {
            public Color backColor;
            public Color fontColor;
            public buttonProp(Color parBackColor, Color parFontColor)
            {
                this.backColor = parBackColor;
                this.fontColor = parFontColor;
            }
        }
        public void AddButton(string strButtonText, EventHandler eventHandler)
        {
            if (this.panelButton.Controls.Contains(buttonOK))
                this.panelButton.Controls.Remove(buttonOK);

            buttonProp[] arrColor = new buttonProp[]
            {
                new buttonProp(Color.White, Color.Black),
                new buttonProp(Color.Gray, Color.White),
                new buttonProp(Color.Green, Color.White)
            };
            Random random = new Random();
            Button button = new Button();
            button.Name = "button_" + strButtonText.Replace(" ", "_").Replace("\\", "_").Replace("/", "_");
            button.Text = strButtonText;
            
            button.Height = 37;
            buttonProp buttonProp = arrColor[random.Next(0, 3)];
            button.BackColor = buttonProp.backColor;
            button.Font = this.txtContent.Font;
            button.ForeColor = buttonProp.fontColor;
            button.Parent = panelButton;
            button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button.Dock = DockStyle.Bottom;
            button.Click += eventHandler;
        }
        /*public void SetWindowSize(int width, int height)
        {
            width = width < 360 ? 360 : width;
            width = width > 460 ? 460 : width;
            height = height < 180 ? 180 : height;
            height = height > 280 ? 280 : height;
            Size size = new Size(width, height);
            this.Size = size;
            m_bResize = true;
        }*/

        private void picIcon_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
