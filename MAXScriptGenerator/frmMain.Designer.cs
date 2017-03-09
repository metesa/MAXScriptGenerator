namespace MAXScriptGenerator
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtScript = new System.Windows.Forms.TextBox();
            this.lblObject = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblWait = new System.Windows.Forms.Label();
            this.lblWaitUnit = new System.Windows.Forms.Label();
            this.lblRotateUnit = new System.Windows.Forms.Label();
            this.lblMoveUnit = new System.Windows.Forms.Label();
            this.cmbMoveDirection = new System.Windows.Forms.ComboBox();
            this.txtRotateSpeed = new System.Windows.Forms.TextBox();
            this.lblRotateSpeed = new System.Windows.Forms.Label();
            this.txtMoveSpeed = new System.Windows.Forms.TextBox();
            this.lblMoveSpeed = new System.Windows.Forms.Label();
            this.txtWaitPeriod = new System.Windows.Forms.TextBox();
            this.txtRotateAngle = new System.Windows.Forms.TextBox();
            this.txtMoveDistance = new System.Windows.Forms.TextBox();
            this.lblMove = new System.Windows.Forms.Label();
            this.lblRotate = new System.Windows.Forms.Label();
            this.cmbRotateDirection = new System.Windows.Forms.ComboBox();
            this.cmbAction = new System.Windows.Forms.ComboBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.btnAddAction = new System.Windows.Forms.Button();
            this.lstAction = new System.Windows.Forms.ListView();
            this.clhFrame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLicense = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(315, 12);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.ReadOnly = true;
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtScript.Size = new System.Drawing.Size(364, 205);
            this.txtScript.TabIndex = 0;
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(6, 17);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(47, 12);
            this.lblObject.TabIndex = 1;
            this.lblObject.Text = "Object:";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.lblWait);
            this.grpInput.Controls.Add(this.lblWaitUnit);
            this.grpInput.Controls.Add(this.lblRotateUnit);
            this.grpInput.Controls.Add(this.lblMoveUnit);
            this.grpInput.Controls.Add(this.cmbMoveDirection);
            this.grpInput.Controls.Add(this.txtRotateSpeed);
            this.grpInput.Controls.Add(this.lblRotateSpeed);
            this.grpInput.Controls.Add(this.txtMoveSpeed);
            this.grpInput.Controls.Add(this.lblMoveSpeed);
            this.grpInput.Controls.Add(this.txtWaitPeriod);
            this.grpInput.Controls.Add(this.txtRotateAngle);
            this.grpInput.Controls.Add(this.txtMoveDistance);
            this.grpInput.Controls.Add(this.lblMove);
            this.grpInput.Controls.Add(this.lblRotate);
            this.grpInput.Controls.Add(this.cmbRotateDirection);
            this.grpInput.Controls.Add(this.cmbAction);
            this.grpInput.Controls.Add(this.lblAction);
            this.grpInput.Controls.Add(this.txtObject);
            this.grpInput.Controls.Add(this.btnAddAction);
            this.grpInput.Controls.Add(this.lblObject);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(297, 205);
            this.grpInput.TabIndex = 2;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(21, 177);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(29, 12);
            this.lblWait.TabIndex = 14;
            this.lblWait.Text = "Wait";
            // 
            // lblWaitUnit
            // 
            this.lblWaitUnit.AutoSize = true;
            this.lblWaitUnit.Location = new System.Drawing.Point(238, 177);
            this.lblWaitUnit.Name = "lblWaitUnit";
            this.lblWaitUnit.Size = new System.Drawing.Size(53, 12);
            this.lblWaitUnit.TabIndex = 13;
            this.lblWaitUnit.Text = "frame(s)";
            // 
            // lblRotateUnit
            // 
            this.lblRotateUnit.AutoSize = true;
            this.lblRotateUnit.Location = new System.Drawing.Point(139, 150);
            this.lblRotateUnit.Name = "lblRotateUnit";
            this.lblRotateUnit.Size = new System.Drawing.Size(89, 12);
            this.lblRotateUnit.TabIndex = 13;
            this.lblRotateUnit.Text = "degree/frame =";
            // 
            // lblMoveUnit
            // 
            this.lblMoveUnit.AutoSize = true;
            this.lblMoveUnit.Location = new System.Drawing.Point(145, 97);
            this.lblMoveUnit.Name = "lblMoveUnit";
            this.lblMoveUnit.Size = new System.Drawing.Size(83, 12);
            this.lblMoveUnit.TabIndex = 13;
            this.lblMoveUnit.Text = "pixel/frame =";
            // 
            // cmbMoveDirection
            // 
            this.cmbMoveDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveDirection.FormattingEnabled = true;
            this.cmbMoveDirection.Items.AddRange(new object[] {
            "Left",
            "Up",
            "Right",
            "Down"});
            this.cmbMoveDirection.Location = new System.Drawing.Point(74, 68);
            this.cmbMoveDirection.Name = "cmbMoveDirection";
            this.cmbMoveDirection.Size = new System.Drawing.Size(116, 20);
            this.cmbMoveDirection.TabIndex = 12;
            // 
            // txtRotateSpeed
            // 
            this.txtRotateSpeed.Location = new System.Drawing.Point(74, 147);
            this.txtRotateSpeed.Name = "txtRotateSpeed";
            this.txtRotateSpeed.Size = new System.Drawing.Size(59, 21);
            this.txtRotateSpeed.TabIndex = 11;
            // 
            // lblRotateSpeed
            // 
            this.lblRotateSpeed.AutoSize = true;
            this.lblRotateSpeed.Location = new System.Drawing.Point(234, 150);
            this.lblRotateSpeed.Name = "lblRotateSpeed";
            this.lblRotateSpeed.Size = new System.Drawing.Size(53, 12);
            this.lblRotateSpeed.TabIndex = 10;
            this.lblRotateSpeed.Text = "0.0 °/s";
            // 
            // txtMoveSpeed
            // 
            this.txtMoveSpeed.Location = new System.Drawing.Point(74, 94);
            this.txtMoveSpeed.Name = "txtMoveSpeed";
            this.txtMoveSpeed.Size = new System.Drawing.Size(59, 21);
            this.txtMoveSpeed.TabIndex = 11;
            // 
            // lblMoveSpeed
            // 
            this.lblMoveSpeed.AutoSize = true;
            this.lblMoveSpeed.Location = new System.Drawing.Point(234, 97);
            this.lblMoveSpeed.Name = "lblMoveSpeed";
            this.lblMoveSpeed.Size = new System.Drawing.Size(47, 12);
            this.lblMoveSpeed.TabIndex = 10;
            this.lblMoveSpeed.Text = "0.0 m/s";
            // 
            // txtWaitPeriod
            // 
            this.txtWaitPeriod.Location = new System.Drawing.Point(74, 174);
            this.txtWaitPeriod.Name = "txtWaitPeriod";
            this.txtWaitPeriod.Size = new System.Drawing.Size(158, 21);
            this.txtWaitPeriod.TabIndex = 9;
            // 
            // txtRotateAngle
            // 
            this.txtRotateAngle.Location = new System.Drawing.Point(196, 121);
            this.txtRotateAngle.Name = "txtRotateAngle";
            this.txtRotateAngle.Size = new System.Drawing.Size(95, 21);
            this.txtRotateAngle.TabIndex = 9;
            // 
            // txtMoveDistance
            // 
            this.txtMoveDistance.Location = new System.Drawing.Point(196, 68);
            this.txtMoveDistance.Name = "txtMoveDistance";
            this.txtMoveDistance.Size = new System.Drawing.Size(95, 21);
            this.txtMoveDistance.TabIndex = 9;
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(21, 71);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(35, 12);
            this.lblMove.TabIndex = 8;
            this.lblMove.Text = "Move:";
            // 
            // lblRotate
            // 
            this.lblRotate.AutoSize = true;
            this.lblRotate.Location = new System.Drawing.Point(21, 124);
            this.lblRotate.Name = "lblRotate";
            this.lblRotate.Size = new System.Drawing.Size(47, 12);
            this.lblRotate.TabIndex = 7;
            this.lblRotate.Text = "Rotate:";
            // 
            // cmbRotateDirection
            // 
            this.cmbRotateDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRotateDirection.FormattingEnabled = true;
            this.cmbRotateDirection.Items.AddRange(new object[] {
            "Left (counter clockwise)",
            "Right (clockwise)"});
            this.cmbRotateDirection.Location = new System.Drawing.Point(74, 121);
            this.cmbRotateDirection.Name = "cmbRotateDirection";
            this.cmbRotateDirection.Size = new System.Drawing.Size(116, 20);
            this.cmbRotateDirection.TabIndex = 6;
            // 
            // cmbAction
            // 
            this.cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAction.FormattingEnabled = true;
            this.cmbAction.Items.AddRange(new object[] {
            "Move",
            "Rotate"});
            this.cmbAction.Location = new System.Drawing.Point(74, 42);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(116, 20);
            this.cmbAction.TabIndex = 5;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(6, 45);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(47, 12);
            this.lblAction.TabIndex = 4;
            this.lblAction.Text = "Action:";
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(74, 14);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(116, 21);
            this.txtObject.TabIndex = 3;
            // 
            // btnAddAction
            // 
            this.btnAddAction.Location = new System.Drawing.Point(196, 14);
            this.btnAddAction.Name = "btnAddAction";
            this.btnAddAction.Size = new System.Drawing.Size(95, 48);
            this.btnAddAction.TabIndex = 2;
            this.btnAddAction.Text = "Add action";
            this.btnAddAction.UseVisualStyleBackColor = true;
            // 
            // lstAction
            // 
            this.lstAction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhFrame});
            this.lstAction.FullRowSelect = true;
            this.lstAction.GridLines = true;
            this.lstAction.Location = new System.Drawing.Point(12, 223);
            this.lstAction.Name = "lstAction";
            this.lstAction.Size = new System.Drawing.Size(667, 241);
            this.lstAction.TabIndex = 3;
            this.lstAction.UseCompatibleStateImageBehavior = false;
            this.lstAction.View = System.Windows.Forms.View.Details;
            // 
            // clhFrame
            // 
            this.clhFrame.Text = "Frame";
            this.clhFrame.Width = 45;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(123, 467);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(467, 12);
            this.lblLicense.TabIndex = 4;
            this.lblLicense.Text = "Under Apache License 2.0 Github: https://github.com/metesa/MAXScriptGenerator";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 488);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lstAction);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.txtScript);
            this.Name = "frmMain";
            this.Text = "MaxScript Generator";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.ComboBox cmbAction;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.Button btnAddAction;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Label lblRotate;
        private System.Windows.Forms.ComboBox cmbRotateDirection;
        private System.Windows.Forms.ComboBox cmbMoveDirection;
        private System.Windows.Forms.TextBox txtMoveSpeed;
        private System.Windows.Forms.Label lblMoveSpeed;
        private System.Windows.Forms.TextBox txtMoveDistance;
        private System.Windows.Forms.Label lblRotateUnit;
        private System.Windows.Forms.Label lblMoveUnit;
        private System.Windows.Forms.TextBox txtRotateSpeed;
        private System.Windows.Forms.Label lblRotateSpeed;
        private System.Windows.Forms.TextBox txtRotateAngle;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.Label lblWaitUnit;
        private System.Windows.Forms.TextBox txtWaitPeriod;
        private System.Windows.Forms.ListView lstAction;
        private System.Windows.Forms.ColumnHeader clhFrame;
        private System.Windows.Forms.Label lblLicense;
    }
}

