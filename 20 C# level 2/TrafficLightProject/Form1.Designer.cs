namespace TrafficLightProject
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
            this.ctrlTrafficLight1 = new TrafficLightProject.ctrlTrafficLight();
            this.ctrlTrafficLight21 = new TrafficLightProject.ctrlTrafficLight2();
            this.SuspendLayout();
            // 
            // ctrlTrafficLight1
            // 
            this.ctrlTrafficLight1.BackColor = System.Drawing.Color.White;
            this.ctrlTrafficLight1.CurrentLight = TrafficLightProject.ctrlTrafficLight.LightEnum.Red;
            this.ctrlTrafficLight1.GreenTime = 10;
            this.ctrlTrafficLight1.Location = new System.Drawing.Point(12, 12);
            this.ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            this.ctrlTrafficLight1.RedTime = 10;
            this.ctrlTrafficLight1.Size = new System.Drawing.Size(89, 226);
            this.ctrlTrafficLight1.TabIndex = 0;
            this.ctrlTrafficLight1.YellowTime = 5;
            this.ctrlTrafficLight1.GreenLightOn += new System.EventHandler<TrafficLightProject.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_GreenLightOn);
            // 
            // ctrlTrafficLight21
            // 
            this.ctrlTrafficLight21.CurrentLight = TrafficLightProject.ctrlTrafficLight2.LightEnum.Green;
            this.ctrlTrafficLight21.GreenTime = 10;
            this.ctrlTrafficLight21.Location = new System.Drawing.Point(235, 13);
            this.ctrlTrafficLight21.Name = "ctrlTrafficLight21";
            this.ctrlTrafficLight21.RedTime = 10;
            this.ctrlTrafficLight21.Size = new System.Drawing.Size(89, 225);
            this.ctrlTrafficLight21.TabIndex = 1;
            this.ctrlTrafficLight21.YellowTime = 5;
            this.ctrlTrafficLight21.GreenLightOn += new System.EventHandler<TrafficLightProject.ctrlTrafficLight2.TrafficLightEventArgs>(this.ctrlTrafficLight21_GreenLightOn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 413);
            this.Controls.Add(this.ctrlTrafficLight21);
            this.Controls.Add(this.ctrlTrafficLight1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
        private ctrlTrafficLight2 ctrlTrafficLight21;
    }
}

