   M S B A M L   `   `   `  ����Z  VProyectoIncediosUME_JorgePrieto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ProyectoIncediosUME_JorgePrietoProyectoIncediosUME_JorgePrieto  5   	   _4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases&ProyectoIncediosUME_JorgePrieto.Clases  5   	   Q    KProyectoIncediosUME_JorgePrieto.VentanasIncendios.VentanaRegistrosIncendios   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ProyectoIncediosUME_JorgePrieto     5   	   Gclases4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases     5   	   -   5          � Title$!  Ventana Registros Incendios��5	   	   $	��450��6-   $	��900��6:    � WindowStartupLocation$ CenterScreen=�6F    � 
ResizeMode$ NoResize=�6k   ���#EEDF49 � WindowStyle$
 None=�6�    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$! clases:Comandos.volverAtras��5      6[     5   
   -   5        $&  clases:Comandos.eliminarIncendio��5      6i     5   
   -   5        $% clases:Comandos.añadirIncendio��5      6g     5   
   -   5        $' !clases:Comandos.modificarIncendio��5      6j   .��5      � $	��800��6   $	��450��6   .+�5   
   �� -   5         ��Name$ btnAñadirIncendio��5   +   $��Añadir Incendio��6   $
��Left=�6F   $��48��6a   $��30.625,359.625,0,0q�6m   $	��Top=�6�   $	��200��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $%��clases:Comandos.añadirIncendio��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 #53C27D��6#   
 � Offset$
 0Q�63   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5   
   -   5        $ btnEliminarIncendio��5   -   $��Eliminar Incendio��6   $
��Left=�6J   $��48��6e   $��562,360,0,0q�6q   $	��Top=�6�   $	��200��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $&�� clases:Comandos.eliminarIncendio��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $	 #53C27D��6#   $
 0Q�63   � 5      $	 White��6#   $
 1Q�61   5      5       �� 5!   
   -   5        $ btnVolverAtras��5!   (   $��Volver atras��6   $
��Left=�6@   $��48��6[   $��601.875,32.5,0,0q�6g   $	��Top=�6�   $	��160��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $!��clases:Comandos.volverAtras��6�   ��5"      �� 5#      $ 0.5,1&�6&   $ 0.5,0&�67   .��5$      � $	 #53C27D��6#   $
 0Q�63   � 5%      $	 White��6#   $
 1Q�61   5&      5(      �� 5)   
   $
��Left=�6   $��45��6/   $��216.875,24.467,0,0q�6;   $
��Wrap=�6W   $��Registros de incendios��6k   $	��Top=�6�   $	��380��6�   $��34(�6�   ���	#FFEE4958$��Lucida Sans Unicode)�6�   &   System.Windows.Controls.DataGrid  5*   
   -	   5          Name$ dgrIncendios��5*      $
��Left=�6)   $	��230��6D   $��-29,103,-30,0q�6Q   $	��Top=�6h   $	��859��6�      
IsReadOnly .    SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�   $��Lucida Sans Unicode)�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   5+      �� 5,   
   -
   5        $ btnModificarIncendio��5,   .   $��Modificar Incendio��6   $
��Left=�6L   $��48��6g   $��291,360,0,0q�6s   $	��Top=�6�   $	��200��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $'��!clases:Comandos.modificarIncendio��6�   ��5-      �� 5.      $ 0.5,1&�6&   $ 0.5,0&�67   .��5/      � $	 #53C27D��6#   $
 0Q�63   � 50      $	 White��6#   $
 1Q�61   51      53      55      56      