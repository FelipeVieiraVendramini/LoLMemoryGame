// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// MemoryGame - FrmMemoryGame - FrmMain.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region References

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FrmMemoryGame.Properties;

#endregion

namespace FrmMemoryGame
{
    public partial class FrmMain : Form
    {
        private readonly List<ChampionCfg> m_allChamps = new List<ChampionCfg>
        {
            new ChampionCfg {ChampionName = "Aatrox", Index = -1},
            new ChampionCfg {ChampionName = "Ahri", Index = -1},
            new ChampionCfg {ChampionName = "Akali", Index = -1},
            new ChampionCfg {ChampionName = "Alistar", Index = -1},
            new ChampionCfg {ChampionName = "Amumu", Index = -1},
            new ChampionCfg {ChampionName = "Anivia", Index = -1},
            new ChampionCfg {ChampionName = "Annie", Index = -1},
            new ChampionCfg {ChampionName = "Aphelios", Index = -1},
            new ChampionCfg {ChampionName = "Ashe", Index = -1},
            new ChampionCfg {ChampionName = "Aurelion Sol", Index = -1},
            new ChampionCfg {ChampionName = "Azir", Index = -1},
            new ChampionCfg {ChampionName = "Bardo", Index = -1},
            new ChampionCfg {ChampionName = "Blitzcrank", Index = -1},
            new ChampionCfg {ChampionName = "Brand", Index = -1},
            new ChampionCfg {ChampionName = "Braum", Index = -1},
            new ChampionCfg {ChampionName = "Caitlyn", Index = -1},
            new ChampionCfg {ChampionName = "Camille", Index = -1},
            new ChampionCfg {ChampionName = "Cassiopeia", Index = -1},
            new ChampionCfg {ChampionName = "Cho'Gath", Index = -1},
            new ChampionCfg {ChampionName = "Corki", Index = -1},
            new ChampionCfg {ChampionName = "Darius", Index = -1},
            new ChampionCfg {ChampionName = "Diana", Index = -1},
            new ChampionCfg {ChampionName = "Dr. Mundo", Index = -1},
            new ChampionCfg {ChampionName = "Draven", Index = -1},
            new ChampionCfg {ChampionName = "Ekko", Index = -1},
            new ChampionCfg {ChampionName = "Elise", Index = -1},
            new ChampionCfg {ChampionName = "Evelynn", Index = -1},
            new ChampionCfg {ChampionName = "Ezreal", Index = -1},
            new ChampionCfg {ChampionName = "Fiddlesticks", Index = -1},
            new ChampionCfg {ChampionName = "Fiora", Index = -1},
            new ChampionCfg {ChampionName = "Fizz", Index = -1},
            new ChampionCfg {ChampionName = "Galio", Index = -1},
            new ChampionCfg {ChampionName = "Gankplank", Index = -1},
            new ChampionCfg {ChampionName = "Garen", Index = -1},
            new ChampionCfg {ChampionName = "Gnar", Index = -1},
            new ChampionCfg {ChampionName = "Gragas", Index = -1},
            new ChampionCfg {ChampionName = "Graves", Index = -1},
            new ChampionCfg {ChampionName = "Hecarim", Index = -1},
            new ChampionCfg {ChampionName = "Heimerdinger", Index = -1},
            new ChampionCfg {ChampionName = "Illaoi", Index = -1},
            new ChampionCfg {ChampionName = "Irelia", Index = -1},
            new ChampionCfg {ChampionName = "Ivern", Index = -1},
            new ChampionCfg {ChampionName = "Janna", Index = -1},
            new ChampionCfg {ChampionName = "Jarvan IV", Index = -1},
            new ChampionCfg {ChampionName = "Jax", Index = -1},
            new ChampionCfg {ChampionName = "Jayce", Index = -1},
            new ChampionCfg {ChampionName = "Jhin", Index = -1},
            new ChampionCfg {ChampionName = "Jinx", Index = -1},
            new ChampionCfg {ChampionName = "Kai'sa", Index = -1},
            new ChampionCfg {ChampionName = "Kalista", Index = -1},
            new ChampionCfg {ChampionName = "Karma", Index = -1},
            new ChampionCfg {ChampionName = "Karthus", Index = -1},
            new ChampionCfg {ChampionName = "Kassadin", Index = -1},
            new ChampionCfg {ChampionName = "Katarina", Index = -1},
            new ChampionCfg {ChampionName = "Kayle", Index = -1},
            new ChampionCfg {ChampionName = "Kayn", Index = -1},
            new ChampionCfg {ChampionName = "Kennen", Index = -1},
            new ChampionCfg {ChampionName = "Kha'zix", Index = -1},
            new ChampionCfg {ChampionName = "Kindred", Index = -1},
            new ChampionCfg {ChampionName = "Kled", Index = -1},
            new ChampionCfg {ChampionName = "Kog'Maw", Index = -1},
            new ChampionCfg {ChampionName = "Leblanc", Index = -1},
            new ChampionCfg {ChampionName = "Lee Sin", Index = -1},
            new ChampionCfg {ChampionName = "Leona", Index = -1},
            new ChampionCfg {ChampionName = "Lissandra", Index = -1},
            new ChampionCfg {ChampionName = "Lucian", Index = -1},
            new ChampionCfg {ChampionName = "Lulu", Index = -1},
            new ChampionCfg {ChampionName = "Lux", Index = -1},
            new ChampionCfg {ChampionName = "Malphite", Index = -1},
            new ChampionCfg {ChampionName = "Malzahar", Index = -1},
            new ChampionCfg {ChampionName = "Maokai", Index = -1},
            new ChampionCfg {ChampionName = "Master Yi", Index = -1},
            new ChampionCfg {ChampionName = "Miss Fortune", Index = -1},
            new ChampionCfg {ChampionName = "Mordekaiser", Index = -1},
            new ChampionCfg {ChampionName = "Morgana", Index = -1},
            new ChampionCfg {ChampionName = "Nami", Index = -1},
            new ChampionCfg {ChampionName = "Nasus", Index = -1},
            new ChampionCfg {ChampionName = "Nautilus", Index = -1},
            new ChampionCfg {ChampionName = "Neeko", Index = -1},
            new ChampionCfg {ChampionName = "Nidalee", Index = -1},
            new ChampionCfg {ChampionName = "Nocturne", Index = -1},
            new ChampionCfg {ChampionName = "Nunu e Willump", Index = -1},
            new ChampionCfg {ChampionName = "Olaf", Index = -1},
            new ChampionCfg {ChampionName = "Orianna", Index = -1},
            new ChampionCfg {ChampionName = "Ornn", Index = -1},
            new ChampionCfg {ChampionName = "Pantheon", Index = -1},
            new ChampionCfg {ChampionName = "Poppy", Index = -1},
            new ChampionCfg {ChampionName = "Pyke", Index = -1},
            new ChampionCfg {ChampionName = "Qiyana", Index = -1},
            new ChampionCfg {ChampionName = "Quinn", Index = -1},
            new ChampionCfg {ChampionName = "Rakan", Index = -1},
            new ChampionCfg {ChampionName = "Rammus", Index = -1},
            new ChampionCfg {ChampionName = "Rek'sai", Index = -1},
            new ChampionCfg {ChampionName = "Renekton", Index = -1},
            new ChampionCfg {ChampionName = "Rengar", Index = -1},
            new ChampionCfg {ChampionName = "Riven", Index = -1},
            new ChampionCfg {ChampionName = "Rumble", Index = -1},
            new ChampionCfg {ChampionName = "Ryze", Index = -1},
            new ChampionCfg {ChampionName = "Sejuani", Index = -1},
            new ChampionCfg {ChampionName = "Senna", Index = -1},
            new ChampionCfg {ChampionName = "Sett", Index = -1},
            new ChampionCfg {ChampionName = "Shaco", Index = -1},
            new ChampionCfg {ChampionName = "Shen", Index = -1},
            new ChampionCfg {ChampionName = "Shyvana", Index = -1},
            new ChampionCfg {ChampionName = "Singed", Index = -1},
            new ChampionCfg {ChampionName = "Sion", Index = -1},
            new ChampionCfg {ChampionName = "Sivir", Index = -1},
            new ChampionCfg {ChampionName = "Skarner", Index = -1},
            new ChampionCfg {ChampionName = "Sona", Index = -1},
            new ChampionCfg {ChampionName = "Soraka", Index = -1},
            new ChampionCfg {ChampionName = "Swain", Index = -1},
            new ChampionCfg {ChampionName = "Sylas", Index = -1},
            new ChampionCfg {ChampionName = "Syndra", Index = -1},
            new ChampionCfg {ChampionName = "Tahm Kench", Index = -1},
            new ChampionCfg {ChampionName = "Taliyah", Index = -1},
            new ChampionCfg {ChampionName = "Talon", Index = -1},
            new ChampionCfg {ChampionName = "Taric", Index = -1},
            new ChampionCfg {ChampionName = "Teemo", Index = -1},
            new ChampionCfg {ChampionName = "Thresh", Index = -1},
            new ChampionCfg {ChampionName = "Tristana", Index = -1},
            new ChampionCfg {ChampionName = "Trundle", Index = -1},
            new ChampionCfg {ChampionName = "Tryndamere", Index = -1},
            new ChampionCfg {ChampionName = "Twisted Fate", Index = -1},
            new ChampionCfg {ChampionName = "Twitch", Index = -1},
            new ChampionCfg {ChampionName = "Udyr", Index = -1},
            new ChampionCfg {ChampionName = "Urgot", Index = -1},
            new ChampionCfg {ChampionName = "Varus", Index = -1},
            new ChampionCfg {ChampionName = "Vayne", Index = -1},
            new ChampionCfg {ChampionName = "Veigar", Index = -1},
            new ChampionCfg {ChampionName = "Vel'koz", Index = -1},
            new ChampionCfg {ChampionName = "Vi", Index = -1},
            new ChampionCfg {ChampionName = "Viktor", Index = -1},
            new ChampionCfg {ChampionName = "Vladimir", Index = -1},
            new ChampionCfg {ChampionName = "Volibear", Index = -1},
            new ChampionCfg {ChampionName = "Warwick", Index = -1},
            new ChampionCfg {ChampionName = "Wukong", Index = -1},
            new ChampionCfg {ChampionName = "Xayah", Index = -1},
            new ChampionCfg {ChampionName = "Xerath", Index = -1},
            new ChampionCfg {ChampionName = "Xin Zhao", Index = -1},
            new ChampionCfg {ChampionName = "Yasuo", Index = -1},
            new ChampionCfg {ChampionName = "Yorick", Index = -1},
            new ChampionCfg {ChampionName = "Yuumi", Index = -1},
            new ChampionCfg {ChampionName = "Zac", Index = -1},
            new ChampionCfg {ChampionName = "Zed", Index = -1},
            new ChampionCfg {ChampionName = "Ziggs", Index = -1},
            new ChampionCfg {ChampionName = "Zilean", Index = -1},
            new ChampionCfg {ChampionName = "Zoe", Index = -1},
            new ChampionCfg {ChampionName = "Zyra", Index = -1}
        };

