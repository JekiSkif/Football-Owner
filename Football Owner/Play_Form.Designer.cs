
namespace Football_Owner
{
    partial class Play_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play_Form));
            this.New_Game = new System.Windows.Forms.Button();
            this.Load_Game = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_Game
            // 
            this.New_Game.Location = new System.Drawing.Point(488, 132);
            this.New_Game.Name = "New_Game";
            this.New_Game.Size = new System.Drawing.Size(318, 74);
            this.New_Game.TabIndex = 0;
            this.New_Game.Text = "New Game";
            this.New_Game.UseVisualStyleBackColor = true;
            this.New_Game.Click += new System.EventHandler(this.New_Game_Click);
            // 
            // Load_Game
            // 
            this.Load_Game.Location = new System.Drawing.Point(488, 337);
            this.Load_Game.Name = "Load_Game";
            this.Load_Game.Size = new System.Drawing.Size(318, 74);
            this.Load_Game.TabIndex = 1;
            this.Load_Game.Text = "Load Game";
            this.Load_Game.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(66, 629);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(112, 34);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Play_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 789);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Load_Game);
            this.Controls.Add(this.New_Game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Play_Form";
            this.Text = "Play_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New_Game;
        private System.Windows.Forms.Button Load_Game;
        private System.Windows.Forms.Button Back;
    }
}