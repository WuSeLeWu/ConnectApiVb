﻿#ExternalChecksum("..\..\..\sil.xaml","{ff1816ec-aa5e-4d10-87f7-6f4963833460}","9F1F0C1CA9E7D116FC2B35A3BB67ED87A035E478")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports deneme
Imports DevExpress.Core
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.ConditionalFormatting
Imports DevExpress.Xpf.Core.DataSources
Imports DevExpress.Xpf.Core.Serialization
Imports DevExpress.Xpf.Core.ServerMode
Imports DevExpress.Xpf.Data
Imports DevExpress.Xpf.DXBinding
Imports FontAwesome.WPF
Imports FontAwesome.WPF.Converters
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Controls.Ribbon
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Forms.Integration
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''sil
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class sil
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\sil.xaml",104)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents MyStackPanel As System.Windows.Controls.StackPanel
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\sil.xaml",200)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnMinimize As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\sil.xaml",216)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnClose As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\sil.xaml",239)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents MainFrame As System.Windows.Controls.Frame
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/deneme;component/sil.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\sil.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            
            #ExternalSource("..\..\..\sil.xaml",13)
            AddHandler CType(target,sil).MouseLeftButtonDown, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.Window_MouseLeftButtonDown)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.MyStackPanel = CType(target,System.Windows.Controls.StackPanel)
            Return
        End If
        If (connectionId = 3) Then
            
            #ExternalSource("..\..\..\sil.xaml",115)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.ButtonHome_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 4) Then
            
            #ExternalSource("..\..\..\sil.xaml",140)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.ButtonRole_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 5) Then
            
            #ExternalSource("..\..\..\sil.xaml",162)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.ButtonEmployee_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 6) Then
            Me.btnMinimize = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\sil.xaml",203)
            AddHandler Me.btnMinimize.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnMinimize_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 7) Then
            Me.btnClose = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\sil.xaml",219)
            AddHandler Me.btnClose.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnClose_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 8) Then
            Me.MainFrame = CType(target,System.Windows.Controls.Frame)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

