   M S B A M L   `   `   `  ����Z  VProyectoIncediosUME_JorgePrieto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases&ProyectoIncediosUME_JorgePrieto.Clases  5   	   N    HProyectoIncediosUME_JorgePrieto.VentanasIncendios.VentanaAñadirIncendio   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Gclases4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases     5   	   :xctk)http://schemas.xceed.com/wpf/xaml/toolkit     5   	   -   5          � Title$&   Ventana Para Añadir Localidades��5	   	   $��638.75��61   $��626.25��6A    � WindowStartupLocation$ CenterScreen=�6P    � 
ResizeMode$ NoResize=�6u   ���	#FFEE4958 � WindowStyle$
 None=�6�    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$! clases:Comandos.volverAtras��5      6[     5   
   -   5        $% clases:Comandos.añadirIncendio��5      6g   .��5      � .+�5   
   �� -   5         ��Name$ btnVolverAtras��5   (   $��Volver atras��6   $
��Left=�6@   $��41.767��6[   $��406.413,37.105,0,0q�6k   $	��Top=�6�   $��150.927��6�   ���	#FF3679CD$��18(�6�   $��Lucida Sans Unicode)�6�   $!��clases:Comandos.volverAtras��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 #53C27D��6#   
 � Offset$
 0Q�63   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5   
   $
��Left=�6   $��39.157��6/   $��46.206,37.105,0,0q�6?   $
��Wrap=�6Z   $��Añadir incendio��6n   $	��Top=�6�   $��312.936��6�   $��34(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   �� 5   
   $
��Left=�6   $��29.368��6/   $��184.517,129.207,0,0q�6?   $
��Wrap=�6\   $	��Top=�6p   $��85.441��6�   $��18(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�    J� RenderTransformOrigin$ 0.505,-0.167&�6�   �� 6  $�Provinci��6  �� 6  $�a:��6  6+  �� 5   
   -   5         ��Name$ cmbProvincias��5      $
��Left=�6*   $��29.368��6E   $��302.149,129.207,0,0q�6U   $	��Top=�6r   $��210.559��6�   $��18(�6�   6�   �� 5   
   $
��Left=�6   $��29.368��6/   $��167.642,196.1,0,0q�6?   $
��Wrap=�6Z   $	��Top=�6n   $��102.316��6�   $��20(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   �� 6  $�L��6  �� 6  $�	ocalidad:��6  6*  �� 5   
   -   5        $ cmbLocalidades��5      $
��Left=�6+   $��29.368��6F   $��302.149,196.1,0,0q�6V   $	��Top=�6q   $��210.559��6�   $��18(�6�   �� 5   
   -   5        $ 
btnAñadir��5   "   $��Añadir��6   $
��Left=�65   $��41.768��6P   $��226.781,566.434,0,0q�6`   $	��Top=�6}   $��150.927��6�   ���	#FF3679CD$��18(�6�   $��Lucida Sans Unicode)�6�   $%��clases:Comandos.añadirIncendio��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5       � $	 #53C27D��6#   $
 0Q�63   � 5!      $	 White��6#   $
 1Q�61   5"      5$      �� 5%   
   $
��Left=�6   $��29.368��6/   $��59.958,267.165,0,0q�6?   $
��Wrap=�6[   $	��Top=�6o   $	��210��6�   $��20(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   $��Hectáreas quemadas:��6�   �� 5&   
   -   5         ��Name$ txtHectareas��5&      $
��Left=�6)   $��29.368��6D   $��302.149,259.73,0,0q�6T    �� TextWrapping$
 Wrap=�6p   $	��Top=�6�   $��210.559��6�   $��18(�6�   �� 5'   
   $
��Left=�6   $��29.368��6/   $��69.118,326.623,0,0q�6?   $
��Wrap=�6[   $	��Top=�6o   $��200.84��6�   $��20(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   $��Temperatura media:��6  �� 5(   
   -	   5        $ 
txtTempMed��5(        �� 	MaxLength$ 3��6   $
��Left=�64   $��29.368��6O   $��302.149,326.623,0,0q�6_   $
 Wrap=�6|   $	��Top=�6�   $��210.559��6�   $��18(�6�   �� 5)   
   $
��Left=�6   $��29.367��6/   $��109.958,393.517,0,0q�6?   $
��Wrap=�6\   $	��Top=�6p   $	��160��6�   $��20(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   �� 6  $�HumedadMedia��6  �� 6  $�:��6  6+  �� 5*   
   -
   5        $ 	txtHumMed��5*       $ 3��6   $
��Left=�63   $��29.367��6N   $��302.149,393.517,0,0q�6^   $
 Wrap=�6{   $	��Top=�6�   $��210.559��6�   $��18(�6�   �� 5+   
   $
��Left=�6   $��29.367��6/   $��114.958,453.884,0,0q�6?   $
��Wrap=�6\   $	��Top=�6p   $	��155��6�   $��20(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   $��Fecha de inicio:��6   (  "System.Windows.Controls.DatePicker  5,   
   -   5          Name$ dpkFechaInicio��5,      |�.  $
��Left=�6A   $��302.149,453.884,0,0q�6\   $	��Top=�6y   $��210.559��6�   $��18(�6�   �� 5-   
   $
��Left=�6   $��29.367��6/   $��79.958,506.384,0,0q�6?   $
��Wrap=�6[   $	��Top=�6o   $	��190��6�   $��20(�6�   ���	#FFEEDF49$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   $��Fecha de extinción:��6�     5.   
   -   5        $ dpkFechaExtincion��5.      |�.  $
��Left=�6D   $��302.149,506.384,0,0q�6_   $	��Top=�6|   $��210.559��6�   $��18(�6�   5/      50      