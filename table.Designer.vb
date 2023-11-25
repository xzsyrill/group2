<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class table
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(table))
        Me.patientList = New System.Windows.Forms.DataGridView()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        CType(Me.patientList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patientList
        '
        Me.patientList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.patientList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.patientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.patientList.GridColor = System.Drawing.Color.Tomato
        Me.patientList.Location = New System.Drawing.Point(279, 105)
        Me.patientList.Name = "patientList"
        Me.patientList.RowHeadersWidth = 51
        Me.patientList.RowTemplate.Height = 24
        Me.patientList.Size = New System.Drawing.Size(809, 386)
        Me.patientList.TabIndex = 0
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Tomato
        Me.LinkLabel2.Location = New System.Drawing.Point(337, 541)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(74, 20)
        Me.LinkLabel2.TabIndex = 15
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Go Back"
        '
        'table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Group2_Forms.My.Resources.Resources.Appointment2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1191, 653)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.patientList)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "table"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "table"
        CType(Me.patientList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents patientList As DataGridView
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
