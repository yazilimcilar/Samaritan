//
//
// (c) 2015 Samaritan Pawn IDE - Source Code
//
//

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samaritan.UI.Controls
{
    class SamaritanTreeView : TreeView
    {
        public SamaritanTreeView()
        {
            this.DrawMode = TreeViewDrawMode.OwnerDrawText;
        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            TreeNodeStates state = e.State;
            Font font = e.Node.NodeFont ?? e.Node.TreeView.Font;
            Color foreColor = e.Node.ForeColor;

            if (foreColor == Color.Empty)
            {
                foreColor = e.Node.TreeView.ForeColor;
            }

            if (e.Node == e.Node.TreeView.SelectedNode)
            {
                foreColor = Color.Black;
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds, foreColor, Color.White);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, foreColor, Color.White, TextFormatFlags.GlyphOverhangPadding);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 242)), e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, foreColor, TextFormatFlags.GlyphOverhangPadding);
            }
        }
    }
}
