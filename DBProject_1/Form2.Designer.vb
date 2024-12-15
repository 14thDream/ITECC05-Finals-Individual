<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Button1 = New Button()
        Panel1 = New Panel()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        RadioButtonFemale = New RadioButton()
        RadioButtonMale = New RadioButton()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        TextBox_Age = New TextBox()
        TextBox_Surname = New TextBox()
        TextBox_FirstName = New TextBox()
        TextBox_Id = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        ButtonLoadTable = New Button()
        ListBox1 = New ListBox()
        TextBoxSearch = New TextBox()
        Chart1 = New DataVisualization.Charting.Chart()
        ButtonLoadChart = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(72, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 35)
        Button1.TabIndex = 1
        Button1.Text = "Sign Out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(RadioButtonFemale)
        Panel1.Controls.Add(RadioButtonMale)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TextBox_Age)
        Panel1.Controls.Add(TextBox_Surname)
        Panel1.Controls.Add(TextBox_FirstName)
        Panel1.Controls.Add(TextBox_Id)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(24, 63)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(209, 262)
        Panel1.TabIndex = 2
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
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(82, 153)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(115, 23)
        DateTimePicker1.TabIndex = 17
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
        ' Button4
        ' 
        Button4.AutoSize = True
        Button4.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(51, 224)
        Button4.Name = "Button4"
        Button4.Size = New Size(97, 35)
        Button4.TabIndex = 10
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(100, 186)
        Button3.Name = "Button3"
        Button3.Size = New Size(97, 35)
        Button3.TabIndex = 9
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(3, 186)
        Button2.Name = "Button2"
        Button2.Size = New Size(97, 35)
        Button2.TabIndex = 8
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = True
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
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(263, 12)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(200, 33)
        ComboBox1.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(263, 63)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(473, 202)
        DataGridView1.TabIndex = 4
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
        ' ListBox1
        ' 
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(536, 12)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(200, 34)
        ListBox1.TabIndex = 0
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBoxSearch.Location = New Point(439, 288)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.Size = New Size(297, 31)
        TextBoxSearch.TabIndex = 12
        ' 
        ' Chart1
        ' 
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.LabelStyle.Angle = -90
        ChartArea1.AxisX.LabelStyle.Interval = 1.0R
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(263, 342)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "NAME_VS_AGE"
        Series1.XValueType = DataVisualization.Charting.ChartValueType.Double
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(473, 202)
        Chart1.TabIndex = 13
        Chart1.Text = "Chart1"
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
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 564)
        Controls.Add(ButtonLoadChart)
        Controls.Add(Chart1)
        Controls.Add(TextBoxSearch)
        Controls.Add(ListBox1)
        Controls.Add(ButtonLoadTable)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox1)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_FirstName As TextBox
    Friend WithEvents TextBox_Id As TextBox
    Friend WithEvents TextBox_Age As TextBox
    Friend WithEvents TextBox_Surname As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonLoadTable As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents ButtonLoadChart As Button
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
