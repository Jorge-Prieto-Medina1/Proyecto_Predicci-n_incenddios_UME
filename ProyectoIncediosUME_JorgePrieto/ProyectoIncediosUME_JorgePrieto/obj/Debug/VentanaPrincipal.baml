   M S B A M L   `   `   `  ����Z  VProyectoIncediosUME_JorgePrieto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ProyectoIncediosUME_JorgePrietoProyectoIncediosUME_JorgePrieto  5   	   _4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases&ProyectoIncediosUME_JorgePrieto.Clases  5   	   6    0ProyectoIncediosUME_JorgePrieto.VentanaPrincipal   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ProyectoIncediosUME_JorgePrieto     5   	   Gclases4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases     5   	   -   5          � Title$  VentanaPrincipal��5	   	   $	��600��6"   $
��1000��6/    � WindowStartupLocation$ CenterScreen=�6<    � 
ResizeMode$ NoResize=�6a   ���	#FF53C27D � WindowStyle$
 None=�6�    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ clases:Comandos.salir��5      6X     5   
   -   5        $&  clases:Comandos.gestinarUsuarios��5      6c     5   
   -   5        $/ )clases:Comandos.accederHistorialIncendios��5      6l     5   
   -   5        $3 -clases:Comandos.modificarRegistrosDeIncendios��5      6p     5   
   -   5        $2 ,clases:Comandos.modificarDatosMeteorologicos��5      6o     5   
   -   5        $7 1clases:Comandos.consultarProbabilidadesDeIncendio��5      6t     5   
   -   5        $* $clases:Comandos.modificarLocalidades��5      6g   .��5      � .+�5   
   �� $
��Left=�6   $	��350��6/   $��355,120,355,0q�6<   
�������$	��Top=�6f   $	��290��6~   $��0��6�   ��5      �� 5       �� ImageSource$ 
escudo.png��6   5      �� 5   
   -	   5         ��Name$ btnSalir��5   .   $��Salir del programa��6   $
��Left=�6@   $��48��6[   $��374,511.5,0,0q�6g   $	��Top=�6~   $	��250��6�   ���	#FF3679CD$��18(�6�   $��Lucida Sans Unicode)�6�   $��clases:Comandos.salir��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 	#FFEEDF49��6#    � Offset$ 0Q�65   � 5       $
 White��6#   $ 1Q�61   5!      5#      �� 5$   
   $
��Left=�6   $��45��6/   $��
150,45,0,0q�6;   $
��Wrap=�6O   $/��)Bienvenido a Predicción de incendios Ume��6c   $	��Top=�6�   $	��700��6�   $��34(�6�   ���	#FF3679CD$��Lucida Sans Unicode)�6�   �� 5%   
   -
   5        $ btnAdministracionUsuarios��5%   6   $!��Administración de usuarios��6   $
��Left=�6Y   $��48��6t   $��
25,120,0,0q�6�   $	��Top=�6�   $	��270��6�   ���	#FF3679CD$��18(�6�   $��Lucida Sans Unicode)�6�   $y�Hidden=�6�   $&�� clases:Comandos.gestinarUsuarios��6  ��5&      �� 5'      $ 0.5,1&�6&   $	 0.5,0&�67   .��5(      � $
 	#FFEEDF49��6#   $ 0Q�65   � 5)      $
 White��6#   $ 1Q�61   5*      5,      �� 5-   
   -   5        $ btnHistorialIncendios��5-   =   $'��!Acceder al historial de Incendios��6   $
��Left=�6\   $��48��6w   $��25,271.5,0,0q�6�   $	��Top=�6�   $	��270��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $/��)clases:Comandos.accederHistorialIncendios��6  ��5.      �� 5/      $ 0.5,1&�6&   $	 0.5,0&�67   .��50      � $
 	#FFEEDF49��6#   $ 0Q�65   � 51      $
 White��6#   $ 1Q�61   52      54      �� 55   
   -   5        $# btnModificarHistoralIncendios��55   ?   $)��#Modificar el historial de incendios��6   $
��Left=�6f   $��48��6�   $��
25,422,0,0q�6�   $	��Top=�6�   $	��270��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $y�Hidden=�6  $3��-clases:Comandos.modificarRegistrosDeIncendios��6  ��56      �� 57      $ 0.5,1&�6&   $	 0.5,0&�67   .��58      � $
 	#FFEEDF49��6#   $ 0Q�65   � 59      $
 White��6#   $ 1Q�61   5:      5<      �� 5=   
   -   5        $&  btnModificarDatosMeteorológicos��5=   :   $%��Modificar datos climatológicos��6   $
��Left=�6c   $��48��6~   $��700,120,25,0q�6�   $	��Top=�6�   $	��270��6�   ���	#FF3679CD$��16(�6�   $��Lucida Sans Unicode)�6�   $y�Hidden=�6
  $2��,clases:Comandos.modificarDatosMeteorologicos��6  ��5>      �� 5?      $ 0.5,1&�6&   $	 0.5,0&�67   .��5@      � $
 	#FFEEDF49��6#   $ 0Q�65   � 5A      $
 White��6#   $ 1Q�61   5B      5D      �� 5E   
   -   5        $! btnProbabilidadesDeIncendio��5E   A   $+��%Consultar probabilidades de incendios��6   $
��Left=�6f   $��48��6�   $��700,271.5,25,0q�6�   $	��Top=�6�   $	��270��6�   ���	#FF3679CD$��14(�6�   $��Lucida Sans Unicode)�6�   $7��1clases:Comandos.consultarProbabilidadesDeIncendio��6  ��5F      �� 5G      $ 0.5,1&�6&   $	 0.5,0&�67   .��5H      � $
 	#FFEEDF49��6#   $ 0Q�65   � 5I      $
 White��6#   $ 1Q�61   5J      5L      �� 5M   
   -   5        $ btnModificarLocalidades��5M   1   $��Modificar localidades��6   $
��Left=�6R   $��48��6m   $��700,422,25,0q�6y   $	��Top=�6�   $	��270��6�   ���	#FF3679CD$��18(�6�   $��Lucida Sans Unicode)�6�   $y�Hidden=�6�   $*��$clases:Comandos.modificarLocalidades��6  ��5N      �� 5O      $ 0.5,1&�6&   $	 0.5,0&�67   .��5P      � $
 	#FFEEDF49��6#   $ 0Q�65   � 5Q      $
 White��6#   $ 1Q�61   5R      5T      5V      5W      