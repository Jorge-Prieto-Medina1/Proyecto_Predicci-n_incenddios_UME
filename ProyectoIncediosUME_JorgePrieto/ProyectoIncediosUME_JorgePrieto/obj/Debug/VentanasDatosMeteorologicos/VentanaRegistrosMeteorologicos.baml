   M S B A M L   `   `   `  ����Z  VProyectoIncediosUME_JorgePrieto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases&ProyectoIncediosUME_JorgePrieto.Clases  5      `    ZProyectoIncediosUME_JorgePrieto.VentanasDatosMeteorologicos.VentanaRegistrosMeteorologicos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Gclases4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases     5      -   5          � Title$&   Ventana Registros Climatologicos��5   	   $	��450��62   $	��800��6?    � WindowStartupLocation$ CenterScreen=�6K    � 
ResizeMode$ NoResize=�6p   ���#499BEE � WindowStyle$
 None=�6�    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$! clases:Comandos.volverAtras��5
      6[     5   
   -   5        $" clases:Comandos.eliminarDato��5      6e     5   
   -   5        $! clases:Comandos.añadirDato��5      6c     5   
   -   5        $# clases:Comandos.modificarDato��5      6f   .��5      � $	��800��6   $	��450��6   .+�5   
   �� -   5         ��Name$ btnAñadirDato��5   +   $��Añadir Registro��6   $
��Left=�6B   $��48��6]   $��30.625,359.625,0,0q�6i   $	��Top=�6�   $	��200��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $!��clases:Comandos.añadirDato��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 #53C27D��6#   
 � Offset$
 0Q�63   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5   
   -   5        $ btnEliminarDato��5   -   $��Eliminar Registro��6   $
��Left=�6F   $��48��6a   $��562,360,0,0q�6m   $	��Top=�6�   $	��200��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $"��clases:Comandos.eliminarDato��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $	 #53C27D��6#   $
 0Q�63   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5    
   -   5        $ btnVolverAtras��5    (   $��Volver atras��6   $
��Left=�6@   $��48��6[   $��
602,24,0,0q�6g   $	��Top=�6{   $	��160��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $!��clases:Comandos.volverAtras��6�   ��5!      �� 5"      $ 0.5,1&�6&   $ 0.5,0&�67   .��5#      � $	 #53C27D��6#   $
 0Q�63   � 5$      $	 White��6#   $
 1Q�61   5%      5'      �� 5(   
   $
��Left=�6   $��45��6/   $��	60,25,0,0q�6;   $
��Wrap=�6N   $0��*Modificación de registros climatológicos��6b   $	��Top=�6�   $	��517��6�   $��26(�6�   ���#EEDF49$��Lucida Sans Unicode)�6�   &   System.Windows.Controls.DataGrid  5)   
   -	   5          Name$ dgrDatosMeteorologicos��5)      $
��Left=�63   $	��240��6N   $��	20,95,0,0q�6[   $	��Top=�6n   $	��750��6�      
IsReadOnly .    SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�   $��Lucida Sans Unicode)�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   5*      �� 5+   
   -
   5        $ btnModificarDato��5+   .   $��Modificar Registro��6   $
��Left=�6H   $��48��6c   $��291,360,0,0q�6o   $	��Top=�6�   $	��200��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $#��clases:Comandos.modificarDato��6�   ��5,      �� 5-      $ 0.5,1&�6&   $ 0.5,0&�67   .��5.      � $	 #53C27D��6#   $
 0Q�63   � 5/      $	 White��6#   $
 1Q�61   50      52      54      55      