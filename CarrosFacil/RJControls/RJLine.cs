using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CarrosFacil.RJControls
{
    public enum SeparatorOrientation
    {
        Horizontal,
        Vertical
    }


    public partial class RJLine : UserControl
    {
        public RJLine()
        {
            InitializeComponent();

            // Control style for smooth drawing
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            // Defaults size: wide and thin like <hr>
            this.Width = 150;
            this.Height = 4;
            this.BackColor = Color.Transparent;
        }

        private void RJLine_Load(object sender, EventArgs e)
        {

        }

        // Fields (defaults)
        private Color lineColor = Color.Gray;
        private int lineThickness = 4;
        private int borderRadius = 4;
        private SeparatorOrientation orientation = SeparatorOrientation.Horizontal;

        // Properties
        [Category("RJ Code Advance")]
        public Color LineColor
        {
            get => lineColor;
            set { lineColor = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        [Description("Espessura da linha em pixels.")]
        public int LineThickness
        {
            get => lineThickness;
            set
            {
                lineThickness = Math.Max(1, value);
                UpdatePreferredSize();
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        [Description("Raio dos cantos. Para obter semicirculo nas pontas use valor >= LineThickness/2.")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = Math.Max(0, value);
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        [Description("Orientação da linha: Horizontal ou Vertical.")]
        public SeparatorOrientation Orientation
        {
            get => orientation;
            set
            {
                orientation = value;
                UpdatePreferredSize();
                Invalidate();
            }
        }

        [Browsable(false)]
        public override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }


        private void UpdatePreferredSize()
        {
            if (orientation == SeparatorOrientation.Horizontal)
            {
                // Keep height suitable for thickness unless user explicitly changed it
                if (this.Height != lineThickness)
                    this.Height = lineThickness;
            }
            else
            {
                if (this.Width != lineThickness)
                    this.Width = lineThickness;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Ensure radius not larger than half of thickness/size
            if (orientation == SeparatorOrientation.Horizontal)
            {
                if (borderRadius > this.Height / 2)
                    borderRadius = this.Height / 2;
            }
            else
            {
                if (borderRadius > this.Width / 2)
                    borderRadius = this.Width / 2;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (orientation == SeparatorOrientation.Horizontal)
            {
                // area da linha centralizada verticalmente
                int padLeft = Padding.Left;
                int padRight = Padding.Right;
                Rectangle rect = new Rectangle(
                    padLeft,
                    (this.Height - lineThickness) / 2,
                    Math.Max(1, this.Width - padLeft - padRight),
                    lineThickness);

                using (GraphicsPath path = GetRoundedRectanglePath(rect, borderRadius))
                using (SolidBrush brush = new SolidBrush(lineColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
            else // vertical
            {
                int padTop = Padding.Top;
                int padBottom = Padding.Bottom;
                Rectangle rect = new Rectangle(
                    (this.Width - lineThickness) / 2,
                    padTop,
                    lineThickness,
                    Math.Max(1, this.Height - padTop - padBottom));

                using (GraphicsPath path = GetRoundedRectanglePath(rect, borderRadius))
                using (SolidBrush brush = new SolidBrush(lineColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        /// <summary>
        /// Cria um GraphicsPath de retângulo com cantos arredondados.
        /// Se radius for 0 retorna um retângulo simples (adiciona um retângulo ao path).
        /// </summary>
        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (radius <= 0)
            {
                path.AddRectangle(rect);
                path.CloseFigure();
                return path;
            }

            float curve = radius * 2f;
            // Se o raio exceder dimensões, limitar
            if (curve > rect.Width) curve = rect.Width;
            if (curve > rect.Height) curve = rect.Height;

            // Arcos nas 4 pontas
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curve, curve, 180, 90); // top-left
            path.AddArc(rect.Right - curve, rect.Y, curve, curve, 270, 90); // top-right
            path.AddArc(rect.Right - curve, rect.Bottom - curve, curve, curve, 0, 90); // bottom-right
            path.AddArc(rect.X, rect.Bottom - curve, curve, curve, 90, 90); // bottom-left
            path.CloseFigure();

            return path;
        }

        // Optional: support for design-time resizing convenience
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            UpdatePreferredSize();
        }
    }
}
