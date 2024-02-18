namespace ArduinoController
{
    partial class Interface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            cbListComPorts = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            groupBox1 = new GroupBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(167, 118);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(99, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "Atualizar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-163, 299);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(163, 99);
            materialDrawer1.TabIndex = 2;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // cbListComPorts
            // 
            cbListComPorts.AutoResize = false;
            cbListComPorts.BackColor = Color.FromArgb(255, 255, 255);
            cbListComPorts.Depth = 0;
            cbListComPorts.DrawMode = DrawMode.OwnerDrawVariable;
            cbListComPorts.DropDownHeight = 174;
            cbListComPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListComPorts.DropDownWidth = 121;
            cbListComPorts.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbListComPorts.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbListComPorts.FormattingEnabled = true;
            cbListComPorts.IntegralHeight = false;
            cbListComPorts.ItemHeight = 43;
            cbListComPorts.Location = new Point(6, 105);
            cbListComPorts.MaxDropDownItems = 4;
            cbListComPorts.MouseState = MaterialSkin.MouseState.OUT;
            cbListComPorts.Name = "cbListComPorts";
            cbListComPorts.Size = new Size(154, 49);
            cbListComPorts.StartIndex = 0;
            cbListComPorts.TabIndex = 4;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 83);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(99, 19);
            materialLabel1.TabIndex = 6;
            materialLabel1.Text = "Portas Seriais";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(6, 456);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(123, 19);
            materialLabel2.TabIndex = 7;
            materialLabel2.Text = "Porta Conectada:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(135, 456);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(39, 19);
            materialLabel3.TabIndex = 8;
            materialLabel3.Text = "Porta";
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(6, 183);
            materialRadioButton1.Margin = new Padding(0);
            materialRadioButton1.MouseLocation = new Point(-1, -1);
            materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton1.Name = "materialRadioButton1";
            materialRadioButton1.Ripple = true;
            materialRadioButton1.Size = new Size(190, 37);
            materialRadioButton1.TabIndex = 9;
            materialRadioButton1.TabStop = true;
            materialRadioButton1.Text = "materialRadioButton1";
            materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.Icon = null;
            materialFloatingActionButton1.Location = new Point(269, 163);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(58, 63);
            materialFloatingActionButton1.TabIndex = 10;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialLabel10);
            groupBox1.Controls.Add(materialLabel9);
            groupBox1.Controls.Add(materialLabel8);
            groupBox1.Controls.Add(materialLabel7);
            groupBox1.Controls.Add(materialLabel6);
            groupBox1.Controls.Add(materialLabel5);
            groupBox1.Controls.Add(materialLabel4);
            groupBox1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 223);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 230);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parâmetros";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(6, 29);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(123, 19);
            materialLabel4.TabIndex = 8;
            materialLabel4.Text = "Porta Conectada:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(6, 53);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(123, 19);
            materialLabel5.TabIndex = 9;
            materialLabel5.Text = "Porta Conectada:";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(6, 79);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(123, 19);
            materialLabel6.TabIndex = 10;
            materialLabel6.Text = "Porta Conectada:";
            materialLabel6.Click += materialLabel6_Click;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(6, 103);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(123, 19);
            materialLabel7.TabIndex = 11;
            materialLabel7.Text = "Porta Conectada:";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(6, 127);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(123, 19);
            materialLabel8.TabIndex = 12;
            materialLabel8.Text = "Porta Conectada:";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(6, 174);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(123, 19);
            materialLabel9.TabIndex = 13;
            materialLabel9.Text = "Porta Conectada:";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(6, 208);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(123, 19);
            materialLabel10.TabIndex = 14;
            materialLabel10.Text = "Porta Conectada:";
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 600);
            Controls.Add(groupBox1);
            Controls.Add(materialFloatingActionButton1);
            Controls.Add(materialRadioButton1);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(cbListComPorts);
            Controls.Add(materialDrawer1);
            Controls.Add(materialButton1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Interface";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Serial Port Interface";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialSkin.Controls.MaterialComboBox cbListComPorts;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBox21;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}