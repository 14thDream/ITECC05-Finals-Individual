<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmployees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmployees))
        ButtonSignOut = New Button()
        PanelEmployeeData = New Panel()
        Label6 = New Label()
        DateTimePickerBirthDate = New DateTimePicker()
        Label5 = New Label()
        RadioButtonFemale = New RadioButton()
        RadioButtonMale = New RadioButton()
        ButtonDelete = New Button()
        ButtonUpdate = New Button()
        ButtonSave = New Button()
        TextBox_Age = New TextBox()
        TextBox_Surname = New TextBox()
        TextBox_FirstName = New TextBox()
        TextBox_Id = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ComboBoxEmployees = New ComboBox()
        DataGridViewEmployees = New DataGridView()
        ButtonLoadTable = New Button()
        ListBoxEmployees = New ListBox()
        TextBoxSearch = New TextBox()
        ChartNameVsAge = New DataVisualization.Charting.Chart()
        ButtonLoadChart = New Button()
        PanelEmployeeData.SuspendLayout()
        CType(DataGridViewEmployees, ComponentModel.ISupportInitialize).BeginInit()
        CType(ChartNameVsAge, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonSignOut
        ' 
        ButtonSignOut.AutoSize = True
        ButtonSignOut.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSignOut.Location = New Point(72, 12)
        ButtonSignOut.Name = "ButtonSignOut"
        ButtonSignOut.Size = New Size(113, 35)
        ButtonSignOut.TabIndex = 1
        ButtonSignOut.Text = "Sign Out"
        ButtonSignOut.UseVisualStyleBackColor = True
        ' 
        ' PanelEmployeeData
        ' 
        PanelEmployeeData.AutoSize = True
        PanelEmployeeData.Controls.Add(Label6)
        PanelEmployeeData.Controls.Add(DateTimePickerBirthDate)
        PanelEmployeeData.Controls.Add(Label5)
        PanelEmployeeData.Controls.Add(RadioButtonFemale)
        PanelEmployeeData.Controls.Add(RadioButtonMale)
        PanelEmployeeData.Controls.Add(ButtonDelete)
        PanelEmployeeData.Controls.Add(ButtonUpdate)
        PanelEmployeeData.Controls.Add(ButtonSave)
        PanelEmployeeData.Controls.Add(TextBox_Age)
        PanelEmployeeData.Controls.Add(TextBox_Surname)
        PanelEmployeeData.Controls.Add(TextBox_FirstName)
        PanelEmployeeData.Controls.Add(TextBox_Id)
        PanelEmployeeData.Controls.Add(Label4)
        PanelEmployeeData.Controls.Add(Label3)
        PanelEmployeeData.Controls.Add(Label2)
        PanelEmployeeData.Controls.Add(Label1)
        PanelEmployeeData.Location = New Point(24, 63)
        PanelEmployeeData.Name = "PanelEmployeeData"
        PanelEmployeeData.Size = New Size(209, 262)
        PanelEmployeeData.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 159)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 15)
        Label6.TabIndex = 14
        Label6.Text = "Birth Date"
        ' 
        ' DateTimePickerBirthDate
        ' 
        DateTimePickerBirthDate.CustomFormat = "yyyy-MM-dd"
        DateTimePickerBirthDate.Format = DateTimePickerFormat.Custom
        DateTimePickerBirthDate.Location = New Point(82, 153)
        DateTimePickerBirthDate.Name = "DateTimePickerBirthDate"
        DateTimePickerBirthDate.Size = New Size(115, 23)
        DateTimePickerBirthDate.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 126)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 16
        Label5.Text = "Gender"
        ' 
        ' RadioButtonFemale
        ' 
        RadioButtonFemale.AutoSize = True
        RadioButtonFemale.Location = New Point(134, 124)
        RadioButtonFemale.Name = "RadioButtonFemale"
        RadioButtonFemale.Size = New Size(63, 19)
        RadioButtonFemale.TabIndex = 15
        RadioButtonFemale.TabStop = True
        RadioButtonFemale.Text = "Female"
        RadioButtonFemale.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonMale
        ' 
        RadioButtonMale.AutoSize = True
        RadioButtonMale.Location = New Point(82, 124)
        RadioButtonMale.Name = "RadioButtonMale"
        RadioButtonMale.Size = New Size(51, 19)
        RadioButtonMale.TabIndex = 14
        RadioButtonMale.TabStop = True
        RadioButtonMale.Text = "Male"
        RadioButtonMale.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.AutoSize = True
        ButtonDelete.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonDelete.Location = New Point(51, 224)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(97, 35)
        ButtonDelete.TabIndex = 10
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.AutoSize = True
        ButtonUpdate.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonUpdate.Location = New Point(100, 186)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Size = New Size(97, 35)
        ButtonUpdate.TabIndex = 9
        ButtonUpdate.Text = "Update"
        ButtonUpdate.UseVisualStyleBackColor = True
        ' 
        ' ButtonSave
        ' 
        ButtonSave.AutoSize = True
        ButtonSave.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSave.Location = New Point(3, 186)
        ButtonSave.Name = "ButtonSave"
        ButtonSave.Size = New Size(97, 35)
        ButtonSave.TabIndex = 8
        ButtonSave.Text = "Save"
        ButtonSave.UseVisualStyleBackColor = True
        ' 
        ' TextBox_Age
        ' 
        TextBox_Age.Location = New Point(82, 93)
        TextBox_Age.Name = "TextBox_Age"
        TextBox_Age.Size = New Size(115, 23)
        TextBox_Age.TabIndex = 7
        ' 
        ' TextBox_Surname
        ' 
        TextBox_Surname.Location = New Point(82, 63)
        TextBox_Surname.Name = "TextBox_Surname"
        TextBox_Surname.Size = New Size(115, 23)
        TextBox_Surname.TabIndex = 6
        ' 
        ' TextBox_FirstName
        ' 
        TextBox_FirstName.Location = New Point(82, 33)
        TextBox_FirstName.Name = "TextBox_FirstName"
        TextBox_FirstName.Size = New Size(115, 23)
        TextBox_FirstName.TabIndex = 5
        ' 
        ' TextBox_Id
        ' 
        TextBox_Id.Location = New Point(82, 3)
        TextBox_Id.Name = "TextBox_Id"
        TextBox_Id.Size = New Size(115, 23)
        TextBox_Id.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 3
        Label4.Text = "Age"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 2
        Label3.Text = "Surname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 1
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 15)
        Label1.TabIndex = 0
        Label1.Text = "Id"
        ' 
        ' ComboBoxEmployees
        ' 
        ComboBoxEmployees.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxEmployees.FormattingEnabled = True
        ComboBoxEmployees.Location = New Point(263, 12)
        ComboBoxEmployees.Name = "ComboBoxEmployees"
        ComboBoxEmployees.Size = New Size(200, 33)
        ComboBoxEmployees.TabIndex = 3
        ' 
        ' DataGridViewEmployees
        ' 
        DataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewEmployees.Location = New Point(263, 63)
        DataGridViewEmployees.Name = "DataGridViewEmployees"
        DataGridViewEmployees.Size = New Size(473, 202)
        DataGridViewEmployees.TabIndex = 4
        ' 
        ' ButtonLoadTable
        ' 
        ButtonLoadTable.AutoSize = True
        ButtonLoadTable.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonLoadTable.Location = New Point(263, 286)
        ButtonLoadTable.Name = "ButtonLoadTable"
        ButtonLoadTable.Size = New Size(140, 35)
        ButtonLoadTable.TabIndex = 11
        ButtonLoadTable.Text = "Load Table"
        ButtonLoadTable.UseVisualStyleBackColor = True
        ' 
        ' ListBoxEmployees
        ' 
        ListBoxEmployees.ItemHeight = 15
        ListBoxEmployees.Location = New Point(536, 12)
        ListBoxEmployees.Name = "ListBoxEmployees"
        ListBoxEmployees.Size = New Size(200, 34)
        ListBoxEmployees.TabIndex = 0
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBoxSearch.Location = New Point(439, 288)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.Size = New Size(297, 31)
        TextBoxSearch.TabIndex = 12
        ' 
        ' ChartNameVsAge
        ' 
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.AxisX.LabelStyle.Angle = -90
        ChartArea2.AxisX.LabelStyle.Interval = 1.0R
        ChartArea2.Name = "ChartArea1"
        ChartNameVsAge.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        ChartNameVsAge.Legends.Add(Legend2)
        ChartNameVsAge.Location = New Point(263, 342)
        ChartNameVsAge.Name = "ChartNameVsAge"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "NAME_VS_AGE"
        Series2.XValueType = DataVisualization.Charting.ChartValueType.Double
        ChartNameVsAge.Series.Add(Series2)
        ChartNameVsAge.Size = New Size(473, 202)
        ChartNameVsAge.TabIndex = 13
        ChartNameVsAge.Text = "Chart1"
        ' 
        ' ButtonLoadChart
        ' 
        ButtonLoadChart.AutoSize = True
        ButtonLoadChart.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonLoadChart.Location = New Point(60, 427)
        ButtonLoadChart.Name = "ButtonLoadChart"
        ButtonLoadChart.Size = New Size(138, 35)
        ButtonLoadChart.TabIndex = 11
        ButtonLoadChart.Text = "Load Chart"
        ButtonLoadChart.UseVisualStyleBackColor = True
        ' 
        ' FormEmployees
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 564)
        Controls.Add(ButtonLoadChart)
        Controls.Add(ChartNameVsAge)
        Controls.Add(TextBoxSearch)
        Controls.Add(ListBoxEmployees)
        Controls.Add(ButtonLoadTable)
        Controls.Add(DataGridViewEmployees)
        Controls.Add(ComboBoxEmployees)
        Controls.Add(PanelEmployeeData)
        Controls.Add(ButtonSignOut)
        Name = "FormEmployees"
        Text = "Employees"
        PanelEmployeeData.ResumeLayout(False)
        PanelEmployeeData.PerformLayout()
        CType(DataGridViewEmployees, ComponentModel.ISupportInitialize).EndInit()
        CType(ChartNameVsAge, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ButtonSignOut As Button
    Friend WithEvents PanelEmployeeData As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_FirstName As TextBox
    Friend WithEvents TextBox_Id As TextBox
    Friend WithEvents TextBox_Age As TextBox
    Friend WithEvents TextBox_Surname As TextBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ComboBoxEmployees As ComboBox
    Friend WithEvents DataGridViewEmployees As DataGridView
    Friend WithEvents ButtonLoadTable As Button
    Friend WithEvents ListBoxEmployees As ListBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ChartNameVsAge As DataVisualization.Charting.Chart
    Friend WithEvents ButtonLoadChart As Button
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerBirthDate As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
