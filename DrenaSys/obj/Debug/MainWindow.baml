   M S B A M L   `   `   `  ����C  ?DrenaSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DrenaSysDrenaSys  5   	   9!clr-namespace:DrenaSys.PropertiesDrenaSys.Properties  5   	       DrenaSys.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DrenaSys     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   1	resources!clr-namespace:DrenaSys.Properties  5   	   -   5          �Name$  window��5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ DrenaSys v 0.01��5   	   $	��800��6!   $
��1100��6.    � WindowStartupLocation$ CenterScreen=�6;    � Icon$4 .pack://siteoforigin:,,,/Resources/MainIcon.ico��6`    � WindowStyle$ SingleBorderWindow=�6�    � 
ResizeMode$ CanMinimize=�6�   .��5      � -   5        $��mainGrid��5      .+�5   
   R� $
��Left=�6   $	��706��6.   $��	10,10,0,0q�6;   $	��Top=�6N   $	��310��6f   |�.  .@�5      Q� -   5        $"��treeGrupoEstudosHidrologicos��5      $��Estudos hidrológicos��6?   |�.  .@�5      Q� -   5        $��treeChildEquacoes��5      |�.  ��5      �� 5       �� Orientation$ 
Horizontal=�6%   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]	   Kind$	 Water=�66   
����  �$��25��6U   $��25��6`   $��0q�6l   6z   �� 5      $��10 0 0 0q�6(   $��Center=�6:   Equações de chuva6h   5      5      Q� 5      -   5        $��
treeGumbel��5      |�.  ��5      �� 5      $ 
Horizontal=�6%   .+�5         $	 
Number9Box=�66   
����  �$��25��6Z   $��25��6e   $��0q�6q   6   �� 5!      $��10 0 0 0q�6(   $��Center=�6:   Método de Gumbel6g   5"      5$      Q� 5%      -   5        $��treeChildHidrograma��5%      {�.  ��5&      �� 5'      $ 
Horizontal=�6%   .+�5(        $	 
Calculator=�66   
����  �$��20��6Z   $��20��6e   $��2 0 0 0q�6q   6�   �� 5)      $��10 0 0 0q�6(   " Hidrograma triângular unitário6Z   5*      5,      5-      5/      �� 50   
   $
��Left=�6   $��30��6/   $��	0,740,0,0q�6;   $	��Top=�6N   $
��1094��6f   ��51      �� 52      .R�53      � 
 � ColumnDefinitions
 54      �� 55      61   �� 56      61   �� 57      61   �� 58      61   �� 59      61   �� 5:      61   �� 5;      61   �� 5<      61   �� 5=      61   �� 5>      61   �� 5?      61   �� 5@      61   �� 5A      61   �� 5B      61   �� 5C      61   5E      5F      .@�5H      �� $��0��6   6.   5I      5K      5L      