using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace HMTDPTeamLibraryProject.Search_and_Sort
{
    //public class Shim : IWin32Window
    //{
    //    public Shim(System.Windows.Window owner)
    //    {
    //        // Create a WindowInteropHelper for the WPF Window
    //        interopHelper = new WindowInteropHelper(owner);
    //    }

    //    private WindowInteropHelper interopHelper;

    //    #region IWin32Window Members

    //    public IntPtr Handle
    //    {
    //        get
    //        {
    //            // Return the surrogate handle
    //            return interopHelper.Handle;
    //        }
    //    }

    //    #endregion
    //}

    //public static class WPFInteropExtensions
    //{
    //    public static DialogResult ShowDialog(
    //        this System.Windows.Forms.Form form,
    //        System.Windows.Window owner)
    //    {
    //        Shim shim = new Shim(owner);
    //        return form.ShowDialog(/*Shim*/);
    //    }
    //}

    //public class SearchCore : Search
    //{
    //    /// <summary>
    //    /// Required designer variable.
    //    /// </summary>
    //    private readonly System.ComponentModel.IContainer components = null;

    //    /// <summary>
    //    /// Clean up any resources being used.
    //    /// </summary>
    //    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing && (components != null))
    //        {
    //            components.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    #region Windows Form Designer generated code

    //    /// <summary>
    //    /// Required method for Designer support - do not modify
    //    /// the contents of this method with the code editor.
    //    /// </summary>
    //    private void InitializeComponent()
    //    {
    //        this.txtSearch = new System.Windows.Forms.TextBox();
    //        this.dgvResults = new System.Windows.Forms.DataGridView();
    //        this.lblSearch = new System.Windows.Forms.Label();
    //        ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
    //        this.SuspendLayout();
    //        // 
    //        // txtSearch
    //        // 
    //        this.txtSearch.ForeColor = System.Drawing;
    //        //this.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText;
    //        this.txtSearch.Location = new System.Drawing.Point(90, 23);
    //        this.txtSearch.Name = "txtSearch";
    //        this.txtSearch.Size = new System.Drawing.Size(232, 20);
    //        this.txtSearch.TabIndex = 1;
    //        this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
    //        // 
    //        // dgvResults
    //        // 
    //        this.dgvResults.AllowUserToOrderColumns = true;
    //        this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
    //                    | System.Windows.Forms.AnchorStyles.Left)
    //                    | System.Windows.Forms.AnchorStyles.Right)));
    //        this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
    //        this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    //        this.dgvResults.Location = new System.Drawing.Point(12, 62);
    //        this.dgvResults.Name = "dgvResults";
    //        this.dgvResults.Size = new System.Drawing.Size(728, 318);
    //        this.dgvResults.TabIndex = 2;
    //        // 
    //        // lblSearch
    //        // 
    //        this.lblSearch.AutoSize = true;
    //        this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.lblSearch.Location = new System.Drawing.Point(27, 26);
    //        this.lblSearch.Name = "lblSearch";
    //        this.lblSearch.Size = new System.Drawing.Size(47, 13);
    //        this.lblSearch.TabIndex = 3;
    //        this.lblSearch.Text = "Search";
    //        // 
    //        // Main
    //        // 
    //        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.ClientSize = new System.Drawing.Size(752, 392);
    //        this.Controls.Add(this.lblSearch);
    //        this.Controls.Add(this.dgvResults);
    //        this.Controls.Add(this.txtSearch);
    //        this.Name = "Main";
    //        this.Text = "Auto-search grid example";
    //        this.Load += new System.EventHandler(this.Main_Load);
    //        ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
    //        this.ResumeLayout(false);
    //        this.PerformLayout();

    //    }

    //    #endregion

    //    private System.Windows.Forms.TextBox txtSearch;
    //    private System.Windows.Forms.DataGridView dgvResults;
    //    private System.Windows.Forms.Label lblSearch;
    //}

}