        private readonly List<SelectButton> m_buttons = new List<SelectButton>();
        private bool m_discovered;
        private Timer m_timer = new Timer();

        public FrmMain()
        {
            InitializeComponent();
        }

        public int SelectedButtons { get; private set; }

        private void GenerateButtons()
        {
            SuspendLayout();
            for (int x = 0; x < tlpMain.ColumnCount; x++)
            {
                for (int y = 0; y < tlpMain.RowCount; y++)
                {
                    int idx = Calc.Pos2Index(x, y, tlpMain.ColumnCount, tlpMain.RowCount);
                    SelectButton btn = new SelectButton
                    {
                        Name = $"BtnCard{idx}",
                        FlatAppearance =
                        {
                            BorderColor = Color.AliceBlue,
                            BorderSize = 2
                        },
                        Dock = DockStyle.Fill,
                        Size = new Size(110, 71),
                        TabIndex = 0,
                        TabStop = false,
                        Visible = false,
                        Index = idx,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0),
                        ForeColor = Color.Brown,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        FlatStyle = FlatStyle.Popup
                    };

                    tlpMain.Controls.Add(btn, x, y);
                    m_buttons.Add(btn);
                }
            }

            ResumeLayout(false);
        }

        private void PrepareQueue()
        {
            Random rand = new Random();
            List<ChampionCfg> config = new List<ChampionCfg>(64);
            for (int i = 0; i < 32; i++)
            {
                ChampionCfg champ = m_allChamps[rand.Next() % m_allChamps.Count];
                if (config.Any(x => x.Index == champ.Index) || champ.ImageFile == null)
                {
                    i--;
                    continue;
                }

                config.Add(champ);
                config.Add(champ);
            }

            SuspendLayout();

            foreach (SelectButton btn in m_buttons)
            {
                int idx = rand.Next() % config.Count;
                btn.ChampionName = config[idx].ChampionName;
                btn.ChampionIndex = config[idx].Index;
                btn.ChampionPicture = config[idx].ImageFile;

                btn.Reset();

                config.RemoveAt(idx);
                btn.Visible = true;
            }

            ResumeLayout(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, @"Tem certeza de que deseja fechar?", @"Fechando", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void CheckButtons()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(CheckButtons));
                return;
            }

