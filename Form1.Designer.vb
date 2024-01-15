<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtRand = New System.Windows.Forms.Button()
        Me.PkmnList = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pctLarge = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPkmnName = New System.Windows.Forms.Label()
        Me.pctSprite = New System.Windows.Forms.PictureBox()
        Me.txtCat = New System.Windows.Forms.Label()
        Me.txtType1 = New System.Windows.Forms.Label()
        Me.txtType2 = New System.Windows.Forms.Label()
        Me.txtPkmnDesc = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtPkmnAb = New System.Windows.Forms.Label()
        Me.Abilities = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pctFeet = New System.Windows.Forms.PictureBox()
        Me.pbHP = New System.Windows.Forms.ProgressBar()
        Me.pbAT = New System.Windows.Forms.ProgressBar()
        Me.pbDE = New System.Windows.Forms.ProgressBar()
        Me.pbSE = New System.Windows.Forms.ProgressBar()
        Me.pbSD = New System.Windows.Forms.ProgressBar()
        Me.pbSA = New System.Windows.Forms.ProgressBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PokedexDataDataSet = New Final_Project_Ortiz__Lanon.PokedexDataDataSet()
        Me.Gen1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gen1TableAdapter = New Final_Project_Ortiz__Lanon.PokedexDataDataSetTableAdapters.Gen1TableAdapter()
        Me.TableAdapterManager = New Final_Project_Ortiz__Lanon.PokedexDataDataSetTableAdapters.TableAdapterManager()
        Me.Gen1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pctMed1 = New System.Windows.Forms.PictureBox()
        Me.pctMedB = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDex = New System.Windows.Forms.Label()
        Me.EVYield = New System.Windows.Forms.Label()
        Me.txtEV = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCR = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pctLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctFeet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokedexDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gen1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gen1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctMed1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctMedB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRand
        '
        Me.txtRand.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.txtRand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtRand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.txtRand.ForeColor = System.Drawing.Color.White
        Me.txtRand.Location = New System.Drawing.Point(85, 329)
        Me.txtRand.Name = "txtRand"
        Me.txtRand.Size = New System.Drawing.Size(58, 22)
        Me.txtRand.TabIndex = 1
        Me.txtRand.Text = "Random"
        Me.txtRand.UseVisualStyleBackColor = True
        '
        'PkmnList
        '
        Me.PkmnList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PkmnList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PkmnList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PkmnList.FormattingEnabled = True
        Me.PkmnList.Items.AddRange(New Object() {"#001 - Bulbasaur", "#002 - Ivysaur", "#003 - Venusaur", "#004 - Charmander", "#005 - Charmeleon", "#006 - Charizard", "#007 - Squirtle", "#008 - Wartortle", "#009 - Blastoise", "#010 - Caterpie", "#011 - Metapod", "#012 - Butterfree", "#013 - Weedle", "#014 - Kakuna", "#015 - Beedrill", "#016 - Pidgey", "#017 - Pidgeotto", "#018 - Pidgeot", "#019 - Rattata", "#020 - Raticate", "#021 - Spearow", "#022 - Fearow", "#023 - Ekans", "#024 - Arbok", "#025 - Pikachu", "#026 - Raichu", "#027 - Sandshrew", "#028 - Sandslash", "#029 - Nidoran ♀", "#030 - Nidorina", "#031 - Nidoqueen", "#032 - Nidoran ♂", "#033 - Nidorino", "#034 - Nidoking", "#035 - Clefairy", "#036 - Clefable", "#037 - Vulpix", "#038 - Ninetales", "#039 - Jigglypuff", "#040 - Wigglytuff", "#041 - Zubat", "#042 - Golbat", "#043 - Oddish", "#044 - Gloom", "#045 - Vileplume", "#046 - Paras", "#047 - Parasect", "#048 - Venonat", "#049 - Venomoth", "#050 - Diglett", "#051 - Dugtrio", "#052 - Meowth", "#053 - Persian", "#054 - Psyduck", "#055 - Golduck", "#056 - Mankey", "#057 - Primeape", "#058 - Growlithe", "#059 - Arcanine", "#060 - Poliwag", "#061 - Poliwhirl", "#062 - Poliwrath", "#063 - Abra", "#064 - Kadabra", "#065 - Alakazam", "#066 - Machop", "#067 - Machoke", "#068 - Machamp", "#069 - Bellsprout", "#070 - Weepinbell", "#071 - Victreebel", "#072 - Tentacool", "#073 - Tentacruel", "#074 - Geodude", "#075 - Graveler", "#076 - Golem", "#077 - Ponyta", "#078 - Rapidash", "#079 - Slowpoke", "#080 - Slowbro", "#081 - Magnemite", "#082 - Magneton", "#083 - Farfetch'd", "#084 - Doduo", "#085 - Dodrio", "#086 - Seel", "#087 - Dewgong", "#088 - Grimer", "#089 - Muk", "#090 - Shellder", "#091 - Cloyster", "#092 - Gastly", "#093 - Haunter", "#094 - Gengar", "#095 - Onix", "#096 - Drowzee", "#097 - Hypno", "#098 - Krabby", "#099 - Kingler", "#100 - Voltorb", "#101 - Electrode", "#102 - Exeggcute", "#103 - Exeggutor", "#104 - Cubone", "#105 - Marowak", "#106 - Hitmonlee", "#107 - Hitmonchan", "#108 - Lickitung", "#109 - Koffing", "#110 - Weezing", "#111 - Rhyhorn", "#112 - Rhydon", "#113 - Chansey", "#114 - Tangela", "#115 - Kangaskhan", "#116 - Horsea", "#117 - Seadra", "#118 - Goldeen", "#119 - Seaking", "#120 - Staryu", "#121 - Starmie", "#122 - Mr. Mime", "#123 - Scyther", "#124 - Jynx", "#125 - Electabuzz", "#126 - Magmar", "#127 - Pinsir", "#128 - Tauros", "#129 - Magikarp", "#130 - Gyarados", "#131 - Lapras", "#132 - Ditto", "#133 - Eevee", "#134 - Vaporeon", "#135 - Jolteon", "#136 - Flareon", "#137 - Porygon", "#138 - Omanyte", "#139 - Omastar", "#140 - Kabuto", "#141 - Kabutops", "#142 - Aerodactyl", "#143 - Snorlax", "#144 - Articuno", "#145 - Zapdos", "#146 - Moltres", "#147 - Dratini", "#148 - Dragonair", "#149 - Dragonite", "#150 - Mewtwo", "#151 - Mew"})
        Me.PkmnList.Location = New System.Drawing.Point(12, 37)
        Me.PkmnList.Name = "PkmnList"
        Me.PkmnList.Size = New System.Drawing.Size(130, 286)
        Me.PkmnList.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.UseWaitCursor = True
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'pctLarge
        '
        Me.pctLarge.BackColor = System.Drawing.Color.Transparent
        Me.pctLarge.Location = New System.Drawing.Point(193, 109)
        Me.pctLarge.Name = "pctLarge"
        Me.pctLarge.Size = New System.Drawing.Size(150, 150)
        Me.pctLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLarge.TabIndex = 6
        Me.pctLarge.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(432, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "POKEDEX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(432, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "GENERATION I"
        '
        'txtPkmnName
        '
        Me.txtPkmnName.BackColor = System.Drawing.Color.Transparent
        Me.txtPkmnName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPkmnName.ForeColor = System.Drawing.Color.White
        Me.txtPkmnName.Location = New System.Drawing.Point(198, 35)
        Me.txtPkmnName.Name = "txtPkmnName"
        Me.txtPkmnName.Size = New System.Drawing.Size(166, 31)
        Me.txtPkmnName.TabIndex = 13
        Me.txtPkmnName.Text = "Bulbasaur"
        Me.txtPkmnName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pctSprite
        '
        Me.pctSprite.BackColor = System.Drawing.Color.Transparent
        Me.pctSprite.Location = New System.Drawing.Point(158, 42)
        Me.pctSprite.Name = "pctSprite"
        Me.pctSprite.Size = New System.Drawing.Size(40, 30)
        Me.pctSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctSprite.TabIndex = 14
        Me.pctSprite.TabStop = False
        '
        'txtCat
        '
        Me.txtCat.BackColor = System.Drawing.Color.Transparent
        Me.txtCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtCat.ForeColor = System.Drawing.Color.White
        Me.txtCat.Location = New System.Drawing.Point(201, 62)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(138, 18)
        Me.txtCat.TabIndex = 0
        Me.txtCat.Text = "Seed Pokémon"
        Me.txtCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtType1
        '
        Me.txtType1.BackColor = System.Drawing.Color.Khaki
        Me.txtType1.Location = New System.Drawing.Point(390, 84)
        Me.txtType1.Name = "txtType1"
        Me.txtType1.Size = New System.Drawing.Size(80, 23)
        Me.txtType1.TabIndex = 15
        Me.txtType1.Text = "TYPE I"
        Me.txtType1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtType2
        '
        Me.txtType2.BackColor = System.Drawing.Color.Khaki
        Me.txtType2.Location = New System.Drawing.Point(486, 84)
        Me.txtType2.Name = "txtType2"
        Me.txtType2.Size = New System.Drawing.Size(80, 23)
        Me.txtType2.TabIndex = 16
        Me.txtType2.Text = "TYPE II"
        Me.txtType2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPkmnDesc
        '
        Me.txtPkmnDesc.BackColor = System.Drawing.Color.Teal
        Me.txtPkmnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtPkmnDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPkmnDesc.ForeColor = System.Drawing.Color.White
        Me.txtPkmnDesc.Location = New System.Drawing.Point(380, 114)
        Me.txtPkmnDesc.Margin = New System.Windows.Forms.Padding(3)
        Me.txtPkmnDesc.Name = "txtPkmnDesc"
        Me.txtPkmnDesc.Size = New System.Drawing.Size(193, 76)
        Me.txtPkmnDesc.TabIndex = 17
        Me.txtPkmnDesc.Text = "The quick brown jumps over the lazy dog. The quick brown jumps over the lazy dog." &
    "The quick brown jumps over the lazy dog."
        Me.txtPkmnDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Teal
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(-9, 100)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.Label8.Size = New System.Drawing.Size(169, 264)
        Me.Label8.TabIndex = 18
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(387, 35)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'txtPkmnAb
        '
        Me.txtPkmnAb.BackColor = System.Drawing.Color.Teal
        Me.txtPkmnAb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPkmnAb.ForeColor = System.Drawing.Color.White
        Me.txtPkmnAb.Location = New System.Drawing.Point(375, 210)
        Me.txtPkmnAb.Margin = New System.Windows.Forms.Padding(3)
        Me.txtPkmnAb.Name = "txtPkmnAb"
        Me.txtPkmnAb.Size = New System.Drawing.Size(88, 39)
        Me.txtPkmnAb.TabIndex = 20
        Me.txtPkmnAb.Text = "The quick brown jumps over the lazy dog. The quick brown jumps over the lazy dog." &
    "The quick brown jumps over the lazy dog."
        Me.txtPkmnAb.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Abilities
        '
        Me.Abilities.AutoSize = True
        Me.Abilities.BackColor = System.Drawing.Color.Teal
        Me.Abilities.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abilities.ForeColor = System.Drawing.Color.White
        Me.Abilities.Location = New System.Drawing.Point(412, 193)
        Me.Abilities.Name = "Abilities"
        Me.Abilities.Size = New System.Drawing.Size(51, 16)
        Me.Abilities.TabIndex = 21
        Me.Abilities.Text = "Abilities"
        Me.Abilities.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Teal
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(444, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Base Stats"
        '
        'pctFeet
        '
        Me.pctFeet.BackColor = System.Drawing.Color.Transparent
        Me.pctFeet.Location = New System.Drawing.Point(334, 67)
        Me.pctFeet.Name = "pctFeet"
        Me.pctFeet.Size = New System.Drawing.Size(30, 30)
        Me.pctFeet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctFeet.TabIndex = 25
        Me.pctFeet.TabStop = False
        '
        'pbHP
        '
        Me.pbHP.BackColor = System.Drawing.Color.Brown
        Me.pbHP.ForeColor = System.Drawing.Color.White
        Me.pbHP.Location = New System.Drawing.Point(406, 284)
        Me.pbHP.MarqueeAnimationSpeed = 0
        Me.pbHP.Maximum = 250
        Me.pbHP.Name = "pbHP"
        Me.pbHP.Size = New System.Drawing.Size(65, 15)
        Me.pbHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbHP.TabIndex = 26
        '
        'pbAT
        '
        Me.pbAT.BackColor = System.Drawing.Color.Brown
        Me.pbAT.ForeColor = System.Drawing.Color.White
        Me.pbAT.Location = New System.Drawing.Point(406, 309)
        Me.pbAT.MarqueeAnimationSpeed = 10
        Me.pbAT.Maximum = 134
        Me.pbAT.Name = "pbAT"
        Me.pbAT.Size = New System.Drawing.Size(65, 15)
        Me.pbAT.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbAT.TabIndex = 27
        '
        'pbDE
        '
        Me.pbDE.BackColor = System.Drawing.Color.Brown
        Me.pbDE.ForeColor = System.Drawing.Color.White
        Me.pbDE.Location = New System.Drawing.Point(406, 334)
        Me.pbDE.MarqueeAnimationSpeed = 10
        Me.pbDE.Maximum = 180
        Me.pbDE.Name = "pbDE"
        Me.pbDE.Size = New System.Drawing.Size(65, 15)
        Me.pbDE.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbDE.TabIndex = 28
        '
        'pbSE
        '
        Me.pbSE.BackColor = System.Drawing.Color.Brown
        Me.pbSE.ForeColor = System.Drawing.Color.White
        Me.pbSE.Location = New System.Drawing.Point(508, 334)
        Me.pbSE.MarqueeAnimationSpeed = 10
        Me.pbSE.Maximum = 140
        Me.pbSE.Name = "pbSE"
        Me.pbSE.Size = New System.Drawing.Size(65, 15)
        Me.pbSE.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbSE.TabIndex = 31
        '
        'pbSD
        '
        Me.pbSD.BackColor = System.Drawing.Color.Brown
        Me.pbSD.ForeColor = System.Drawing.Color.White
        Me.pbSD.Location = New System.Drawing.Point(508, 309)
        Me.pbSD.MarqueeAnimationSpeed = 10
        Me.pbSD.Maximum = 125
        Me.pbSD.Name = "pbSD"
        Me.pbSD.Size = New System.Drawing.Size(65, 15)
        Me.pbSD.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbSD.TabIndex = 30
        '
        'pbSA
        '
        Me.pbSA.BackColor = System.Drawing.Color.Brown
        Me.pbSA.ForeColor = System.Drawing.Color.White
        Me.pbSA.Location = New System.Drawing.Point(508, 284)
        Me.pbSA.MarqueeAnimationSpeed = 10
        Me.pbSA.Maximum = 154
        Me.pbSA.Name = "pbSA"
        Me.pbSA.Size = New System.Drawing.Size(65, 15)
        Me.pbSA.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbSA.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Teal
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(385, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "HP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Teal
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(379, 310)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 14)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "ATK"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Teal
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(379, 335)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 14)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "DEF"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Teal
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(481, 335)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 14)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "SPE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Teal
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(480, 310)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 14)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "SPD"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Teal
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(480, 285)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 14)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "SPA"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Teal
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.Location = New System.Drawing.Point(366, 100)
        Me.Label16.Margin = New System.Windows.Forms.Padding(3)
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.Label16.Size = New System.Drawing.Size(320, 264)
        Me.Label16.TabIndex = 38
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PokedexDataDataSet
        '
        Me.PokedexDataDataSet.DataSetName = "PokedexDataDataSet"
        Me.PokedexDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Gen1BindingSource
        '
        Me.Gen1BindingSource.DataMember = "Gen1"
        Me.Gen1BindingSource.DataSource = Me.PokedexDataDataSet
        '
        'Gen1TableAdapter
        '
        Me.Gen1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Gen1TableAdapter = Me.Gen1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Final_Project_Ortiz__Lanon.PokedexDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Gen1DataGridView
        '
        Me.Gen1DataGridView.AutoGenerateColumns = False
        Me.Gen1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gen1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.Gen1DataGridView.DataSource = Me.Gen1BindingSource
        Me.Gen1DataGridView.Location = New System.Drawing.Point(845, 84)
        Me.Gen1DataGridView.Name = "Gen1DataGridView"
        Me.Gen1DataGridView.RowHeadersWidth = 51
        Me.Gen1DataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Gen1DataGridView.TabIndex = 39
        Me.Gen1DataGridView.UseWaitCursor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Dex Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Dex Number"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Pokemon"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Pokemon"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Type 1"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type 1"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Type 2"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Type 2"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Abilities"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Abilities"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "BaseStat1"
        Me.DataGridViewTextBoxColumn8.HeaderText = "BaseStat1"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "BaseStat2"
        Me.DataGridViewTextBoxColumn9.HeaderText = "BaseStat2"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Extra1"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Extra1"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Extra2"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Extra2"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Extra3"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Extra3"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Extra4"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Extra4"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'pctMed1
        '
        Me.pctMed1.BackColor = System.Drawing.Color.Transparent
        Me.pctMed1.Location = New System.Drawing.Point(183, 271)
        Me.pctMed1.Name = "pctMed1"
        Me.pctMed1.Size = New System.Drawing.Size(75, 75)
        Me.pctMed1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMed1.TabIndex = 40
        Me.pctMed1.TabStop = False
        '
        'pctMedB
        '
        Me.pctMedB.BackColor = System.Drawing.Color.Transparent
        Me.pctMedB.Location = New System.Drawing.Point(276, 272)
        Me.pctMedB.Name = "pctMedB"
        Me.pctMedB.Size = New System.Drawing.Size(75, 75)
        Me.pctMedB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMedB.TabIndex = 41
        Me.pctMedB.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(472, 193)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.Label3.Size = New System.Drawing.Size(4, 65)
        Me.Label3.TabIndex = 42
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(148, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.Label4.Size = New System.Drawing.Size(20, 264)
        Me.Label4.TabIndex = 43
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(366, 95)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.Label5.Size = New System.Drawing.Size(230, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDex
        '
        Me.txtDex.AutoSize = True
        Me.txtDex.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtDex.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDex.ForeColor = System.Drawing.Color.White
        Me.txtDex.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtDex.Location = New System.Drawing.Point(151, 103)
        Me.txtDex.Name = "txtDex"
        Me.txtDex.Size = New System.Drawing.Size(14, 56)
        Me.txtDex.TabIndex = 45
        Me.txtDex.Text = "#" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9"
        '
        'EVYield
        '
        Me.EVYield.AutoSize = True
        Me.EVYield.BackColor = System.Drawing.Color.Teal
        Me.EVYield.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EVYield.ForeColor = System.Drawing.Color.White
        Me.EVYield.Location = New System.Drawing.Point(484, 193)
        Me.EVYield.Name = "EVYield"
        Me.EVYield.Size = New System.Drawing.Size(51, 16)
        Me.EVYield.TabIndex = 46
        Me.EVYield.Text = "EV Yield"
        '
        'txtEV
        '
        Me.txtEV.BackColor = System.Drawing.Color.Teal
        Me.txtEV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEV.ForeColor = System.Drawing.Color.White
        Me.txtEV.Location = New System.Drawing.Point(486, 212)
        Me.txtEV.Margin = New System.Windows.Forms.Padding(3)
        Me.txtEV.Name = "txtEV"
        Me.txtEV.Size = New System.Drawing.Size(94, 18)
        Me.txtEV.TabIndex = 47
        Me.txtEV.Text = "The quick brown jumps over the lazy dog. The quick brown jumps over the lazy dog." &
    "The quick brown jumps over the lazy dog."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(484, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Catch Rate"
        '
        'txtCR
        '
        Me.txtCR.BackColor = System.Drawing.Color.Black
        Me.txtCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCR.ForeColor = System.Drawing.Color.White
        Me.txtCR.Location = New System.Drawing.Point(487, 243)
        Me.txtCR.Margin = New System.Windows.Forms.Padding(3)
        Me.txtCR.Name = "txtCR"
        Me.txtCR.Size = New System.Drawing.Size(45, 14)
        Me.txtCR.TabIndex = 49
        Me.txtCR.Text = "The quick brown jumps over the lazy dog. The quick brown jumps over the lazy dog." &
    "The quick brown jumps over the lazy dog."
        Me.txtCR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.txtCR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEV)
        Me.Controls.Add(Me.EVYield)
        Me.Controls.Add(Me.txtDex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pctMedB)
        Me.Controls.Add(Me.pctMed1)
        Me.Controls.Add(Me.Gen1DataGridView)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pbSE)
        Me.Controls.Add(Me.pbSD)
        Me.Controls.Add(Me.pbSA)
        Me.Controls.Add(Me.pbDE)
        Me.Controls.Add(Me.pbAT)
        Me.Controls.Add(Me.pbHP)
        Me.Controls.Add(Me.pctFeet)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Abilities)
        Me.Controls.Add(Me.txtPkmnAb)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtType2)
        Me.Controls.Add(Me.txtType1)
        Me.Controls.Add(Me.pctSprite)
        Me.Controls.Add(Me.txtPkmnName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pctLarge)
        Me.Controls.Add(Me.PkmnList)
        Me.Controls.Add(Me.txtRand)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPkmnDesc)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCat)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generation 1 Pokedex"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pctLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctFeet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokedexDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gen1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gen1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctMed1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctMedB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRand As Button
    Friend WithEvents PkmnList As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pctLarge As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPkmnName As Label
    Friend WithEvents pctSprite As PictureBox
    Friend WithEvents txtType1 As Label
    Friend WithEvents txtType2 As Label
    Friend WithEvents txtPkmnDesc As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtPkmnAb As Label
    Friend WithEvents Abilities As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pctFeet As PictureBox
    Friend WithEvents pbHP As ProgressBar
    Friend WithEvents pbAT As ProgressBar
    Friend WithEvents pbDE As ProgressBar
    Friend WithEvents pbSE As ProgressBar
    Friend WithEvents pbSD As ProgressBar
    Friend WithEvents pbSA As ProgressBar
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PokedexDataDataSet As PokedexDataDataSet
    Friend WithEvents Gen1BindingSource As BindingSource
    Friend WithEvents Gen1TableAdapter As PokedexDataDataSetTableAdapters.Gen1TableAdapter
    Friend WithEvents TableAdapterManager As PokedexDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Gen1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents txtCat As Label
    Friend WithEvents pctMed1 As PictureBox
    Friend WithEvents pctMedB As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDex As Label
    Friend WithEvents EVYield As Label
    Friend WithEvents txtEV As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCR As Label
End Class
