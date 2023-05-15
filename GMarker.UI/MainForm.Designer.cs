namespace GMarker.UI
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
            this._saveChangesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _saveChangesBtn
            // 
            this._saveChangesBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._saveChangesBtn.Location = new System.Drawing.Point(0, 427);
            this._saveChangesBtn.Name = "_saveChangesBtn";
            this._saveChangesBtn.Size = new System.Drawing.Size(800, 23);
            this._saveChangesBtn.TabIndex = 0;
            this._saveChangesBtn.Text = "Save changes";
            this._saveChangesBtn.UseVisualStyleBackColor = true;
            this._saveChangesBtn.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._saveChangesBtn);
            this.Name = "MainForm";
            this.Text = "GMarker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _saveChangesBtn;
    }
}

