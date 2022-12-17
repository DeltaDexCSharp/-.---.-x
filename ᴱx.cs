using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ᴰ;

namespace ᴰ
{
    internal class ᴱx
    {
        public static int formWidth;
        public static int formHeight;

        #pragma warning disable CS8622 // Rethrow to preserve stack details
        public static void objMovesForm(Form form, int boxIndex) { form.Controls[boxIndex].MouseMove += new MouseEventHandler(formMove); }

        #pragma warning restore CS8622 // Rethrow to preserve stack details

        #pragma warning disable CS8622 // Rethrow to preserve stack details
        public static void mouseMovesForm(Form form) { form.MouseMove += new MouseEventHandler(formMove); }
        #pragma warning restore CS8622 // Rethrow to preserve stack details
        private static void formMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ᴰ.ᴱᴸᵀᴬ.moveApplication("Delta Example");
            }
        }
        public static void roundForm(Form form, int formWidth, int formHeight, int borderRadius) 
        {
            ᴰ.ᴱᴸᵀᴬ.roundFormEdges(formWidth, formHeight, borderRadius);
            form.Region = System.Drawing.Region.FromHrgn(ᴰ.ᴱᴸᵀᴬ.roundForm);
        }

        public static void getFormSize(Form form) { formWidth = form.Width; formHeight = form.Height; }

        public static void setBackColor(Form form, Color color) { form.BackColor = color; }
        public static void addBox(Form form, string boxName, int boxWidth, int boxHeight, Color boxBackgroundColor) { Panel panel = new Panel(); panel.Width = boxWidth; panel.Height = boxHeight; panel.Name = boxName; panel.BackColor = boxBackgroundColor; form.Controls.Add(panel);  }
        public static void moveBox(Form form, int X, int Y, int controlIndex) { form.Controls[controlIndex].Location = new Point(X,Y); }
        public static void roundBox(Form form, int controlIndex, int borderRadius) { ᴰ.ᴱᴸᵀᴬ.roundFormEdges(form.Controls[controlIndex].Width, form.Controls[controlIndex].Height, borderRadius); form.Controls[controlIndex].Region = System.Drawing.Region.FromHrgn(ᴰ.ᴱᴸᵀᴬ.roundForm); }
        public static void roundObj(Form form, int controlIndex, int internalIndex, int borderRadius) { ᴰ.ᴱᴸᵀᴬ.roundFormEdges(form.Controls[controlIndex].Controls[internalIndex].Width, form.Controls[controlIndex].Controls[internalIndex].Height, borderRadius); form.Controls[controlIndex].Controls[internalIndex].Region = System.Drawing.Region.FromHrgn(ᴰ.ᴱᴸᵀᴬ.roundForm); }

        public static void addLabel() { }
        public static void addObjtextTag(Form form, int controlIndex, string labelName, string text, Color labelColor, string font, int fontSize, ContentAlignment textAlignment, bool autosize, int width, int height) { Label label = new Label(); label.AutoSize = autosize; label.Width = width; label.Height = height; label.ForeColor = labelColor; label.Text = text; label.BackColor = Color.Transparent; label.Font = new Font(font, fontSize); label.TextAlign = textAlignment; form.Controls[controlIndex].Controls.Add(label); }
        public static void setObjLocation(Form form, int controlIndex, int internalIndex, int X, int Y) { form.Controls[controlIndex].Controls[internalIndex].Location = new Point(X,Y); }
        public static void setObjText(Form form, int controlIndex, int internalIndex, string text) { form.Controls[controlIndex].Controls[internalIndex].Text = text; }
        public static void addObjBox(Form form, int controlIndex, string boxName, int boxWidth, int boxHeight, Color boxBackgroundColor) { Panel panel = new Panel(); panel.Width = boxWidth; panel.Height = boxHeight; panel.Name = boxName; panel.BackColor = boxBackgroundColor; form.Controls[controlIndex].Controls.Add(panel); }
        #pragma warning disable CS8622 // Rethrow to preserve stack details
        public static void objClosesForm(Form form, int controlIndex, int internalIndex) {
            form.Controls[controlIndex].Controls[internalIndex].MouseClick += new MouseEventHandler(closeForm);
        }
        #pragma warning restore CS8622 // Rethrow to preserve stack details
        #pragma warning disable CS8622 // Rethrow to preserve stack details
        public static void objMinimizesForm(Form form, int controlIndex, int internalIndex)
        {
            form.Controls[controlIndex].Controls[internalIndex].MouseClick += new MouseEventHandler(minimizeForm);
        }
        #pragma warning restore CS8622 // Rethrow to preserve stack details
        private static void closeForm(object sender, MouseEventArgs e) { Application.Exit(); }

        private static void minimizeForm(object sender, MouseEventArgs e) { ᴰ.ᴱᴸᵀᴬ.minimizeForm(); }

        public static void initForm(Form form, int Width, int Height, string Name, string Title) 
        {
            form.SuspendLayout();
            // 
            // Form1
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(Width, Height);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Name = Name;
            form.Text = Title;
            //form.Load += new System.EventHandler(form.Form1_Load);
            form.ResumeLayout(false);

        }

        public static Form mainForm = new Form();

        public static void Start() 
        {
            Application.Run(ᴰ.ᴱx.mainForm);
        }

        public static void setObjTextAlign(Form form, int controlIndex, int internalIndex) { }//form.Controls[controlIndex].Controls[internalIndex]}

    }
}
