   M S B A M L   `   `   `  ����A  =deneme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:denemedeneme  5          deneme.RoleView   5      a ]DevExpress.Xpf.Core.v23.1, Version=23.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:deneme     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5      � $��10q�6   .+�5   
   �� $��Roles��5      $��28(�5      ���#DADADA5      �� 5   
   $��70��5      $��30��5      $��	0,119,0,0q�5        �� Padding$  5,1,5,0q�5      $
��Left=�5      $	��Top=�5      
������� �� CornerRadius$ 10��5      ._�5      �� $��Name :��5      $��12(�5      ���#1C2F465      5      �� 5!   
   -   5         ��Name$ txtId��5"      $��40,148,502,430q�5#      $��0��5$      $y�Hidden=�5%      �� 5'   
   $	��120��5(      $��30��5)      $��
85,119,0,0q�5*      $  5,7,5,0q�5+      $
��Left=�5,      $	��Top=�5-      
�������$ 10��5/      ._�50      �� -   5        $ txtName��51      $	��110��52      $��20��53      $
��Left=�54      $	��Top=�55       K� ZIndex$	 999��56      
�������$��0q�58      $��/Fonts/#Rubik Medium)�59      $��12(�5:      ���#1C2F465;      5<      �� 5>   
   $	��120��5?      $��30��5@      $��220,119,0,0q�5A      $  10,5,5,0q�5B      $
��Left=�5C      $	��Top=�5D      
��� � �$ 10��5F      ._�5G      �� -   5         ��Name$ btnSave��5H      $	��100��5I      $
��Left=�5J      $	��Top=�5K      
������ $��0q�5M      $
��Save��5O      
���������5Q      �� 5R       �� 
TargetType" ��6    �� Triggers 5S      P� 5T       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5U   "   �� 	 �� Property	 � ��
 �� Value

 ���� 6?   5V      5X      5Z      5[      �� 5]   
   $��1��5^      $��
5,200,5,10q�5_      $  10q�5`      
�������$ 10��5b      ._�5c      &   System.Windows.Controls.DataGrid  <my-http://schemas.microsoft.com/wpf/2008/toolkit     5d      -   5          Name$ dg��5e      $	��500��5f         AutoGenerateColumns$ False��5g      
�������$��0q�5i         CanUserAddRows$ False��5j         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5k         GridLinesVisibility$
 None=�5l         HeadersVisibility$ Column=�5m         RowHeaderWidth$ 0Q�5o      $
��Auto=�5p      ��5n      �� *Roles+   ColumnHeaderStyle 5q      �� 5r      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5s      �� 	 � ��
 �	#FF00000067   �� 5t      	 � ��

 �����67   �� 5u      	 � ��$
 10,10,10,10q�64   �� 5v      	 � ��$
 
Montserrat)�67   �� 5w      	 � ��$
 15(�65   5x         RowStyle 5z      �� 5{      )  #System.Windows.Controls.DataGridRow"  6   .�5|      �� 	 � ��

 ���� 67   �� 5}      	 � ��$
 	10,2,0,10q�63   �� 5      	 � ��
 �#121F2C67    5�      P� 5�       �@ 
IsSelected$
 True��6<   . �5�   "   �� 	 � ��

 ���� 6?   �� 5�   "   	 � ��

 �����6?   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6E   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ��  �� Path$ Id�6E     5�      $ 
First name��6G    6)   �� $
 Name�6G   4  .System.Windows.Controls.DataGridTemplateColumn  5�         CellTemplate 5�      �� 5�      .R�5�   "   �� -   5        $��60��5�   %   
���  ��$��0q�5�   %   $��Delete��5�   %   
�������5�   %   5�      5�        5�       5�      �� 5�      .R�5�   "   �� -   5        $��60��5�   %   
����  �$��0q�5�   %   $
��Edit��5�   %   
�������5�   %   5�      5�      5�      5�      5�      5�      