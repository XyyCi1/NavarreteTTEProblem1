<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBoxName = New TextBox()
        TextBoxOrigin = New TextBox()
        TextBoxYRDisc = New TextBox()
        ComboBoxCondition = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ButtonSave = New Button()
        ButtonUpdate = New Button()
        ButtonDelete = New Button()
        ButtonLoad = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(42, 57)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(100, 23)
        TextBoxName.TabIndex = 0
        ' 
        ' TextBoxOrigin
        ' 
        TextBoxOrigin.Location = New Point(160, 57)
        TextBoxOrigin.Name = "TextBoxOrigin"
        TextBoxOrigin.Size = New Size(100, 23)
        TextBoxOrigin.TabIndex = 0
        ' 
        ' TextBoxYRDisc
        ' 
        TextBoxYRDisc.Location = New Point(278, 57)
        TextBoxYRDisc.Name = "TextBoxYRDisc"
        TextBoxYRDisc.Size = New Size(100, 23)
        TextBoxYRDisc.TabIndex = 0
        ' 
        ' ComboBoxCondition
        ' 
        ComboBoxCondition.FormattingEnabled = True
        ComboBoxCondition.Items.AddRange(New Object() {"Excellent", "Good", "Fair", "Poor"})
        ComboBoxCondition.Location = New Point(413, 57)
        ComboBoxCondition.Name = "ComboBoxCondition"
        ComboBoxCondition.Size = New Size(121, 23)
        ComboBoxCondition.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 2
        Label1.Text = "Artifact Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(160, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 2
        Label2.Text = "Origin Country"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(278, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 15)
        Label3.TabIndex = 2
        Label3.Text = "Year Discovered:"
        ' 
        ' ButtonSave
        ' 
        ButtonSave.Location = New Point(67, 115)
        ButtonSave.Name = "ButtonSave"
        ButtonSave.Size = New Size(75, 23)
        ButtonSave.TabIndex = 3
        ButtonSave.Text = "Save"
        ButtonSave.UseVisualStyleBackColor = True
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.Location = New Point(171, 115)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Size = New Size(75, 23)
        ButtonUpdate.TabIndex = 3
        ButtonUpdate.Text = "Update"
        ButtonUpdate.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Location = New Point(278, 115)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(75, 23)
        ButtonDelete.TabIndex = 3
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonLoad
        ' 
        ButtonLoad.Location = New Point(377, 115)
        ButtonLoad.Name = "ButtonLoad"
        ButtonLoad.Size = New Size(75, 23)
        ButtonLoad.TabIndex = 3
        ButtonLoad.Text = "Load"
        ButtonLoad.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(56, 195)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(538, 181)
        DataGridView1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(ButtonLoad)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonUpdate)
        Controls.Add(ButtonSave)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboBoxCondition)
        Controls.Add(TextBoxYRDisc)
        Controls.Add(TextBoxOrigin)
        Controls.Add(TextBoxName)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxOrigin As TextBox
    Friend WithEvents TextBoxYRDisc As TextBox
    Friend WithEvents ComboBoxCondition As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonLoad As Button
    Friend WithEvents DataGridView1 As DataGridView

End Class
