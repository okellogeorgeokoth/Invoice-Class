<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.partNumberLabel = New System.Windows.Forms.Label()
        Me.PartDescription = New System.Windows.Forms.Label()
        Me.quantityLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.totalPriceLabel = New System.Windows.Forms.Label()
        Me.partNumberBox = New System.Windows.Forms.TextBox()
        Me.priceBox = New System.Windows.Forms.TextBox()
        Me.quantityBox = New System.Windows.Forms.TextBox()
        Me.partDescriptionBox = New System.Windows.Forms.TextBox()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'partNumberLabel
        '
        Me.partNumberLabel.AutoSize = True
        Me.partNumberLabel.Location = New System.Drawing.Point(34, 27)
        Me.partNumberLabel.Name = "partNumberLabel"
        Me.partNumberLabel.Size = New System.Drawing.Size(73, 15)
        Me.partNumberLabel.TabIndex = 0
        Me.partNumberLabel.Text = "Part number"
        '
        'PartDescription
        '
        Me.PartDescription.AutoSize = True
        Me.PartDescription.Location = New System.Drawing.Point(34, 81)
        Me.PartDescription.Name = "PartDescription"
        Me.PartDescription.Size = New System.Drawing.Size(90, 15)
        Me.PartDescription.TabIndex = 1
        Me.PartDescription.Text = "Part description"
        '
        'quantityLabel
        '
        Me.quantityLabel.AutoSize = True
        Me.quantityLabel.Location = New System.Drawing.Point(34, 147)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(111, 15)
        Me.quantityLabel.TabIndex = 2
        Me.quantityLabel.Text = "Quantity purchased"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(34, 226)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(85, 15)
        Me.priceLabel.TabIndex = 3
        Me.priceLabel.Text = "Price per items"
        '
        'totalPriceLabel
        '
        Me.totalPriceLabel.AutoSize = True
        Me.totalPriceLabel.Location = New System.Drawing.Point(34, 305)
        Me.totalPriceLabel.Name = "totalPriceLabel"
        Me.totalPriceLabel.Size = New System.Drawing.Size(61, 15)
        Me.totalPriceLabel.TabIndex = 4
        Me.totalPriceLabel.Text = "Total price"
        '
        'partNumberBox
        '
        Me.partNumberBox.Location = New System.Drawing.Point(166, 27)
        Me.partNumberBox.Name = "partNumberBox"
        Me.partNumberBox.Size = New System.Drawing.Size(116, 23)
        Me.partNumberBox.TabIndex = 5
        '
        'priceBox
        '
        Me.priceBox.Location = New System.Drawing.Point(166, 218)
        Me.priceBox.Name = "priceBox"
        Me.priceBox.Size = New System.Drawing.Size(116, 23)
        Me.priceBox.TabIndex = 6
        '
        'quantityBox
        '
        Me.quantityBox.Location = New System.Drawing.Point(166, 147)
        Me.quantityBox.Name = "quantityBox"
        Me.quantityBox.Size = New System.Drawing.Size(116, 23)
        Me.quantityBox.TabIndex = 7
        '
        'partDescriptionBox
        '
        Me.partDescriptionBox.Location = New System.Drawing.Point(166, 77)
        Me.partDescriptionBox.Name = "partDescriptionBox"
        Me.partDescriptionBox.Size = New System.Drawing.Size(116, 23)
        Me.partDescriptionBox.TabIndex = 8
        '
        'resultLabel
        '
        Me.resultLabel.AutoSize = True
        Me.resultLabel.Location = New System.Drawing.Point(162, 305)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(0, 15)
        Me.resultLabel.TabIndex = 9
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(310, 24)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(87, 27)
        Me.calculateButton.TabIndex = 10
        Me.calculateButton.Text = "Calculate "
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 361)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.partDescriptionBox)
        Me.Controls.Add(Me.quantityBox)
        Me.Controls.Add(Me.priceBox)
        Me.Controls.Add(Me.partNumberBox)
        Me.Controls.Add(Me.totalPriceLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.quantityLabel)
        Me.Controls.Add(Me.PartDescription)
        Me.Controls.Add(Me.partNumberLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Invoice Class"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents partNumberLabel As Label
    Friend WithEvents PartDescription As Label
    Friend WithEvents quantityLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents totalPriceLabel As Label
    Friend WithEvents partNumberBox As TextBox
    Friend WithEvents priceBox As TextBox
    Friend WithEvents quantityBox As TextBox
    Friend WithEvents partDescriptionBox As TextBox
    Friend WithEvents resultLabel As Label
    Friend WithEvents calculateButton As Button
End Class
