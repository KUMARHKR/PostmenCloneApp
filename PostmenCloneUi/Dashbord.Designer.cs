namespace PostmenCloneUi
{
    partial class Dashbord
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
            PostmanClone = new Label();
            Apilabel = new Label();
            apiText = new TextBox();
            callApi = new Button();
            resultsText = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // PostmanClone
            // 
            PostmanClone.AutoSize = true;
            PostmanClone.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PostmanClone.Location = new Point(152, 82);
            PostmanClone.Name = "PostmanClone";
            PostmanClone.Size = new Size(254, 47);
            PostmanClone.TabIndex = 0;
            PostmanClone.Text = "Postman Clone";
            // 
            // Apilabel
            // 
            Apilabel.AutoSize = true;
            Apilabel.Location = new Point(152, 173);
            Apilabel.Name = "Apilabel";
            Apilabel.Size = new Size(60, 32);
            Apilabel.TabIndex = 1;
            Apilabel.Text = "API :";
            // 
            // apiText
            // 
            apiText.Location = new Point(228, 173);
            apiText.Name = "apiText";
            apiText.Size = new Size(659, 39);
            apiText.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.Location = new Point(951, 173);
            callApi.Name = "callApi";
            callApi.Size = new Size(165, 39);
            callApi.TabIndex = 3;
            callApi.Text = "Go";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Location = new Point(152, 276);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(964, 309);
            resultsText.TabIndex = 4;
            resultsText.TextChanged += resultsText_TextChanged;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.White;
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 628);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1220, 30);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "systemStatus";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(60, 25);
            systemStatus.Text = "Rrady";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(152, 230);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(88, 32);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results";
            // 
            // Dashbord
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1220, 658);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(resultsText);
            Controls.Add(callApi);
            Controls.Add(apiText);
            Controls.Add(Apilabel);
            Controls.Add(PostmanClone);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Dashbord";
            Text = "Postmen Clone";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PostmanClone;
        private Label Apilabel;
        private TextBox apiText;
        private Button callApi;
        private TextBox resultsText;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
