﻿namespace Trabalho.View
{
    partial class FrmConsMedicoHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsMedicoHorario));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSelecionar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.DgvMedicoHorario = new System.Windows.Forms.DataGridView();
            this.CbbMedico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicoHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medico";
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Location = new System.Drawing.Point(685, 31);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.BtnSelecionar.TabIndex = 7;
            this.BtnSelecionar.Text = "Selecionar";
            this.BtnSelecionar.UseVisualStyleBackColor = true;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(604, 31);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 6;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // DgvMedicoHorario
            // 
            this.DgvMedicoHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMedicoHorario.Location = new System.Drawing.Point(1, 89);
            this.DgvMedicoHorario.Name = "DgvMedicoHorario";
            this.DgvMedicoHorario.Size = new System.Drawing.Size(798, 361);
            this.DgvMedicoHorario.TabIndex = 10;
            // 
            // CbbMedico
            // 
            this.CbbMedico.FormattingEnabled = true;
            this.CbbMedico.Location = new System.Drawing.Point(82, 28);
            this.CbbMedico.Name = "CbbMedico";
            this.CbbMedico.Size = new System.Drawing.Size(166, 21);
            this.CbbMedico.TabIndex = 11;
            // 
            // FrmConsMedicoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbbMedico);
            this.Controls.Add(this.DgvMedicoHorario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSelecionar);
            this.Controls.Add(this.BtnPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsMedicoHorario";
            this.Text = "FrmConsMedicoHorario";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicoHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelecionar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.DataGridView DgvMedicoHorario;
        private System.Windows.Forms.ComboBox CbbMedico;
    }
}