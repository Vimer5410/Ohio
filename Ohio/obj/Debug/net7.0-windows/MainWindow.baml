   M S B A M L   `   `   `  ����?  ;Ohio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFTestDesignWPFTestDesign  5   	       WPFTestDesign.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   'localclr-namespace:WPFTestDesign  5   	   -   5          �Name$
  Main��5   	    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � AllowsTransparency$
 True��5   	   
������  � Title$
 Ohio��5   	   $	��450��6   $	��800��6#   .��5      �� -   5        ���#1E1E1E._�5   
   � -   5         �Name$ MainBox��5       � ColumnDefinitions 5      �� 5      $	��140 �6#   61   �� 5      $	��660 �6#   61    � RowDefinitions 5      �� 5      $��40 �6    6.   �� 5      $	��410 �6    6/   .+�5      �� -   5         ��Name$ NameBox��5      $��0��6+   $��0��6;   ���#2a2a2a.+�5!      �� $��Center=�6   $��0,10,0,0q�69   $��Center=�6K   $��Arial Black)�6f   $
��Ohio��6   $��27(�6�   ��5"      �� 5#      .��5$      � 	 � Color$
	 Cyan��6+   
 � Offset$
 0Q�68   � 5%      $	 #971cc9��6+   $
 1Q�6;   5&      5(      5)      �� 5-      -   5        $ 
ButtonsBox��5-      $��0��6.   $��1��6>   ���#2a2a2a.+�5.      �� -   5         ��Name$ NotesButton��5.      $��
10,30,10,0q�6I   $��notes��6]   ���#606060���#6060606�   �� 5/      -   5        $ SettingsButton��5/      $��
10,10,10,0q�6N   $��settings��6b   ���#606060���#6060606�   �� 50      -   5        $ 	GitButton��50      $��GitHub��6,   $��10,200,10,0q�6=   $��18(�6R   ���#606060���#6060606�   51      � 53      $��1��6   $��0��6#   
������ $��	607,0,0,0q�6I   .+�54      �� $��/ExitButtonImage.png��6   $��
21,10,14,0q�66    J� RenderTransformOrigin$ 	1.026,0.4&�6J   �� 55      -	   5        $ 
ExitButton��55      $��20,10,10,-2q�6F    J� Opacity$ 0Q�6[   ���#6060606h   56      � 5:      -
   5        $ NotesBox��5:      $y�Visible=�6%   $��1��6:   $��1��6J   .+�5;      &   System.Windows.Controls.DataGrid  -   5          Name$ Notesdg��5;         MinRowHeight$ 30Q�6,   $
��Bold"�6>   ���#e5e5e5
������ $��15(�6~   $��10q�6�      AutoGenerateColumns$ False��6�      	CellStyle 5=      �� 5>       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6     �� Triggers 5?      P� 5@   "    P� Property �@ 
IsSelected P� Value$
 True��6@   . �5A   &   ��  �� Property � �� �� Value �#1a1a1a6C   5B   #   5D         Columns 5G      0  *System.Windows.Controls.DataGridTextColumn  5J      -   5        DateColumnBox��,  &System.Windows.Controls.DataGridColumn   Header$
 Date��5J   j      Width5  /System.Windows.Controls.DataGridLengthConverter$	 170 6x      
IsReadOnly$
 True��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   ��  �� Path$ CreationDate�   ElementStyle 5K      �� 5L   "   .�5M   &   ��  � ��$ Bottom=�6[   5N   #      HeaderStyle 5P      �� 5Q   "   =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6(   .�5R   &   ��  � �� �#e5e5e56C   �� 5S   &    � ��
 ���� 6C   5T   #   5V      4  .System.Windows.Controls.DataGridCheckBoxColumn  5Y      $
 Done��6u   $ 80 6�   $ False��6�    61   �� $ isDone�  �� UpdateSourceTrigger$  PropertyChanged=� 5Z      �� 5[   "   "  6(   .�5\   &   ��  � �� �#e5e5e56C   �� 5]   &    � ��
 ���� 6C   �� 5^   &    � ��$ Center=�6L   5_   #   5a        5d      -   5        TaskColumnBox��!   
Foreground! �#e5e5e5$
 Task��5d   w   $ * 6�   $ False��6�    6D   �� $
 Text� 5e      �� 5f   "   .�5g   &   ��  � ��$ Bottom=�6[   5h   #    5j      �� 5k   "   "  6(   .�5l   &   ��  � �� �#e5e5e56C   �� 5m   &    � ��
 ���� 6C   5n   #   5p      5t      5u      � 5v      -   5        " �Name$" SettingsBox��5v      $y�Hidden=�6-   $��1��6A   $��1��6Q   .+�5w      �� $��Themes:��6   $��80,53,30,100q�6+   ���#037e82$��Arial Black)�6V   $��25(�6p   �� 5x      -   5        $ WhiteButton��5x      $��white theme��6.   $��240,50,0,100q�6D   $��18(�6Z   ���#606060���#6060606�   �� 5y      -   5        $ 
DarkButton��5y      $��
dark theme��6-   $��280,-132,0,100q�6B   $��18(�6Z   ���#606060���#6060606�   5{      5|      5}      5      