            List<SelectButton> selected = new List<SelectButton>();
            string championName = "";
            int selectedChamp = -1;
            SelectedButtons = 0;
            foreach (var control in tlpMain.Controls)
            {
                if (!(control is SelectButton button) || button.IsDiscovered)
                    continue;

                if (button.IsSelected && !button.IsDiscovered)
                {
                    if (selectedChamp == -1)
                    {
                        selectedChamp = button.ChampionIndex;
                    }
                    else if (button.ChampionIndex == selectedChamp)
                    {
                        m_discovered = true;
                        championName = button.ChampionName;
                    }

                    selected.Add(button);
                    SelectedButtons++;
                }

                if (SelectedButtons >= 2)
                    break;
            }

            if (SelectedButtons >= 2 && !m_discovered)
            {
                m_timer = new Timer();
                m_timer.Tick += TimerOnTick;
                m_timer.Interval = 2000;
                m_timer.Disposed += TimerOnDisposed;
                m_timer.Start();
            }
            else if (SelectedButtons >= 2)
            {
                m_discovered = false;
                SelectedButtons = 0;

                foreach (var button in selected)
                    button.IsDiscovered = true;

                MessageBox.Show(this, $@"Você encontrou {championName}!!!", @"Parabéns!");
            }
        }

        private void TimerOnDisposed(object sender, EventArgs e)
        {
        }

        private void TimerOnTick(object sender, EventArgs e)
        {
            foreach (var control in tlpMain.Controls)
            {
                if (!(control is SelectButton button))
                    continue;

                if (!button.IsDiscovered)
                    button.Reset();
            }

            SelectedButtons = 0;
            m_discovered = false;

            m_timer.Enabled = false;
            m_timer.Dispose();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;

            SelectButton.CardImage = Resources.banner;
            for (int i = 0; i < m_allChamps.Count; i++)
            {
                string pureName = m_allChamps[i].ChampionName.RemoveSpecialCharacters();
                Image image = (Bitmap) Resources.ResourceManager.GetObject(pureName.ToLower());
                if (image == null && File.Exists($"{Environment.CurrentDirectory}\\images\\champions\\{pureName}.jpg"))
                {
                    image = Image.FromFile($"{Environment.CurrentDirectory}\\images\\champions\\{pureName}.jpg");
                }
                m_allChamps[i] = new ChampionCfg
                {
                    ChampionName = m_allChamps[i].ChampionName,
                    ImageFile = image,
                    Index = i
                };
            }

            GenerateButtons();
            PrepareQueue();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PrepareQueue();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog(this);
        }
    }

    public enum ButtonAction
    {
    }

    public struct ChampionCfg
    {
        public string ChampionName;
        public Image ImageFile;
        public int Index;
    }
}