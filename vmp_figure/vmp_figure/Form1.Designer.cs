
namespace vmp_figure
{
    partial class Form1
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
            if ( disposing && (components != null) )
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
            this.shapeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.radiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.drawCirclesButton = new System.Windows.Forms.Button();
            this.drawAllShapesButton = new System.Windows.Forms.Button();
            this.addShapeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeTypeComboBox
            // 
            this.shapeTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.shapeTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.shapeTypeComboBox.FormattingEnabled = true;
            this.shapeTypeComboBox.Items.AddRange(new object[] {
            "Прямоугольник",
            "Окружность"});
            this.shapeTypeComboBox.Location = new System.Drawing.Point(85, 11);
            this.shapeTypeComboBox.Name = "shapeTypeComboBox";
            this.shapeTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.shapeTypeComboBox.TabIndex = 0;
            this.shapeTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.shapeTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип фигуры";
            // 
            // xNumericUpDown
            // 
            this.xNumericUpDown.Location = new System.Drawing.Point(85, 38);
            this.xNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xNumericUpDown.Name = "xNumericUpDown";
            this.xNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.xNumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // yNumericUpDown
            // 
            this.yNumericUpDown.Location = new System.Drawing.Point(85, 64);
            this.yNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yNumericUpDown.Name = "yNumericUpDown";
            this.yNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.yNumericUpDown.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Высота";
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Enabled = false;
            this.heightNumericUpDown.Location = new System.Drawing.Point(280, 38);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.heightNumericUpDown.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ширина";
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Enabled = false;
            this.widthNumericUpDown.Location = new System.Drawing.Point(280, 12);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.widthNumericUpDown.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Радиус";
            // 
            // radiusNumericUpDown
            // 
            this.radiusNumericUpDown.Enabled = false;
            this.radiusNumericUpDown.Location = new System.Drawing.Point(280, 64);
            this.radiusNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.radiusNumericUpDown.Name = "radiusNumericUpDown";
            this.radiusNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.radiusNumericUpDown.TabIndex = 10;
            // 
            // drawCirclesButton
            // 
            this.drawCirclesButton.Location = new System.Drawing.Point(12, 126);
            this.drawCirclesButton.Name = "drawCirclesButton";
            this.drawCirclesButton.Size = new System.Drawing.Size(143, 23);
            this.drawCirclesButton.TabIndex = 12;
            this.drawCirclesButton.Text = "Нарисовать окружности";
            this.drawCirclesButton.UseVisualStyleBackColor = true;
            this.drawCirclesButton.Click += new System.EventHandler(this.drawCirclesButton_Click);
            // 
            // drawAllShapesButton
            // 
            this.drawAllShapesButton.Location = new System.Drawing.Point(161, 126);
            this.drawAllShapesButton.Name = "drawAllShapesButton";
            this.drawAllShapesButton.Size = new System.Drawing.Size(143, 23);
            this.drawAllShapesButton.TabIndex = 13;
            this.drawAllShapesButton.Text = "Нарисовать все";
            this.drawAllShapesButton.UseVisualStyleBackColor = true;
            this.drawAllShapesButton.Click += new System.EventHandler(this.drawAllShapesButton_Click);
            // 
            // addShapeButton
            // 
            this.addShapeButton.Location = new System.Drawing.Point(12, 97);
            this.addShapeButton.Name = "addShapeButton";
            this.addShapeButton.Size = new System.Drawing.Size(143, 23);
            this.addShapeButton.TabIndex = 14;
            this.addShapeButton.Text = "Добавить фигуру";
            this.addShapeButton.UseVisualStyleBackColor = true;
            this.addShapeButton.Click += new System.EventHandler(this.addShapeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 161);
            this.Controls.Add(this.addShapeButton);
            this.Controls.Add(this.drawAllShapesButton);
            this.Controls.Add(this.drawCirclesButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radiusNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.heightNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.widthNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Фигуры";
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox shapeTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown xNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown yNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown radiusNumericUpDown;
        private System.Windows.Forms.Button drawCirclesButton;
        private System.Windows.Forms.Button drawAllShapesButton;
        private System.Windows.Forms.Button addShapeButton;
    }
}

