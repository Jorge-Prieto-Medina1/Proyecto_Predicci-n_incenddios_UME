   M S B A M L   `   `   `  ����Z  VProyectoIncediosUME_JorgePrieto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ProyectoIncediosUME_JorgePrietoProyectoIncediosUME_JorgePrieto  5   	   _4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases&ProyectoIncediosUME_JorgePrieto.Clases  5   	   H    BProyectoIncediosUME_JorgePrieto.VentanasLocalidad.VentanaLocalidad   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ProyectoIncediosUME_JorgePrieto     5   	   Gclases4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases     5   	   -   5          � Title$!  VentanaModificarLocalidades��5	   	   $	��450��6-   $	��800��6:    � WindowStartupLocation$ CenterScreen=�6F    � 
ResizeMode$ NoResize=�6k   ���#53C27D � WindowStyle$
 None=�6�    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$! clases:Comandos.volverAtras��5      6[     5   
   -   5        $' !clases:Comandos.eliminarLocalidad��5      6j     5   
   -   5        $&  clases:Comandos.añadirLocalidad��5      6h     5   
   -   5        $( "clases:Comandos.modificarLocalidad��5      6k   .��5      � $	��800��6   $	��450��6   .+�5   
   �� -   5         ��Name$ btnAñadirLocalidad��5   ,   $��Añadir localidad��6   $
��Left=�6H   $��48��6c   $��30.625,359.625,0,0q�6o   $	��Top=�6�   $	��200��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $&�� clases:Comandos.añadirLocalidad��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 	#FFEEDF49��6#   
 � Offset$
 0Q�65   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5   
   -   5        $ btnEliminarLocalidad��5   .   $��Eliminar localidad��6   $
��Left=�6L   $��48��6g   $��562,360,0,0q�6s   $	��Top=�6�   $	��200��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $'��!clases:Comandos.eliminarLocalidad��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $	 	#FFEEDF49��6#   $
 0Q�65   � 5      $	 White��6#   $
 1Q�61   5      5!      �� 5"   
   -   5        $ btnVolverAtras��5"   (   $��Volver atras��6   $
��Left=�6@   $��48��6[   $��601.875,32.5,0,0q�6g   $	��Top=�6�   $	��160��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $!��clases:Comandos.volverAtras��6�   ��5#      �� 5$      $ 0.5,1&�6&   $ 0.5,0&�67   .��5%      � $	 	#FFEEDF49��6#   $
 0Q�65   � 5&      $	 White��6#   $
 1Q�61   5'      5)      �� 5*   
   $
��Left=�6   $��45��6/   $��216.875,24.467,0,0q�6;   $
��Wrap=�6W   $��Gestión de localidedes��6k   $	��Top=�6�   $	��380��6�   $��34(�6�   ���	#FF006AD4$��Lucida Sans Unicode)�6�   &   System.Windows.Controls.DataGrid  5+   
   -	   5          Name$ dgrLocalidades��5+      $
��Left=�6+   $	��230��6F   $��161,103,0,0q�6S   $	��Top=�6h   $	��482��6�      
IsReadOnly .    SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�   $��Lucida Sans Unicode)�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   5,      �� 5-   
   -
   5        $ btnModificarLocalidad��5-   /   $��Modificar localidad��6   $
��Left=�6N   $��48��6i   $��291,360,0,0q�6u   $	��Top=�6�   $	��200��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $(��"clases:Comandos.modificarLocalidad��6�   ��5.      �� 5/      $ 0.5,1&�6&   $ 0.5,0&�67   .��50      � $	 	#FFEEDF49��6#   $
 0Q�65   � 51      $	 White��6#   $
 1Q�61   52      54      56      57      