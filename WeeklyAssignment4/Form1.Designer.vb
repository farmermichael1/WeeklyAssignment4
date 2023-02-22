<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abnbReservation
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
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.lbNights = New System.Windows.Forms.Label()
        Me.lbCostlabel = New System.Windows.Forms.Label()
        Me.lbCost = New System.Windows.Forms.Label()
        Me.airBnB = New System.Windows.Forms.PictureBox()
        CType(Me.airBnB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCost
        '
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(412, 337)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(95, 36)
        Me.btnCost.TabIndex = 0
        Me.btnCost.Text = "Display Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(544, 337)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 36)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(671, 337)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 36)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNights
        '
        Me.txtNights.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNights.Location = New System.Drawing.Point(644, 123)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(52, 28)
        Me.txtNights.TabIndex = 3
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("Coolsville", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(449, 18)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(288, 42)
        Me.lbTitle.TabIndex = 4
        Me.lbTitle.Text = "Orlando AirBnB"
        '
        'lbPrice
        '
        Me.lbPrice.AutoSize = True
        Me.lbPrice.Font = New System.Drawing.Font("Coolsville", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrice.Location = New System.Drawing.Point(493, 60)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(203, 23)
        Me.lbPrice.TabIndex = 5
        Me.lbPrice.Text = "Only $79.00 per night"
        '
        'lbNights
        '
        Me.lbNights.AutoSize = True
        Me.lbNights.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbNights.Location = New System.Drawing.Point(419, 123)
        Me.lbNights.Name = "lbNights"
        Me.lbNights.Size = New System.Drawing.Size(164, 22)
        Me.lbNights.TabIndex = 6
        Me.lbNights.Text = "Number of Nights:"
        '
        'lbCostlabel
        '
        Me.lbCostlabel.AutoSize = True
        Me.lbCostlabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCostlabel.Location = New System.Drawing.Point(419, 199)
        Me.lbCostlabel.Name = "lbCostlabel"
        Me.lbCostlabel.Size = New System.Drawing.Size(114, 22)
        Me.lbCostlabel.TabIndex = 7
        Me.lbCostlabel.Text = "Cost of Stay:"
        '
        'lbCost
        '
        Me.lbCost.AutoSize = True
        Me.lbCost.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCost.Location = New System.Drawing.Point(640, 199)
        Me.lbCost.Name = "lbCost"
        Me.lbCost.Size = New System.Drawing.Size(44, 22)
        Me.lbCost.TabIndex = 8
        Me.lbCost.Text = "cost"
        '
        'airBnB
        '
        Me.airBnB.Image = Global.WeeklyAssignment4.My.Resources.Resources.airbnb
        Me.airBnB.Location = New System.Drawing.Point(12, 3)
        Me.airBnB.Name = "airBnB"
        Me.airBnB.Size = New System.Drawing.Size(365, 445)
        Me.airBnB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.airBnB.TabIndex = 9
        Me.airBnB.TabStop = False
        '
        'abnbReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.airBnB)
        Me.Controls.Add(Me.lbCost)
        Me.Controls.Add(Me.lbCostlabel)
        Me.Controls.Add(Me.lbNights)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Name = "abnbReservation"
        Me.Text = "AirBnB Reservations"
        CType(Me.airBnB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNights As TextBox
    Friend WithEvents lbTitle As Label
    Friend WithEvents lbPrice As Label
    Friend WithEvents lbNights As Label
    Friend WithEvents lbCostlabel As Label
    Friend WithEvents lbCost As Label
    Friend WithEvents airBnB As PictureBox
End Class
