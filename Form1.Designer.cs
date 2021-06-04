namespace Fractals
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bDraw = new System.Windows.Forms.Button();
            this.udAnchorX = new System.Windows.Forms.NumericUpDown();
            this.udAnchorY = new System.Windows.Forms.NumericUpDown();
            this.udWidth = new System.Windows.Forms.NumericUpDown();
            this.udHeigth = new System.Windows.Forms.NumericUpDown();
            this.DecartSquare = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbViolet = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbMulty = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGrey = new System.Windows.Forms.RadioButton();
            this.udIterations = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMove = new System.Windows.Forms.GroupBox();
            this.btUp = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.tipUpdown = new System.Windows.Forms.ToolTip(this.components);
            this.tbSizeCnange = new System.Windows.Forms.TrackBar();
            this.lbSizeChange = new System.Windows.Forms.Label();
            this.saveBitmapDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.pSwitchCircle = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bIncreaseDecrease = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.udAnchorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAnchorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHeigth)).BeginInit();
            this.DecartSquare.SuspendLayout();
            this.gbColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udIterations)).BeginInit();
            this.gbMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeCnange)).BeginInit();
            this.gbSize.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // bDraw
            // 
            this.bDraw.Location = new System.Drawing.Point(12, 284);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(131, 23);
            this.bDraw.TabIndex = 4;
            this.bDraw.Text = "Нарисовать фрактал";
            this.bDraw.UseVisualStyleBackColor = true;
            this.bDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bDraw_MouseClick);
            // 
            // udAnchorX
            // 
            this.udAnchorX.DecimalPlaces = 15;
            this.udAnchorX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udAnchorX.Location = new System.Drawing.Point(26, 56);
            this.udAnchorX.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udAnchorX.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.udAnchorX.Name = "udAnchorX";
            this.udAnchorX.Size = new System.Drawing.Size(90, 20);
            this.udAnchorX.TabIndex = 5;
            this.udAnchorX.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.udAnchorX.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // udAnchorY
            // 
            this.udAnchorY.DecimalPlaces = 15;
            this.udAnchorY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udAnchorY.Location = new System.Drawing.Point(26, 82);
            this.udAnchorY.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udAnchorY.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.udAnchorY.Name = "udAnchorY";
            this.udAnchorY.Size = new System.Drawing.Size(90, 20);
            this.udAnchorY.TabIndex = 6;
            this.udAnchorY.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.udAnchorY.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // udWidth
            // 
            this.udWidth.DecimalPlaces = 15;
            this.udWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udWidth.Location = new System.Drawing.Point(149, 56);
            this.udWidth.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            983040});
            this.udWidth.Name = "udWidth";
            this.udWidth.Size = new System.Drawing.Size(95, 20);
            this.udWidth.TabIndex = 7;
            this.udWidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udWidth.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // udHeigth
            // 
            this.udHeigth.DecimalPlaces = 15;
            this.udHeigth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udHeigth.Location = new System.Drawing.Point(149, 82);
            this.udHeigth.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udHeigth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            983040});
            this.udHeigth.Name = "udHeigth";
            this.udHeigth.Size = new System.Drawing.Size(95, 20);
            this.udHeigth.TabIndex = 8;
            this.udHeigth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udHeigth.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // DecartSquare
            // 
            this.DecartSquare.BackColor = System.Drawing.Color.LightGreen;
            this.DecartSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DecartSquare.Controls.Add(this.label5);
            this.DecartSquare.Controls.Add(this.label2);
            this.DecartSquare.Controls.Add(this.label4);
            this.DecartSquare.Controls.Add(this.udAnchorX);
            this.DecartSquare.Controls.Add(this.label1);
            this.DecartSquare.Controls.Add(this.udHeigth);
            this.DecartSquare.Controls.Add(this.udAnchorY);
            this.DecartSquare.Controls.Add(this.udWidth);
            this.DecartSquare.Location = new System.Drawing.Point(12, 12);
            this.DecartSquare.Name = "DecartSquare";
            this.DecartSquare.Size = new System.Drawing.Size(270, 126);
            this.DecartSquare.TabIndex = 9;
            this.DecartSquare.TabStop = false;
            this.DecartSquare.Text = "Введите параметры плоскости в декартовых координатах:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ширина/высота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Левый верхний угол";
            // 
            // gbColor
            // 
            this.gbColor.BackColor = System.Drawing.Color.LightGreen;
            this.gbColor.Controls.Add(this.rbViolet);
            this.gbColor.Controls.Add(this.rbBlue);
            this.gbColor.Controls.Add(this.rbGreen);
            this.gbColor.Controls.Add(this.rbMulty);
            this.gbColor.Controls.Add(this.rbRed);
            this.gbColor.Controls.Add(this.rbGrey);
            this.gbColor.Location = new System.Drawing.Point(12, 145);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(272, 104);
            this.gbColor.TabIndex = 10;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Выберите цветовую схему фрактала";
            // 
            // rbViolet
            // 
            this.rbViolet.AutoSize = true;
            this.rbViolet.Location = new System.Drawing.Point(149, 78);
            this.rbViolet.Name = "rbViolet";
            this.rbViolet.Size = new System.Drawing.Size(91, 17);
            this.rbViolet.TabIndex = 5;
            this.rbViolet.TabStop = true;
            this.rbViolet.Tag = "5";
            this.rbViolet.Text = "Фиолетовый";
            this.rbViolet.UseVisualStyleBackColor = true;
            this.rbViolet.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(6, 78);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(56, 17);
            this.rbBlue.TabIndex = 4;
            this.rbBlue.TabStop = true;
            this.rbBlue.Tag = "4";
            this.rbBlue.Text = "Синий";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(149, 55);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(70, 17);
            this.rbGreen.TabIndex = 3;
            this.rbGreen.TabStop = true;
            this.rbGreen.Tag = "3";
            this.rbGreen.Text = "Зеленый";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMulty
            // 
            this.rbMulty.AutoSize = true;
            this.rbMulty.Checked = true;
            this.rbMulty.Location = new System.Drawing.Point(6, 32);
            this.rbMulty.Name = "rbMulty";
            this.rbMulty.Size = new System.Drawing.Size(99, 17);
            this.rbMulty.TabIndex = 2;
            this.rbMulty.TabStop = true;
            this.rbMulty.Tag = "0";
            this.rbMulty.Text = "Разноцветный";
            this.rbMulty.UseVisualStyleBackColor = true;
            this.rbMulty.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(6, 55);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(70, 17);
            this.rbRed.TabIndex = 1;
            this.rbRed.Tag = "2";
            this.rbRed.Text = "Красный";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbGrey
            // 
            this.rbGrey.AutoSize = true;
            this.rbGrey.Location = new System.Drawing.Point(149, 32);
            this.rbGrey.Name = "rbGrey";
            this.rbGrey.Size = new System.Drawing.Size(92, 17);
            this.rbGrey.TabIndex = 0;
            this.rbGrey.Tag = "1";
            this.rbGrey.Text = "Черно-белый";
            this.rbGrey.UseVisualStyleBackColor = true;
            this.rbGrey.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // udIterations
            // 
            this.udIterations.Location = new System.Drawing.Point(135, 261);
            this.udIterations.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udIterations.Name = "udIterations";
            this.udIterations.Size = new System.Drawing.Size(90, 20);
            this.udIterations.TabIndex = 11;
            this.udIterations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udIterations.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Максимум итераций:";
            // 
            // gbMove
            // 
            this.gbMove.BackColor = System.Drawing.Color.LightGreen;
            this.gbMove.Controls.Add(this.btUp);
            this.gbMove.Controls.Add(this.btDown);
            this.gbMove.Controls.Add(this.btRight);
            this.gbMove.Controls.Add(this.btLeft);
            this.gbMove.Location = new System.Drawing.Point(12, 313);
            this.gbMove.Name = "gbMove";
            this.gbMove.Size = new System.Drawing.Size(143, 126);
            this.gbMove.TabIndex = 18;
            this.gbMove.TabStop = false;
            this.gbMove.Text = "Перемещение по фракталу:";
            // 
            // btUp
            // 
            this.btUp.BackgroundImage = global::Fractals.Properties.Resources.arrow_up;
            this.btUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btUp.Location = new System.Drawing.Point(42, 33);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(23, 23);
            this.btUp.TabIndex = 13;
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btUp_MouseClick);
            // 
            // btDown
            // 
            this.btDown.BackgroundImage = global::Fractals.Properties.Resources.arrow_down;
            this.btDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDown.Location = new System.Drawing.Point(42, 75);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(23, 23);
            this.btDown.TabIndex = 16;
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btDown_MouseClick);
            // 
            // btRight
            // 
            this.btRight.BackgroundImage = global::Fractals.Properties.Resources.arrow_right;
            this.btRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRight.Location = new System.Drawing.Point(71, 55);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(23, 23);
            this.btRight.TabIndex = 14;
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btRight_MouseClick);
            // 
            // btLeft
            // 
            this.btLeft.BackgroundImage = global::Fractals.Properties.Resources.arrow_left;
            this.btLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btLeft.Location = new System.Drawing.Point(13, 55);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(23, 23);
            this.btLeft.TabIndex = 15;
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btLeft_MouseClick);
            // 
            // tipUpdown
            // 
            this.tipUpdown.IsBalloon = true;
            // 
            // tbSizeCnange
            // 
            this.tbSizeCnange.LargeChange = 1;
            this.tbSizeCnange.Location = new System.Drawing.Point(12, 46);
            this.tbSizeCnange.Maximum = 5;
            this.tbSizeCnange.Minimum = 1;
            this.tbSizeCnange.Name = "tbSizeCnange";
            this.tbSizeCnange.Size = new System.Drawing.Size(104, 45);
            this.tbSizeCnange.TabIndex = 19;
            this.tbSizeCnange.Value = 1;
            this.tbSizeCnange.Scroll += new System.EventHandler(this.tbSizeCnange_Scroll);
            // 
            // lbSizeChange
            // 
            this.lbSizeChange.AutoSize = true;
            this.lbSizeChange.Location = new System.Drawing.Point(75, 14);
            this.lbSizeChange.Name = "lbSizeChange";
            this.lbSizeChange.Size = new System.Drawing.Size(35, 13);
            this.lbSizeChange.TabIndex = 21;
            this.lbSizeChange.Text = "label7";
            // 
            // saveBitmapDialog
            // 
            this.saveBitmapDialog.DefaultExt = "bmp";
            this.saveBitmapDialog.FileName = "Fractal";
            this.saveBitmapDialog.Filter = "Растровое изображение | *.bmp|Сжатое растровое изображение|*.jpeg|Все файлы|*.*";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.LightGreen;
            this.gbSize.Controls.Add(this.panel3);
            this.gbSize.Controls.Add(this.panel2);
            this.gbSize.Controls.Add(this.panel1);
            this.gbSize.Controls.Add(this.tbSizeCnange);
            this.gbSize.Controls.Add(this.lbSizeChange);
            this.gbSize.Location = new System.Drawing.Point(161, 313);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(123, 126);
            this.gbSize.TabIndex = 23;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Кратность увеличения:";
            // 
            // pSwitchCircle
            // 
            this.pSwitchCircle.BackColor = System.Drawing.Color.Transparent;
            this.pSwitchCircle.BackgroundImage = global::Fractals.Properties.Resources.toggle_square;
            this.pSwitchCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pSwitchCircle.Enabled = false;
            this.pSwitchCircle.Location = new System.Drawing.Point(-1, 0);
            this.pSwitchCircle.Name = "pSwitchCircle";
            this.pSwitchCircle.Size = new System.Drawing.Size(30, 25);
            this.pSwitchCircle.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Fractals.Properties.Resources._switch;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pSwitchCircle);
            this.panel3.Controls.Add(this.bIncreaseDecrease);
            this.panel3.Location = new System.Drawing.Point(44, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 25);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Fractals.Properties.Resources.zoom_out;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(96, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 27);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Fractals.Properties.Resources.zoom_in;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(15, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 27);
            this.panel1.TabIndex = 24;
            // 
            // bIncreaseDecrease
            // 
            this.bIncreaseDecrease.BackColor = System.Drawing.Color.Transparent;
            this.bIncreaseDecrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bIncreaseDecrease.FlatAppearance.BorderSize = 0;
            this.bIncreaseDecrease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bIncreaseDecrease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bIncreaseDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIncreaseDecrease.ForeColor = System.Drawing.Color.Transparent;
            this.bIncreaseDecrease.Location = new System.Drawing.Point(0, 0);
            this.bIncreaseDecrease.Margin = new System.Windows.Forms.Padding(0);
            this.bIncreaseDecrease.Name = "bIncreaseDecrease";
            this.bIncreaseDecrease.Size = new System.Drawing.Size(46, 23);
            this.bIncreaseDecrease.TabIndex = 22;
            this.bIncreaseDecrease.UseVisualStyleBackColor = false;
            this.bIncreaseDecrease.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bIncrease_MouseClick);
            // 
            // bSave
            // 
            this.bSave.Image = global::Fractals.Properties.Resources.picture_save;
            this.bSave.Location = new System.Drawing.Point(149, 284);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(23, 23);
            this.bSave.TabIndex = 22;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSave_MouseClick);
            // 
            // pbMain
            // 
            this.pbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMain.BackColor = System.Drawing.SystemColors.Control;
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMain.Location = new System.Drawing.Point(288, 12);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(534, 437);
            this.pbMain.TabIndex = 3;
            this.pbMain.TabStop = false;
            this.pbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMain_Paint);
            this.pbMain.DoubleClick += new System.EventHandler(this.pbMain_DoubleClick);
            this.pbMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.gbMove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.udIterations);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.DecartSquare);
            this.Controls.Add(this.bDraw);
            this.Controls.Add(this.pbMain);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "MainForm";
            this.Text = "Рисование фракталов";
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.udAnchorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAnchorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHeigth)).EndInit();
            this.DecartSquare.ResumeLayout(false);
            this.DecartSquare.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udIterations)).EndInit();
            this.gbMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeCnange)).EndInit();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Button bDraw;
        private System.Windows.Forms.NumericUpDown udAnchorX;
        private System.Windows.Forms.NumericUpDown udAnchorY;
        private System.Windows.Forms.NumericUpDown udWidth;
        private System.Windows.Forms.NumericUpDown udHeigth;
        private System.Windows.Forms.GroupBox DecartSquare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.RadioButton rbMulty;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGrey;
        private System.Windows.Forms.NumericUpDown udIterations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.GroupBox gbMove;
        private System.Windows.Forms.ToolTip tipUpdown;
        private System.Windows.Forms.TrackBar tbSizeCnange;
        private System.Windows.Forms.Label lbSizeChange;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.SaveFileDialog saveBitmapDialog;
        private System.Windows.Forms.RadioButton rbViolet;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.Button bIncreaseDecrease;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pSwitchCircle;
    }
}

