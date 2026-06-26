namespace OOP_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCenter = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblEdge = new System.Windows.Forms.Label();
            this.txtCenterX = new System.Windows.Forms.TextBox();
            this.txtCenterY = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.trkRed = new System.Windows.Forms.TrackBar();
            this.trkGreen = new System.Windows.Forms.TrackBar();
            this.trkBlue = new System.Windows.Forms.TrackBar();
            this.txtEdge = new System.Windows.Forms.TextBox();
            this.chkCCW = new System.Windows.Forms.CheckBox();
            this.lblSpin = new System.Windows.Forms.Label();
            this.trkSpin = new System.Windows.Forms.TrackBar();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lblCurrentSpin = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpin)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Location = new System.Drawing.Point(12, 50);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(350, 350);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(368, 50);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(158, 35);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(368, 85);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(158, 35);
            this.btnRotate.TabIndex = 2;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(368, 120);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(158, 35);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 406);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(175, 35);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load from File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(187, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCenter
            // 
            this.lblCenter.AutoSize = true;
            this.lblCenter.Location = new System.Drawing.Point(368, 163);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(60, 13);
            this.lblCenter.TabIndex = 6;
            this.lblCenter.Text = "Center (x,y)";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(378, 188);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Length";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(383, 220);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 8;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(378, 245);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 9;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(383, 273);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 10;
            this.lblBlue.Text = "Blue";
            // 
            // lblEdge
            // 
            this.lblEdge.AutoSize = true;
            this.lblEdge.Location = new System.Drawing.Point(378, 306);
            this.lblEdge.Name = "lblEdge";
            this.lblEdge.Size = new System.Drawing.Size(32, 13);
            this.lblEdge.TabIndex = 11;
            this.lblEdge.Text = "Edge";
            // 
            // txtCenterX
            // 
            this.txtCenterX.Location = new System.Drawing.Point(434, 160);
            this.txtCenterX.Name = "txtCenterX";
            this.txtCenterX.Size = new System.Drawing.Size(40, 20);
            this.txtCenterX.TabIndex = 13;
            this.txtCenterX.Text = "0";
            this.txtCenterX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCenterY
            // 
            this.txtCenterY.Location = new System.Drawing.Point(486, 159);
            this.txtCenterY.Name = "txtCenterY";
            this.txtCenterY.Size = new System.Drawing.Size(40, 20);
            this.txtCenterY.TabIndex = 14;
            this.txtCenterY.Text = "0";
            this.txtCenterY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(434, 185);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(92, 20);
            this.txtLength.TabIndex = 15;
            this.txtLength.Text = "4";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkRed
            // 
            this.trkRed.AutoSize = false;
            this.trkRed.Location = new System.Drawing.Point(434, 215);
            this.trkRed.Maximum = 255;
            this.trkRed.Name = "trkRed";
            this.trkRed.Size = new System.Drawing.Size(92, 24);
            this.trkRed.TabIndex = 16;
            this.trkRed.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trkGreen
            // 
            this.trkGreen.AutoSize = false;
            this.trkGreen.Location = new System.Drawing.Point(434, 242);
            this.trkGreen.Maximum = 255;
            this.trkGreen.Name = "trkGreen";
            this.trkGreen.Size = new System.Drawing.Size(92, 24);
            this.trkGreen.TabIndex = 17;
            this.trkGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trkBlue
            // 
            this.trkBlue.AutoSize = false;
            this.trkBlue.Location = new System.Drawing.Point(434, 270);
            this.trkBlue.Maximum = 255;
            this.trkBlue.Name = "trkBlue";
            this.trkBlue.Size = new System.Drawing.Size(92, 24);
            this.trkBlue.TabIndex = 18;
            this.trkBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // txtEdge
            // 
            this.txtEdge.Location = new System.Drawing.Point(416, 303);
            this.txtEdge.Name = "txtEdge";
            this.txtEdge.Size = new System.Drawing.Size(53, 20);
            this.txtEdge.TabIndex = 19;
            this.txtEdge.Text = "5";
            this.txtEdge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkCCW
            // 
            this.chkCCW.AutoSize = true;
            this.chkCCW.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCCW.Location = new System.Drawing.Point(475, 305);
            this.chkCCW.Name = "chkCCW";
            this.chkCCW.Size = new System.Drawing.Size(51, 17);
            this.chkCCW.TabIndex = 20;
            this.chkCCW.Text = "CCW";
            this.chkCCW.UseVisualStyleBackColor = true;
            // 
            // lblSpin
            // 
            this.lblSpin.AutoSize = true;
            this.lblSpin.Location = new System.Drawing.Point(376, 374);
            this.lblSpin.Name = "lblSpin";
            this.lblSpin.Size = new System.Drawing.Size(42, 26);
            this.lblSpin.TabIndex = 21;
            this.lblSpin.Text = "  Spin\r\nInterval";
            // 
            // trkSpin
            // 
            this.trkSpin.AutoSize = false;
            this.trkSpin.Location = new System.Drawing.Point(424, 376);
            this.trkSpin.Name = "trkSpin";
            this.trkSpin.Size = new System.Drawing.Size(102, 24);
            this.trkSpin.TabIndex = 22;
            this.trkSpin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkSpin.Value = 3;
            this.trkSpin.Scroll += new System.EventHandler(this.trkSpin_Scroll);
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(431, 360);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(13, 13);
            this.lbl0.TabIndex = 23;
            this.lbl0.Text = "0";
            // 
            // lblCurrentSpin
            // 
            this.lblCurrentSpin.AutoSize = true;
            this.lblCurrentSpin.Location = new System.Drawing.Point(469, 360);
            this.lblCurrentSpin.Name = "lblCurrentSpin";
            this.lblCurrentSpin.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentSpin.TabIndex = 24;
            this.lblCurrentSpin.Text = "3";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(507, 360);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(19, 13);
            this.lbl10.TabIndex = 25;
            this.lbl10.Text = "10";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(378, 336);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(34, 13);
            this.lblAngle.TabIndex = 26;
            this.lblAngle.Text = "Angle";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(416, 333);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(53, 20);
            this.txtAngle.TabIndex = 27;
            this.txtAngle.Text = "0";
            this.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 479);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lblCurrentSpin);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.trkSpin);
            this.Controls.Add(this.lblSpin);
            this.Controls.Add(this.chkCCW);
            this.Controls.Add(this.txtEdge);
            this.Controls.Add(this.trkBlue);
            this.Controls.Add(this.trkGreen);
            this.Controls.Add(this.trkRed);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtCenterY);
            this.Controls.Add(this.txtCenterX);
            this.Controls.Add(this.lblEdge);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblCenter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.picCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCenter;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblEdge;
        private System.Windows.Forms.TextBox txtCenterX;
        private System.Windows.Forms.TextBox txtCenterY;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TrackBar trkRed;
        private System.Windows.Forms.TrackBar trkGreen;
        private System.Windows.Forms.TrackBar trkBlue;
        private System.Windows.Forms.TextBox txtEdge;
        private System.Windows.Forms.CheckBox chkCCW;
        private System.Windows.Forms.Label lblSpin;
        private System.Windows.Forms.TrackBar trkSpin;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lblCurrentSpin;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.TextBox txtAngle;
    }
}

