   M S B A M L   `   `   `  ����Z  VProyectoIncediosUME_JorgePrieto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Iclr-namespace:ProyectoIncediosUME_JorgePrieto.VentanasDatosMeteorologicos;ProyectoIncediosUME_JorgePrieto.VentanasDatosMeteorologicos  5   
   _4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases&ProyectoIncediosUME_JorgePrieto.Clases  5   	   i    cProyectoIncediosUME_JorgePrieto.VentanasDatosMeteorologicos.VentanaModificarRegistrosMeteorologicos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   [localIclr-namespace:ProyectoIncediosUME_JorgePrieto.VentanasDatosMeteorologicos     5   
   Gclases4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases     5   	   :xctk)http://schemas.xceed.com/wpf/xaml/toolkit     5   	   -   5          � Title$/  )Ventana Para Añadir Registros Climaticos��5
      $��565.114��68   $��626.25��6I    � WindowStartupLocation$ CenterScreen=�6X    � 
ResizeMode$ NoResize=�6}   ���	#FF499BEE � WindowStyle$
 None=�6�    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$! clases:Comandos.volverAtras��5      6[     5   
   -   5        $# clases:Comandos.modificarDato��5      6f   .��5      � .+�5   
   �� -   5         ��Name$ btnVolverAtras��5   (   $��Volver atras��6   $
��Left=�6@   $��41.767��6[   $��406.413,37.105,0,0q�6k   $	��Top=�6�   $��150.927��6�   ���	#FF3679CD$��18(�6�   $��Lucida Sans Unicode)�6�   $!��clases:Comandos.volverAtras��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 #EEDF49��6#   
 � Offset$
 0Q�63   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5   
   $
��Left=�6   $��39.157��6/   $��46.206,37.105,0,0q�6?   $
��Wrap=�6Z   $��Modificar registro��6n   $	��Top=�6�   $��312.936��6�   $��34(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   �� 5   
   $
��Left=�6   $��29.368��6/   $��184.517,129.207,0,0q�6?   $
��Wrap=�6\   $	��Top=�6p   $��85.441��6�   $��18(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�    J� RenderTransformOrigin$ 0.505,-0.167&�6�   �� 6  $�Provinci��6  �� 6  $�a:��6  6+  �� 5   
   -   5         ��Name$ txtProvincia��5      $
��Left=�6(   $��29.368��6C   $��302.149,129.207,0,0q�6S   $	��Top=�6p   $��210.559��6�   $��18(�6�   �� 5   
   $
��Left=�6   $��29.368��6/   $��167.642,196.1,0,0q�6?   $
��Wrap=�6Z   $	��Top=�6n   $��102.316��6�   $��20(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   �� 6  $�L��6  �� 6  $�	ocalidad:��6  6*  �� 5   
   -   5        $ txtLocalidad��5      $
��Left=�6(   $��29.368��6C   $��302.149,196.1,0,0q�6S   $	��Top=�6n   $��210.559��6�   $��18(�6�   �� 5   
   -   5        $ 
btnAñadir��5   %   $��	Modificar��6   $
��Left=�68   $��42��6S   $��227,501,0,0q�6_   $	��Top=�6t   $	��151��6�   ���	#FF3679CD$��18(�6�   $��Lucida Sans Unicode)�6�   $#��clases:Comandos.modificarDato��6�   ��5      �� 5       $ 0.5,1&�6&   $ 0.5,0&�67   .��5!      � $	 #EEDF49��6#   $
 0Q�63   � 5"      $	 White��6#   $
 1Q�61   5#      5%      �� 5&   
   $
��Left=�6   $��30��6/   $��
80,262,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��201��6{   $��20(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   $��Temperatura media:��6�   �� 5'   
   -   5        $ 
txtTempMed��5'        �� 	MaxLength$ 3��6   $
��Left=�64   $��30��6O   $��302,262,0,0q�6[    �� TextWrapping$
 Wrap=�6p   $	��Top=�6�   $	��211��6�   $��18(�6�   �� 5(   
   $
��Left=�6   $��30��6/   $��110,329,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��160��6|   $��20(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   �� 6�   $�HumedadMedia��6�   �� 6  $�:��6  6  �� 5)   
   -	   5        $ 	txtHumMed��5)       $ 3��6   $
��Left=�63   $��30��6N   $��302,329,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��211��6�   $��18(�6�   $ 
0.36,0.433&�6�   �� 5*   
   $
��Left=�6   $��30��6/   $��115,389,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��155��6|   $��20(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   $��Fecha de inicio:��6�   (  "System.Windows.Controls.DatePicker  5+   
   -
   5          Name$ dpkFechaInicio��5+      |�.  $
��Left=�6A   $��302,387,0,0q�6\   $	��Top=�6q   $	��211��6�   $��18(�6�   �� 5,   
   $
��Left=�6   $��30��6/   $��
46,441,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��224��6{   $��20(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   �� 6�   $�Fecha de finalizaci��6�   �� 6  $�ó��6  �� 6$  $�n:��6(  65    5-   
   -   5        $ dpkFechaFinalizacion��5-      |�.  $
��Left=�6G   $��302,441,0,0q�6b   $	��Top=�6w   $	��211��6�   $��18(�6�   5.      5/      