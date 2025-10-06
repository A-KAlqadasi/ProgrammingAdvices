namespace TrafficLightProject
{
    partial class ctrlTrafficLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.LightTimer = new System.Windows.Forms.Timer(this.components);
            this.pbLightImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLightImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimerCount
            // 
            this.lblTimerCount.AutoSize = true;
            this.lblTimerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerCount.ForeColor = System.Drawing.Color.Red;
            this.lblTimerCount.Location = new System.Drawing.Point(21, 191);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(45, 25);
            this.lblTimerCount.TabIndex = 1;
            this.lblTimerCount.Text = "???";
            // 
            // LightTimer
            // 
            this.LightTimer.Interval = 1000;
            this.LightTimer.Tick += new System.EventHandler(this.LightTimer_Tick);
            // 
            // pbLightImage
            // 
            this.pbLightImage.BackColor = System.Drawing.Color.Transparent;
            this.pbLightImage.Image = global::TrafficLightProject.Properties.Resources.Red;
            this.pbLightImage.Location = new System.Drawing.Point(0, 0);
            this.pbLightImage.Name = "pbLightImage";
            this.pbLightImage.Size = new System.Drawing.Size(87, 188);
            this.pbLightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLightImage.TabIndex = 0;
            this.pbLightImage.TabStop = false;
            // 
            // ctrlTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTimerCount);
            this.Controls.Add(this.pbLightImage);
            this.Name = "ctrlTrafficLight";
            this.Size = new System.Drawing.Size(89, 224);
            ((System.ComponentModel.ISupportInitialize)(this.pbLightImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLightImage;
        private System.Windows.Forms.Label lblTimerCount;
        private System.Windows.Forms.Timer LightTimer;
    }
}
