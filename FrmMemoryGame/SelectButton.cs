// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// MemoryGame - FrmMemoryGame - SelectButton.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region References

using System;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace FrmMemoryGame
{
    public sealed class SelectButton : Button
    {
        public static Image CardImage;
        
        private bool m_bIsSelected;
        private int m_idxObj = -1;

        public SelectButton()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
        }

        public int Index
        {
            get => m_idxObj;
            set
            {
                m_idxObj = value;
                if (!m_bIsSelected)
                    Text = $@"Card {value}";
            }
        }

        public int ChampionIndex = -1;

        public string ChampionName = "Unknown";

        public Image ChampionPicture;

        public bool IsSelected => m_bIsSelected;

        public bool IsDiscovered;

        protected override void OnClick(EventArgs e)
        {
            if (IsDiscovered || Program.MainFrm.SelectedButtons >= 2)
                return;

            base.OnClick(e);
            m_bIsSelected = !m_bIsSelected;

            if (ChampionPicture != null)
            {
                if (m_bIsSelected)
                {
                    BackgroundImage = ChampionPicture;
                    Text = string.Empty;
                }
                else
                {
                    BackgroundImage = CardImage;
                    Text = string.Empty;
                }
            }
            else
            {
                if (m_bIsSelected)
                {
                    Text = ChampionName;
                    BackgroundImage = null;
                }
                else
                {
                    Text = $@"Card {Index}";
                    BackgroundImage = null;
                }
            }

            Program.MainFrm.CheckButtons();
        }

        public void Reset()
        {
            m_bIsSelected = false;

            if (ChampionPicture != null)
            {
                if (m_bIsSelected)
                {
                    BackgroundImage = ChampionPicture;
                    Text = string.Empty;
                }
                else
                {
                    BackgroundImage = CardImage;
                    Text = $@"{Index:00}";
                }
            }
            else
            {
                if (m_bIsSelected)
                {
                    Text = ChampionName;
                    BackgroundImage = null;
                }
                else
                {
                    Text = $@"Card {Index}";
                    BackgroundImage = null;
                }
            }
        }
    }
}