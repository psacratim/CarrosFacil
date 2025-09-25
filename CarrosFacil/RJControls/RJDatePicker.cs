﻿using System;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CarrosFacil
{
    public class RJDatePicker : DateTimePicker
    {
        //Fields
        //-> Appearance
        private Color skinColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;
        private int borderRadius = 0;

        //-> Other Values
        private bool droppedDown = false;
        private Image calendarIcon = Properties.Resources.calendarWhite;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;


        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        //Properties
        public Color SkinColor
        {
            get { return skinColor; }
            set
            {
                skinColor = value;
                if (skinColor.GetBrightness() >= 0.6F)
                    calendarIcon = Properties.Resources.calendarDark;
                else calendarIcon = Properties.Resources.calendarWhite;
                this.Invalidate();
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        //Constructor
        public RJDatePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5F);
        }

        // Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        //Overridden methods
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }
        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            droppedDown = false;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 2;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (SolidBrush skinBrush = new SolidBrush(skinColor))
                using (SolidBrush textBrush = new SolidBrush(textColor))
                using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
                using (StringFormat textFormat = new StringFormat())
                {
                    textFormat.LineAlignment = StringAlignment.Center;

                    // define região arredondada
                    this.Region = new Region(pathSurface);

                    // fundo
                    e.Graphics.FillPath(skinBrush, pathSurface);

                    // texto
                    e.Graphics.DrawString("   " + this.Text, this.Font, textBrush, rectSurface, textFormat);

                    // highlight quando dropdown
                    RectangleF iconArea = new RectangleF(rectSurface.Width - calendarIconWidth, 0, calendarIconWidth, rectSurface.Height);
                    if (droppedDown == true)
                        e.Graphics.FillRectangle(openIconBrush, iconArea);

                    // borda
                    if (borderSize >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);

                    // ícone
                    e.Graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height) / 2);
                }
            }
            else
            {
                // fallback normal (sem radius)
                using (SolidBrush skinBrush = new SolidBrush(skinColor))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    e.Graphics.FillRectangle(skinBrush, rectSurface);
                    if (borderSize >= 1)
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    using (Graphics graphics = this.CreateGraphics())
        //    using (Pen penBorder = new Pen(borderColor, borderSize))
        //    using (SolidBrush skinBrush = new SolidBrush(skinColor))
        //    using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
        //    using (SolidBrush textBrush = new SolidBrush(textColor))
        //    using (StringFormat textFormat = new StringFormat())
        //    {
        //        RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
        //        RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
        //        penBorder.Alignment = PenAlignment.Inset;
        //        textFormat.LineAlignment = StringAlignment.Center;

        //        //Draw surface
        //        graphics.FillRectangle(skinBrush, clientArea);
        //        //Draw text
        //        graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
        //        //Draw open calendar icon highlight
        //        if (droppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
        //        //Draw border 
        //        if (borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
        //        //Draw icon
        //        graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height) / 2);

        //    }
        //}

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iconButtonArea.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else this.Cursor = Cursors.Default;
        }

        //Private methods
        private int GetIconButtonWidth()
        {
            int textWidh = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidh <= this.Width - (calendarIconWidth + 20))
                return calendarIconWidth;
            else return arrowIconWidth;
        }
    }
}
