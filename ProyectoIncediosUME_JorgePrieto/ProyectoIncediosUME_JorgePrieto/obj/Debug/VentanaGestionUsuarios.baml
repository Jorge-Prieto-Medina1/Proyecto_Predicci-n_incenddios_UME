   M S B A M L   `   `   `  ����Z  VProyectoIncediosUME_JorgePrieto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ProyectoIncediosUME_JorgePrietoProyectoIncediosUME_JorgePrieto  5   	   _4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases&ProyectoIncediosUME_JorgePrieto.Clases  5   	   <    6ProyectoIncediosUME_JorgePrieto.VentanaGestionUsuarios   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ProyectoIncediosUME_JorgePrieto     5   	   Gclases4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases     5   	   -   5          � Title$  VentanaGestionUsuarios��5	   	   $	��450��6(   $	��800��65    � WindowStartupLocation$ CenterScreen=�6A    � 
ResizeMode$ NoResize=�6f   ���#499BEE � WindowStyle$
 None=�6�    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$! clases:Comandos.volverAtras��5      6[     5   
   -   5        $. (clases:Comandos.activarDesactivarUsuario��5      6q     5   
   -   5        $% clases:Comandos.eliminarUsuario��5      6h   .��5      � $	��800��6   $	��450��6   .+�5   
   �� -   5         ��Name$! btnActivarDesactivarUsuario��5   6   $ ��Activar/desactivar usuario��6   $
��Left=�6[   $��48��6v   $��30.625,359.625,0,0q�6�   $	��Top=�6�   $	��240��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $.��(clases:Comandos.activarDesactivarUsuario��6  ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 	#FFEEDF49��6#   
 � Offset$
 0Q�65   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5   
   -   5        $ btnEliminarUsuario��5   ,   $��Eliminar usuario��6   $
��Left=�6H   $��48��6c   $��521.875,359.625,0,0q�6o   $	��Top=�6�   $	��240��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $%��clases:Comandos.eliminarUsuario��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $	 	#FFEEDF49��6#   $
 0Q�65   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5    
   -   5        $ btnVolverAtras��5    (   $��Volver atras��6   $
��Left=�6@   $��48��6[   $��601.875,32.5,0,0q�6g   $	��Top=�6�   $	��160��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $!��clases:Comandos.volverAtras��6�   ��5!      �� 5"      $ 0.5,1&�6&   $ 0.5,0&�67   .��5#      � $	 	#FFEEDF49��6#   $
 0Q�65   � 5$      $	 White��6#   $
 1Q�61   5%      5'      �� 5(   
   $
��Left=�6   $��45��6/   $��226.875,24.467,0,0q�6;   $
��Wrap=�6W   $��Gestión de usuarios��6k   $	��Top=�6�   $	��330��6�   $��34(�6�   ���	#FFEE4958$��Lucida Sans Unicode)�6�   &   System.Windows.Controls.DataGrid  5)   
   -   5          Name$ dgrUsuarios��5)      $
��Left=�6(   $	��230��6C   $��
85,105,0,0q�6P   $	��Top=�6d   $	��635��6|      
IsReadOnly .    SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�   $��Lucida Sans Unicode)�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   5+      5,      