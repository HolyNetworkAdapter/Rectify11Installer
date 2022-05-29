﻿using libmsstyle;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Rectify11Installer.Controls
{
    public class NavigationButton : Control
    {
        private NavigationButtonType t = NavigationButtonType.Forward;
        private Bitmap? Glyph;
        public NavigationButtonType NavigationButtonType
        {
            get { return t; }
            set
            {
                t = value;
                if (Enabled)
                {
                    this.SetState(ThemeParts.Normal);
                    this.Invalidate();
                }
                else
                {
                    this.SetState(ThemeParts.Disabled);
                    this.Invalidate();
                }

            }
        }

        public new bool Enabled
        {
            get { return base.Enabled; }
            set
            {
                base.Enabled = value;
                if (value)
                {
                    this.SetState(ThemeParts.Normal);
                }
                else
                {
                    this.SetState(ThemeParts.Disabled);
                }
                this.Invalidate();
            }
        }
        public NavigationButton()
        {
            this.Location = new Point(50, 50);
            this.Size = new Size(30, 30);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.BackColor = Color.Transparent;
            //this.MaximumSize = new Size(30, 30);
            SetState(ThemeParts.Normal);
            this.MouseEnter += NavigationButton_MouseEnter;
            this.MouseLeave += NavigationButton_MouseLeave;

            this.MouseDown += NavigationButton_MouseDown;
            this.MouseUp += NavigationButton_MouseUp;

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void NavigationButton_MouseUp(object? sender, MouseEventArgs e)
        {
            if (Enabled)
            {
                SetState(ThemeParts.Normal);
            }
        }

        private void NavigationButton_MouseDown(object? sender, MouseEventArgs e)
        {
            if (Enabled)
            {
                SetState(ThemeParts.Pressed);
            }
        }

        private void NavigationButton_MouseLeave(object? sender, EventArgs e)
        {
            if (Enabled)
            {
                SetState(ThemeParts.Normal);
            }
        }

        private void NavigationButton_MouseEnter(object? sender, EventArgs e)
        {
            if (Enabled)
            {
                SetState(ThemeParts.Hot);
            }

        }
        private void SetState(ThemeParts c)
        {
            if (DesignMode)
            {
                Glyph = new Bitmap(Width, Height);
            }
            else
            {
                VisualStyle currentTheme = Theme.IsUsingDarkMode ? Theme.DarkStyle : Theme.LightStyle;
                var part = Theme.GetNavArrowPart(currentTheme, t);
                var renderer2 = new PartRenderer(currentTheme, part);
                Glyph = renderer2.RenderPreview(c, Width, Height);
            }
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Glyph != null)
                e.Graphics.DrawImage(Glyph, new Point(0, 0));
        }
    }
    public enum NavigationButtonType { Forward, Backward, Menu }
}