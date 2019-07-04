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
        Me.components = New System.ComponentModel.Container()
        Dim ArcScaleRange10 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim ArcScaleRange11 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim ArcScaleRange12 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.circularGauge11 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.ArcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.ArcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.cGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.ArcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.ArcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleSpindleCapComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.circularGauge11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleSpindleCapComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Control Maju"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(344, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Control Mundur"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(344, 237)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Control Kiri"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(344, 186)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Control Kanan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Control Kecepatan"
        '
        'GaugeControl2
        '
        Me.GaugeControl2.AutoLayout = False
        Me.GaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge11})
        Me.GaugeControl2.Location = New System.Drawing.Point(12, 12)
        Me.GaugeControl2.Name = "GaugeControl2"
        Me.GaugeControl2.Size = New System.Drawing.Size(259, 265)
        Me.GaugeControl2.TabIndex = 5
        '
        'circularGauge11
        '
        Me.circularGauge11.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent1})
        Me.circularGauge11.Bounds = New System.Drawing.Rectangle(5, 4, 248, 248)
        Me.circularGauge11.Name = "circularGauge11"
        Me.circularGauge11.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent1})
        Me.circularGauge11.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent1})
        Me.circularGauge11.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.ArcScaleSpindleCapComponent1})
        '
        'ArcScaleComponent1
        '
        Me.ArcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ArcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
        Me.ArcScaleComponent1.EndAngle = 60.0!
        Me.ArcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent1.MajorTickmark.ShapeOffset = -6.0!
        Me.ArcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_1
        Me.ArcScaleComponent1.MajorTickmark.TextOffset = -20.0!
        Me.ArcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent1.MaxValue = 100.0!
        Me.ArcScaleComponent1.MinorTickCount = 4
        Me.ArcScaleComponent1.MinorTickmark.ShapeOffset = -2.0!
        Me.ArcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_2
        Me.ArcScaleComponent1.Name = "scale1"
        Me.ArcScaleComponent1.RadiusX = 95.0!
        Me.ArcScaleComponent1.RadiusY = 95.0!
        ArcScaleRange10.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9EC968")
        ArcScaleRange10.EndThickness = 2.0!
        ArcScaleRange10.EndValue = 33.0!
        ArcScaleRange10.Name = "Range0"
        ArcScaleRange10.ShapeOffset = 11.5!
        ArcScaleRange10.StartThickness = 2.0!
        ArcScaleRange11.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FFDA80")
        ArcScaleRange11.EndThickness = 2.0!
        ArcScaleRange11.EndValue = 66.0!
        ArcScaleRange11.Name = "Range1"
        ArcScaleRange11.ShapeOffset = 11.5!
        ArcScaleRange11.StartThickness = 2.0!
        ArcScaleRange11.StartValue = 33.0!
        ArcScaleRange12.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E99D9D")
        ArcScaleRange12.EndThickness = 2.0!
        ArcScaleRange12.EndValue = 100.0!
        ArcScaleRange12.Name = "Range2"
        ArcScaleRange12.ShapeOffset = 11.5!
        ArcScaleRange12.StartThickness = 2.0!
        ArcScaleRange12.StartValue = 66.0!
        Me.ArcScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {ArcScaleRange10, ArcScaleRange11, ArcScaleRange12})
        Me.ArcScaleComponent1.StartAngle = -240.0!
        Me.ArcScaleComponent1.Value = 80.0!
        '
        'ArcScaleBackgroundLayerComponent1
        '
        Me.ArcScaleBackgroundLayerComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleBackgroundLayerComponent1.Name = "bg"
        Me.ArcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style25
        Me.ArcScaleBackgroundLayerComponent1.ZOrder = 1000
        '
        'ArcScaleNeedleComponent1
        '
        Me.ArcScaleNeedleComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleNeedleComponent1.EndOffset = -8.0!
        Me.ArcScaleNeedleComponent1.Name = "needle"
        Me.ArcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style25
        Me.ArcScaleNeedleComponent1.StartOffset = -21.0!
        Me.ArcScaleNeedleComponent1.ZOrder = -50
        '
        'ArcScaleSpindleCapComponent1
        '
        Me.ArcScaleSpindleCapComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleSpindleCapComponent1.Name = "circularGauge11_SpindleCap1"
        Me.ArcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style25
        Me.ArcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(15.0!, 15.0!)
        Me.ArcScaleSpindleCapComponent1.ZOrder = -100
        '
        'GaugeControl1
        '
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.cGauge1})
        Me.GaugeControl1.Location = New System.Drawing.Point(511, 12)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(260, 260)
        Me.GaugeControl1.TabIndex = 6
        '
        'cGauge1
        '
        Me.cGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent2})
        Me.cGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 248, 248)
        Me.cGauge1.Name = "cGauge1"
        Me.cGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent2})
        Me.cGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent2})
        Me.cGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.ArcScaleSpindleCapComponent2})
        '
        'ArcScaleComponent2
        '
        Me.ArcScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ArcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF")
        Me.ArcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
        Me.ArcScaleComponent2.EndAngle = 30.0!
        Me.ArcScaleComponent2.MajorTickCount = 10
        Me.ArcScaleComponent2.MajorTickmark.AllowTickOverlap = True
        Me.ArcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent2.MajorTickmark.ShapeOffset = -9.0!
        Me.ArcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_2
        Me.ArcScaleComponent2.MajorTickmark.TextOffset = -22.0!
        Me.ArcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent2.MaxValue = 180.0!
        Me.ArcScaleComponent2.MinorTickCount = 4
        Me.ArcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_1
        Me.ArcScaleComponent2.Name = "scale1"
        Me.ArcScaleComponent2.RadiusX = 91.0!
        Me.ArcScaleComponent2.RadiusY = 91.0!
        Me.ArcScaleComponent2.StartAngle = -240.0!
        '
        'ArcScaleBackgroundLayerComponent2
        '
        Me.ArcScaleBackgroundLayerComponent2.ArcScale = Me.ArcScaleComponent2
        Me.ArcScaleBackgroundLayerComponent2.Name = "bg1"
        Me.ArcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style2
        Me.ArcScaleBackgroundLayerComponent2.ZOrder = 1000
        '
        'ArcScaleNeedleComponent2
        '
        Me.ArcScaleNeedleComponent2.ArcScale = Me.ArcScaleComponent2
        Me.ArcScaleNeedleComponent2.EndOffset = -6.0!
        Me.ArcScaleNeedleComponent2.Name = "needle1"
        Me.ArcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style2
        Me.ArcScaleNeedleComponent2.StartOffset = 9.0!
        Me.ArcScaleNeedleComponent2.ZOrder = -50
        '
        'ArcScaleSpindleCapComponent2
        '
        Me.ArcScaleSpindleCapComponent2.ArcScale = Me.ArcScaleComponent2
        Me.ArcScaleSpindleCapComponent2.Name = "cap1"
        Me.ArcScaleSpindleCapComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style2
        Me.ArcScaleSpindleCapComponent2.Size = New System.Drawing.SizeF(32.0!, 32.0!)
        Me.ArcScaleSpindleCapComponent2.ZOrder = -100
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 299)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(759, 75)
        Me.TextBox1.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(12, 394)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 32)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Send"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GaugeControl1)
        Me.Controls.Add(Me.GaugeControl2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.circularGauge11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleSpindleCapComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents circularGauge11 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents ArcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents cGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents ArcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleSpindleCapComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
End Class
