   M S B A M L   `   `   `  ����C  ?DrenaSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DrenaSysDrenaSys  5   	   9!clr-namespace:DrenaSys.PropertiesDrenaSys.Properties  5   	   c _GMap.NET.WindowsPresentation, Version=1.9.2.0, Culture=neutral, PublicKeyToken=b85b9027b614afefqPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentationGMap.NET.WindowsPresentation 5   	   %    DrenaSys.Windows.MetodoDeGumbel   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DrenaSys     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   1	resources!clr-namespace:DrenaSys.Properties  5   	   \gmapsPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentation  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$X RDrenaSys v 0.01 - Estudos Hidrológicos - Método de Gumbel (Subramanya & Torrico)��5   	   $	��736��6f   $	��732��6s    � WindowStartupLocation$ CenterScreen=�6    � Icon$4 .pack://siteoforigin:,,,/Resources/MainIcon.ico��6�    � WindowStyle$ SingleBorderWindow=�6�    � 
ResizeMode$ CanMinimize=�6�   .��5      � -   5        $��	principal��5      .+�5   
   #  MaterialDesignThemes.Wpf.Chip  {�.  $��267,470,0,139q�60   $	��438��6G   $
��Auto��6S   .��5      �� $
��Wrap=�6    �� TextAlignment$ Justify=�6,   ��O método de gumbel apresentado neste módulo é baseado em observações de Subramanya (2008), a conversão das chuvas de um dia para outros períodos com o intuito de gerar as curvas I.D.F, por sua vez, são baseadas no método das izozonas de Torrico.5      5        5   
   $��10,10,0,656q�6   $
��Auto��63   $	��211��6A   {�.  .��5      �� $!��Precipitações Históricas��6   $��Center=�68   6W   5      �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��626��6T   $��	10,62,0,0q�6a   $	��Top=�6t   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrids��5      	   AutoGenerateColumns	 .  $
��Left=�6G   $	��606��6b   $	��Top=�6o   $��0,9,0,0q�6�   ��6�   �� *listaP+
   ColumnHeaderStyle
 5      �� 5        �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    & "MaterialDesignDataGridColumnHeader �� BasedOn# [ 6>   .�5!      ��  �� Property � �� �� Value$ Center=�6G   6X   �� 5"       � ��$ Center=�6@   6Q   5#      ��5%      �� 5&       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5'      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5(      $ 	#FF632A2A��6'   $ 1Q�69   5)         Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6)      MinWidth$ 80Q�66      Header$	 Ano��6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Q   �� *Ano+ �� Mode$ TwoWay=�   ElementStyle 5-      �� 5.      " ��6$   .�5/   "   ��  � ��$ Center=�6H   50      52        53      $
 Auto 6)   $	 130Q�66   $ Maxima Anual��6E    6[   �� *MaximaAnual+$ TwoWay=� 54      �� 55      " ��6$   .�56   "   ��  � ��$ Center=�6H   57      59      5;      5<      �� 5=   
   $3��-Dados para cálculo da precipitação máxima��6   $
��Left=�6F   $	��431��6a   $��
267,16,0,0q�6n   $	��Top=�6�   $	��438��6�   .��5>      � .+�5?      �� -   5        $��txtNumeroAmostras��5?   :   $��14(�6   {�.  $��0q�6S   $��Center=�6_    ( $MaterialDesignFilledTextFieldTextBox#��[ 6�   $
��Left=�6�   $��59��6�    �� TextWrapping$
 Wrap=�6�   )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Número de amostras (N)��6�   $	��Top=�64  $	��196��6L  $��0,65,0,0q�6X  �� 5@      -   5         ��Name$ txtMedia��5@   :   $��14(�6   {�.  $��0q�6L   $��Center=�6X   #��[ 6|   $
��Left=�6�   $��59��6�   $
 Wrap=�6�   $  Precipitação Média (mm)��6�   $	��Top=�6.  $	��196��6F  $��	0,129,0,0q�6R  �� 5A      -   5        $ txtTR��5A   9   $��14(�6   {�. $��0q�6H   $��Center=�6T   #��[ 6x   $
��Left=�6�   $��59��6�   $
 Wrap=�6�   $ Tempo de retorno (anos)��6�   $	��Top=�6*  $	��196��6B  �� 5B      -   5        $ txtYt��5B   :   $��14(�6   {�.  $��0q�6I   $��Center=�6U   #��[ 6y   $
��Left=�6�   $��59��6�   $
 Wrap=�6�   $ Parâmetro Yt��6�   $	��Top=�6   $	��196��68  $��	224,0,0,0q�6D  �� 5C      -   5        $ txtSn��5C   :   $��14(�6   {�.  $��0q�6I   $��Center=�6U   #��[ 6y   $
��Left=�6�   $��59��6�   $
 Wrap=�6�   $ Parâmetro Sn��6�   $	��Top=�6   $	��196��68  $��	0,257,0,0q�6D  �� 5D      -   5        $ txtyn��5D   :   $��14(�6   {�.  $��0q�6I   $��Center=�6U   #��[ 6y   $
��Left=�6�   $��59��6�   $
 Wrap=�6�   $ Parâmetro yn��6�   $	��Top=�6   $	��196��68  $��	0,193,0,0q�6D  �� 5E      -	   5        $
 txtK��5E   :   $��14(�6   {�.  $��0q�6H   $��Center=�6T   #��[ 6x   $
��Left=�6�   $��59��6�   $
 Wrap=�6�   $ Parâmetro K��6�   $	��Top=�6  $	��196��66  $��
224,65,0,0q�6B  �� 5F      -
   5        $ txtDp��5F   :   $��14(�6   {�.  $��0q�6I   $��Center=�6U   #��[ 6y   $
��Left=�6�   $��59��6�   $
 Wrap=�6�   $ Desvio padrão (mm)��6�   $	��Top=�6&  $	��196��6>  $��224,129,0,0q�6J  �� 5G      -   5        $ txtMaxPrecipt��5G   :   $��14(�6   {�.  $��0q�6Q   $��Center=�6]   #��[ 6�   $
��Left=�6�   $��59��6�   $
 Wrap=�6�   $ Precipitação máx. (mm)��6�   $	��Top=�62  $	��196��6J  $��224,193,0,0q�6V  �� 5H      -   5        $��
txtIzozona��5H   :   $��14(�6   {�. $��0q�6L   $��Center=�6X   $��Center=�6|   $
��Left=�6�   $��45��6�   $ Izozona de Torrico��6�   $	��Top=�6�   $	��196��6  $��224,271,0,0q�6  .@�5I      �� .��6#   Izozona 'A'60   �� 5J      .��6#   Izozona 'B'60   �� 5K      .��6#   Izozona 'C'60   �� 5L      .��6#   Izozona 'D'60   �� 5M      .��6#   Izozona 'E'60   �� 5N      .��6#   Izozona 'F'60   �� 5O      .��6#   Izozona 'G'60   �� 5P      .��6#   Izozona 'H'60   5Q      5S      5T      �� 5U   
   -   5        $��btnExportReport��5U      $
��Left=�6F   $��342,587,0,0q�6a   $	��Top=�6v   $	��267��6�   $��39��6�   .��5V      ��  �� Orientation$ 
Horizontal=�6   .+�5W      '
  !MaterialDesignThemes.Wpf.PackIcon
  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Export=�6*   $��25��68   $��25��6C   �� 5X      $��Center=�6   $��5 0 0 0q�67   Exportar relatório completo6e   5Y      5Z      �� 5[   
   -   5        $��btnClearFields��5[      $
��Left=�6D   $��385,644,0,0q�6_   $	��Top=�6t   $	��184��6�   $��39��6�   .��5\      �� $ 
Horizontal=�6   .+�5]      
  $ Broom=�6*   $��25��67   $��25��6B   �� 5^      $��Center=�6   $��5 0 0 0q�67   �� 6I   $�Resetar campos��6M   6f   5_      5`      �� 5a   
   -   5        $��btnIzozonas��5a      $
��Left=�6>   $��354,392,0,0q�6Y   $	��Top=�6n   $	��265��6�   .��5b      �� $ 
Horizontal=�6   .+�5c      
  $ 	OpenInNew=�6*   �� 5d      $%�� Ver mapa de izozonas (Torrico)��6   5e      5f      5j      5k      