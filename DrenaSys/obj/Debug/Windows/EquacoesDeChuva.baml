   M S B A M L   `   `   `  ����C  ?DrenaSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DrenaSysDrenaSys  5   	   9!clr-namespace:DrenaSys.PropertiesDrenaSys.Properties  5   	   c _GMap.NET.WindowsPresentation, Version=1.9.2.0, Culture=neutral, PublicKeyToken=b85b9027b614afefqPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentationGMap.NET.WindowsPresentation 5   	   &     DrenaSys.Windows.EquacoesDeChuva   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DrenaSys     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   1	resources!clr-namespace:DrenaSys.Properties  5   	   \gmapsPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentation  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$O IDrenaSys v 0.01 - Estudos Hidrológicos - Método das Equações de chuva��5   	   $	��733��6W   $
��1117��6d    � WindowStartupLocation$ CenterScreen=�6q    � Icon$4 .pack://siteoforigin:,,,/Resources/MainIcon.ico��6�    � WindowStyle$ SingleBorderWindow=�6�    � 
ResizeMode$ CanMinimize=�6�   .��5      � $��0q�6   .+�5   
   �� $-��'Selecione a equação de chuva desejada��6   $
��Left=�6B   $	��463��6]   $��	10,10,0,0q�6j   $	��Top=�6}   $	��874��6�   .��5      .  (GMap.NET.WindowsPresentation.GMapControl  -   5        $��mapView��5          Zoom$ 13Q�6/      MaxZoom$ 24��69   	   MinZoom$	 1��6F   6T   5      �� 5   
   $.��(Parâmetros para tempo de concentração��6   $
��Left=�6B   $	��187��6]   $��
10,492,0,0q�6j   $	��Top=�6~   $	��254��6�   .��5      � $	��171��6   $��
0,-8,0,-61q�6    $	��Top=�64   $	��244��6L   .+�5      �� -   5        $��txtTalv��5   U    % !MaterialDesignFloatingHintTextBox#��[ 6   $
��Left=�6d   $��42��6   $��	43,10,0,0q�6�   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Talvegue principal (km)��6�   $	��Top=�6�   $��Center=�6�   $	��142��6  �� 5      -   5        $��	txtDesniv��5   U   #��[ 6   $
��Left=�6f   $��35��6�   $��	44,57,0,0q�6�   $
 Desnível máximo (m)��6�   $��Center=�6�   $	��Top=�6�   $	��143��6  �� 5      -   5        $��cboxMetodos��5      $
��Left=�6.   $��
44,111,0,0q�6I   $	��Top=�6]   $	��142��6u   $
 Método de cálculo��6�   $��Center=�6�   .@�5      �� $��Center=�6#   .��6G   	Kirpich6P   �� 5       $��Center=�6#   .��6G   Kirpich modificada6[   5!      5"      5#      �� 5$   
   $'��!Parâmetros I.D.F obtidos no mapa��6   $
��Left=�6=   $	��187��6X   $��286,492,0,0q�6e   $	��Top=�6z   $	��598��6�   .��5%      � $	��102��6   $	��Top=�6    $	��583��68   .+�5&      �� -   5        $��pk��5&   g   #��[ 6    �� 
IsReadOnly . $
��Left=�6q   $��45��6�   $��	10,10,0,0q�6�   $
 Parâmetro k��6�   $	��Top=�6�   $��Center=�6�   $	��142��6  �� 5'      -   5        $��pn��5'   h   #��[ 6    . $
��Left=�6r   $��39��6�   $��	10,63,0,0q�6�   $
 Parâmetro n��6�   $	��Top=�6�   $��Center=�6�   $	��142��6  �� 5(      -   5        $��to��5(   h   #��[ 6    . $
��Left=�6r   $��42��6�   $��
171,60,0,0q�6�   $
 Parâmetro to��6�   $	��Top=�6�   $��Center=�6�   $	��142��6  �� 5)      -   5        $��pm��5)   h   #��[ 6    . $
��Left=�6r   $��45��6�   $��
171,10,0,0q�6�   $
 Parâmetro m��6�   $	��Top=�6�   $��Center=�6�   $	��142��6  �� 5*      -	   5        $��
nomeCidade��5*   h   #��[ 6    . $
��Left=�6z   $��45��6�   $��
334,34,0,0q�6�   $#
 Nome da estação selecionada��6�   $	��Top=�6�   $��Center=�6
  $	��239��6.  5+      5,      �� 5-   
   $
��Left=�6   $	��294��60   $��
898,10,0,0q�6=   $	��Top=�6Q   $	��186��6i   .+�5.      �� -
   5        $��btnCalc��5.   +   $��5 10 5 0q�6U   .��5/      ��  �� Orientation$ 
Horizontal=�6   .+�50      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ 
Calculator=�6.   $��Center=�6@   $��25��6[   $��25��6g   �� 51      $��Calcular��6    $��Center=�60   $��10 0 0 0q�6L   52      53      �� 54      -   5        $��btnReset��54      $��5 10 5 0q�6@   .��55      �� $ 
Horizontal=�6   .+�56        $ Broom=�6.   $��Center=�6;   $��25��6V   $��25��6b   �� 57      $��Resetar��6    $��Center=�6/   $��10 0 0 0q�6K   58      59      �� 5:      -   5        $��btnExportReport��5:      $��5 10 5 0q�6e   .��5;      �� $ 
Horizontal=�6   .+�5<        $ Export=�6.   $��Center=�6<   $��25��6W   $��25��6c   �� 5=      $��Exportar relatório��6    $��Center=�6:   $��5 0 0 0q�6V   5>      5?      �� 5@      -   5        $��txtTempoFinal��5@      #��[ 6+   $��5 30 0 5q�6f   $#
 Tempo de concentração (min)��6x   
���   �$��Center=�6�   {�.  6�   �� 5A      -   5        $��txtPrecipitacaoFinal��5A      #��[ 62   $��0,30,0,5q�6m   $%
 Precipitação calculada (mm/h)��6   
���   �$��Right=�6�   {�.  $	��181��6�   $��Center=�6  5C      �� 5D   
   $��Parâmetros estatísticos��6   $
��Left=�64   $	��116��6O   $��898,563,0,0q�6\   $	��Top=�6q   $	��186��6�   .��5E      �� -   5        $��txtTr��5E      #��[ 6#    .  $
��Left=�6q   $��38��6�   $��0,10,0,0q�6�   $
 Tempo de retorno (anos)��6�   $	��Top=�6�   $��Center=�6�   $	��168��6   J� RenderTransformOrigin$ 0.378,0.513&�6+  5F      5H      5I      