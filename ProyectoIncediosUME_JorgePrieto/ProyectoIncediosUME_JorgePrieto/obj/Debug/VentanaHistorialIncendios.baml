   M S B A M L   `   `   `  ����Z  VProyectoIncediosUME_JorgePrieto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ProyectoIncediosUME_JorgePrietoProyectoIncediosUME_JorgePrieto  5   	   _4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases&ProyectoIncediosUME_JorgePrieto.Clases  5      ?    9ProyectoIncediosUME_JorgePrieto.VentanaHistorialIncendios   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ProyectoIncediosUME_JorgePrieto     5   	   Gclases4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases     5      -   5          � Title$!  Ventana Registros Incendios��5	   	   $	��470��6-   $	��900��6:    � WindowStartupLocation$ CenterScreen=�6F    � 
ResizeMode$ NoResize=�6k   ���#EEDF49 � WindowStyle$
 None=�6�    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$! clases:Comandos.volverAtras��5      6V     5   
   -   5        $ clases:Comandos.buscar��5      6Q     5   
   -   5        $ clases:Comandos.limpiar��5      6R   .��5      � $	��800��6   $	��450��6   .+�5   
   �� -   5         ��Name$ btnEliminarIncendio��5   "   $��Buscar��6   $
��Left=�6?   $��31��6Z   $��651,348,0,0q�6f   $	��Top=�6{   $	��111��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $��clases:Comandos.buscar��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 #53C27D��6#   
 � Offset$
 0Q�63   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5   
   -   5        $ btnVolverAtras��5   (   $��Volver atras��6   $
��Left=�6@   $��48��6[   $��601.875,32.5,0,0q�6g   $	��Top=�6�   $	��160��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $!��clases:Comandos.volverAtras��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $	 #53C27D��6#   $
 0Q�63   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5    
   $
��Left=�6   $��45��6/   $��	82,31,0,0q�6;   $
��Wrap=�6N   $)��#Historial de registros de incendios��6b   $	��Top=�6�   $	��481��6�   $��28(�6�   ���	#FFEE4958$��Lucida Sans Unicode)�6�   &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ dgrIncendios��5!      $
��Left=�6)   $	��230��6D   $��-29,100,-32,0q�6Q   $	��Top=�6h   $	��861��6�      
IsReadOnly .    SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�   $��Lucida Sans Unicode)�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   5"      �� 5#   
   -   5         ��Name$ cmbProvincias��5#      $
��Left=�6*   $��29��6E   $��176,348,0,0q�6Q   $	��Top=�6f   $	��160��6~   $��18(�6�   6�   �� 5$   
   $
��Left=�6   $��30��6/   $��
50,405,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��97��6{   $��20(�6�   ���#EE4958$��Lucida Sans Unicode)�6�    J� RenderTransformOrigin$ 0.505,-0.167&�6�   �� 6�   $�L��6�   �� 6   $�	ocalidad:��6  6  �� 5%   
   -	   5        $ cmbLocalidades��5%      $
��Left=�6+   $��29��6F   $��176,405,0,0q�6R   $	��Top=�6g   $	��160��6   $��18(�6�   �� 5&   
   $
��Left=�6   $��30��6/   $��
66,348,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��81��6{   $��18(�6�   ���#EE4958$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   �� 6�   $�Provinci��6�   �� 6  $�a:��6  6  �� 5'   
   $
��Left=�6   $��30��6/   $��363,404,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $��63��6|   $��20(�6�   ���#EE4958$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   $��Hasta��6�   (  "System.Windows.Controls.DatePicker  5(   
   -
   5          Name$ dpkDesde��5(      |�.  $
��Left=�6;   $��443,349,0,0q�6V   $	��Top=�6k   $	��186��6�   $��16(�6�   $��29��6�   $ 
0.55,0.567&�6�   �� 5)   
   $
��Left=�6   $��30��6/   $��363,349,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $��62��6|   $��20(�6�   ���#EE4958$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   $��Desde��6�     5*   
   -   5        $ dpkHasta��5*      |�.  $
��Left=�6;   $��443,406,0,0q�6V   $	��Top=�6k   $	��186��6�   $��16(�6�   $��30��6�   �� 5+   
   -   5        $ btnEliminarLimpiar��5+   #   $��Limpiar��6   $
��Left=�6?   $��31��6Z   $��651,403,0,0q�6f   $	��Top=�6{   $	��111��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $��clases:Comandos.limpiar��6�   ��5,      �� 5-      $ 0.5,1&�6&   $ 0.5,0&�67   .��5.      � $	 #53C27D��6#   $
 0Q�63   � 5/      $	 White��6#   $
 1Q�61   50      52      54      55      